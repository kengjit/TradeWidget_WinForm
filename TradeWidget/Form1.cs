using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krs.Ats.IBNet;
using System.Threading;
using Krs.Ats.IBNet.Contracts;


namespace TradeWidget
{
    public partial class Form1 : Form
    {
        private static int NextOrderId;
        private static bool NextOrderReceived;
        private static IBClient client;
        private static Equity Ticker;
        private static bool order_placed = false;
        private static bool order_error = false;
        private static int order_error_count = 0;
        private static bool debugmode = false;

        public struct Bracket
        {
            public Order parent;
            public Order takeprofit;
            public Order stopLoss;
            public Order MarketOnCLose;
        };

        public Form1()
        {
            InitializeComponent();
            setup();
        }

        // ADDITIONAL FUNCTIONS
        public void setup()
        {
            client = new IBClient();
            client.TickPrice += client_TickPrice;
            client.TickSize += client_TickSize;
            client.Error += client_Error;
            client.NextValidId += client_NextValidId;
            client.UpdateMarketDepth += client_UpdateMktDepth;
            client.RealTimeBar += client_RealTimeBar;
            client.OrderStatus += client_OrderStatus;
            client.ExecDetails += client_ExecDetails;
            client.Connect("127.0.0.1", Start_Form.port, 0);
        }

        public void GetNextId()
        {
            client.RequestIds(-1);
            Thread.Sleep(100);
        }

        public int Get_Quantity()
        {
            if ((int)Math.Floor(decimal.Parse(txtbox_risk.Text) / Math.Abs(decimal.Parse(txtbox_entry.Text) - decimal.Parse(txtbox_stoploss.Text))) >= (int)Math.Floor(decimal.Parse(txtbox_buyingpower.Text) / decimal.Parse(txtbox_entry.Text)))
            {
                return (int)Math.Floor(decimal.Parse(txtbox_buyingpower.Text) / decimal.Parse(txtbox_entry.Text));
            }
            return (int)Math.Floor(decimal.Parse(txtbox_risk.Text) / Math.Abs(decimal.Parse(txtbox_entry.Text) - decimal.Parse(txtbox_stoploss.Text)));
        }

        public bool all_filled()
        {
            return !String.IsNullOrEmpty(txtbox_ticker.Text) && !String.IsNullOrEmpty(txtbox_entry.Text) && !String.IsNullOrEmpty(txtbox_stoploss.Text) && !String.IsNullOrEmpty(txtbox_risk.Text) &&
                !String.IsNullOrEmpty(txtbox_buyingpower.Text) && (radiobtn_2RAON.Checked || radiobtn_1R2R.Checked);
        }

        public void Place_Bracket_Order(Equity Ticker)
        {
            Bracket bracket = new Bracket();

            decimal R;
            if (radiobtn_2RAON.Checked)
                R = 2;
            else 
                R = decimal.Parse(txtbox_customR.Text);

            bracket.parent = new Order();
            bracket.parent.OrderId = NextOrderId;
            bracket.parent.Action = btn_long_short.Text == "LONG" ? ActionSide.Buy : ActionSide.Sell;
            bracket.parent.OrderType = OrderType.StopLimit;
            bracket.parent.AuxPrice = decimal.Parse(txtbox_entry.Text);
            bracket.parent.LimitPrice = btn_long_short.Text == "LONG" ? bracket.parent.AuxPrice + Math.Round((decimal)0.2 * (decimal.Parse(txtbox_entry.Text) - decimal.Parse(txtbox_stoploss.Text)), 2) : bracket.parent.AuxPrice - Math.Round((decimal)0.2 * (decimal.Parse(txtbox_entry.Text) - decimal.Parse(txtbox_stoploss.Text)), 2);
            bracket.parent.TotalQuantity = Get_Quantity();
            bracket.parent.Transmit = false;
            bracket.parent.OutsideRth = true;

            bracket.takeprofit = new Order();
            bracket.takeprofit.OrderId = NextOrderId + 1; 
            bracket.takeprofit.Action = btn_long_short.Text == "LONG" ? ActionSide.Sell : ActionSide.Buy;
            bracket.takeprofit.OrderType = OrderType.Limit;
            bracket.takeprofit.LimitPrice = btn_long_short.Text == "LONG" ? R * (decimal.Parse(txtbox_entry.Text) - decimal.Parse(txtbox_stoploss.Text)) + decimal.Parse(txtbox_entry.Text) : decimal.Parse(txtbox_entry.Text) - R * (decimal.Parse(txtbox_stoploss.Text) - decimal.Parse(txtbox_entry.Text));
            bracket.takeprofit.TotalQuantity = bracket.parent.TotalQuantity;
            bracket.takeprofit.ParentId = bracket.parent.OrderId;
            bracket.takeprofit.Transmit = false;
            bracket.takeprofit.OutsideRth = true;

            bracket.MarketOnCLose = new Order();
            bracket.MarketOnCLose.OrderId = NextOrderId + 2;
            bracket.MarketOnCLose.Action = ActionSide.Sell;
            bracket.MarketOnCLose.OrderType = OrderType.MarketOnClose;
            bracket.MarketOnCLose.TotalQuantity = bracket.parent.TotalQuantity;
            bracket.MarketOnCLose.ParentId = bracket.parent.OrderId;
            bracket.MarketOnCLose.Transmit = false;
            bracket.MarketOnCLose.OutsideRth = true;

            bracket.stopLoss = new Order();
            bracket.stopLoss.OrderId = NextOrderId + 3;
            bracket.stopLoss.Action = btn_long_short.Text == "LONG" ? ActionSide.Sell : ActionSide.Buy;
            bracket.stopLoss.OrderType = OrderType.Stop;
            bracket.stopLoss.AuxPrice = decimal.Parse(txtbox_stoploss.Text);
            bracket.stopLoss.TotalQuantity = bracket.parent.TotalQuantity;
            bracket.stopLoss.ParentId = bracket.parent.OrderId;
            bracket.stopLoss.Transmit = true;
            bracket.stopLoss.OutsideRth = true;


            client.PlaceOrder(bracket.parent.OrderId, Ticker, bracket.parent);
            client.PlaceOrder(bracket.takeprofit.OrderId, Ticker, bracket.takeprofit);
            client.PlaceOrder(bracket.MarketOnCLose.OrderId, Ticker, bracket.MarketOnCLose);
            client.PlaceOrder(bracket.stopLoss.OrderId, Ticker, bracket.stopLoss);

            // Include in Table
            ordertable.Rows.Add(bracket.parent.TotalQuantity, txtbox_ticker.Text, txtbox_entry.Text, txtbox_stoploss.Text);
        }

        public void Place_Double_Bracket_Order(Equity Ticker)
        {
            int quantity = Get_Quantity();
            int quantity1;
            int quantity2;
            // Even Shares
            if (quantity % 2 == 0)
            {
                quantity1 = quantity / 2;
                quantity2 = quantity / 2;
            }
            else // Odd Shares
            {
                quantity1 = quantity / 2 + 1;
                quantity2 = quantity / 2;
            }

            Bracket bracket_1 = new Bracket();

            bracket_1.parent = new Order();
            bracket_1.parent.OrderId = NextOrderId;
            bracket_1.parent.Action = ActionSide.Buy;
            bracket_1.parent.OrderType = OrderType.StopLimit;
            bracket_1.parent.AuxPrice = decimal.Parse(txtbox_entry.Text);
            bracket_1.parent.LimitPrice = bracket_1.parent.AuxPrice + Math.Round((decimal)0.2 * (decimal.Parse(txtbox_entry.Text) - decimal.Parse(txtbox_stoploss.Text)), 2);
            bracket_1.parent.TotalQuantity = quantity1;
            bracket_1.parent.Transmit = false;
            bracket_1.parent.OutsideRth = true;

            bracket_1.takeprofit = new Order();
            bracket_1.takeprofit.OrderId = NextOrderId + 1;
            bracket_1.takeprofit.Action = ActionSide.Sell;
            bracket_1.takeprofit.OrderType = OrderType.Limit;
            bracket_1.takeprofit.LimitPrice = 2 * (decimal.Parse(txtbox_entry.Text) - decimal.Parse(txtbox_stoploss.Text)) + decimal.Parse(txtbox_entry.Text);
            bracket_1.takeprofit.TotalQuantity = bracket_1.parent.TotalQuantity;
            bracket_1.takeprofit.ParentId = bracket_1.parent.OrderId;
            bracket_1.takeprofit.Transmit = false;
            bracket_1.takeprofit.OutsideRth = true;

            bracket_1.MarketOnCLose = new Order();
            bracket_1.MarketOnCLose.OrderId = NextOrderId + 2;
            bracket_1.MarketOnCLose.Action = ActionSide.Sell;
            bracket_1.MarketOnCLose.OrderType = OrderType.MarketOnClose;
            bracket_1.MarketOnCLose.TotalQuantity = bracket_1.parent.TotalQuantity;
            bracket_1.MarketOnCLose.ParentId = bracket_1.parent.OrderId;
            bracket_1.MarketOnCLose.Transmit = false;
            bracket_1.MarketOnCLose.OutsideRth = true;

            bracket_1.stopLoss = new Order();
            bracket_1.stopLoss.OrderId = NextOrderId + 3;
            bracket_1.stopLoss.Action = ActionSide.Sell;
            bracket_1.stopLoss.OrderType = OrderType.Stop;
            bracket_1.stopLoss.AuxPrice = decimal.Parse(txtbox_stoploss.Text);
            bracket_1.stopLoss.TotalQuantity = bracket_1.parent.TotalQuantity;
            bracket_1.stopLoss.ParentId = bracket_1.parent.OrderId;
            bracket_1.stopLoss.Transmit = true;
            bracket_1.stopLoss.OutsideRth = true;


            Bracket bracket_2 = new Bracket();

            bracket_2.parent = new Order();
            bracket_2.parent.OrderId = NextOrderId + 4;
            bracket_2.parent.Action = ActionSide.Buy;
            bracket_2.parent.OrderType = OrderType.StopLimit;
            bracket_2.parent.AuxPrice = decimal.Parse(txtbox_entry.Text);
            bracket_2.parent.LimitPrice = bracket_2.parent.AuxPrice + Math.Round((decimal)0.2 * (decimal.Parse(txtbox_entry.Text) - decimal.Parse(txtbox_stoploss.Text)), 2);
            bracket_2.parent.TotalQuantity = quantity2;
            bracket_2.parent.Transmit = false;
            bracket_2.parent.OutsideRth = true;

            bracket_2.takeprofit = new Order();
            bracket_2.takeprofit.OrderId = NextOrderId + 5;
            bracket_2.takeprofit.Action = ActionSide.Sell;
            bracket_2.takeprofit.OrderType = OrderType.Limit;
            bracket_2.takeprofit.LimitPrice = 2 * decimal.Parse(txtbox_entry.Text) - decimal.Parse(txtbox_stoploss.Text);
            bracket_2.takeprofit.TotalQuantity = bracket_2.parent.TotalQuantity;
            bracket_2.takeprofit.ParentId = bracket_2.parent.OrderId;
            bracket_2.takeprofit.Transmit = false;
            bracket_2.takeprofit.OutsideRth = true;

            bracket_2.MarketOnCLose = new Order();
            bracket_2.MarketOnCLose.OrderId = NextOrderId + 6;
            bracket_2.MarketOnCLose.Action = ActionSide.Sell;
            bracket_2.MarketOnCLose.OrderType = OrderType.MarketOnClose;
            bracket_2.MarketOnCLose.TotalQuantity = bracket_2.parent.TotalQuantity;
            bracket_2.MarketOnCLose.ParentId = bracket_2.parent.OrderId;
            bracket_2.MarketOnCLose.Transmit = false;
            bracket_2.MarketOnCLose.OutsideRth = true;

            bracket_2.stopLoss = new Order();
            bracket_2.stopLoss.OrderId = NextOrderId + 7;
            bracket_2.stopLoss.Action = ActionSide.Sell;
            bracket_2.stopLoss.OrderType = OrderType.Stop;
            bracket_2.stopLoss.AuxPrice = decimal.Parse(txtbox_stoploss.Text);
            bracket_2.stopLoss.TotalQuantity = bracket_2.parent.TotalQuantity;
            bracket_2.stopLoss.ParentId = bracket_2.parent.OrderId;
            bracket_2.stopLoss.Transmit = true;
            bracket_2.stopLoss.OutsideRth = true;


            client.PlaceOrder(bracket_1.parent.OrderId, Ticker, bracket_1.parent);
            client.PlaceOrder(bracket_1.takeprofit.OrderId, Ticker, bracket_1.takeprofit);
            client.PlaceOrder(bracket_1.MarketOnCLose.OrderId, Ticker, bracket_1.MarketOnCLose);
            client.PlaceOrder(bracket_1.stopLoss.OrderId, Ticker, bracket_1.stopLoss);

            client.PlaceOrder(bracket_2.parent.OrderId, Ticker, bracket_2.parent);
            client.PlaceOrder(bracket_2.takeprofit.OrderId, Ticker, bracket_2.takeprofit);
            client.PlaceOrder(bracket_2.MarketOnCLose.OrderId, Ticker, bracket_2.MarketOnCLose);
            client.PlaceOrder(bracket_2.stopLoss.OrderId, Ticker, bracket_2.stopLoss);

            // Include in Table
            ordertable.Rows.Add(quantity, txtbox_ticker.Text, txtbox_entry.Text, txtbox_stoploss.Text);
        }

        // FORM EVENT HANDLERS
        private void btn_order_Click(object sender, EventArgs e)
        {
            order_placed = false;
            NextOrderReceived = false;

            // Get Next Valid ID
            GetNextId();
            while (!NextOrderReceived)
            {
                Thread.Sleep(100);
            }

            if (!String.IsNullOrEmpty(txtbox_ticker.Text) && !String.IsNullOrEmpty(txtbox_entry.Text) && !String.IsNullOrEmpty(txtbox_stoploss.Text) && !String.IsNullOrEmpty(txtbox_risk.Text)
                && !String.IsNullOrEmpty(txtbox_buyingpower.Text) && (radiobtn_2RAON.Checked || radiobtn_1R2R.Checked || (radiobtn_custom.Checked && !String.IsNullOrEmpty(txtbox_customR.Text))) && ((btn_long_short.Text == "LONG" && decimal.Parse(txtbox_entry.Text) > decimal.Parse(txtbox_stoploss.Text)) || (btn_long_short.Text == "SHORT" && decimal.Parse(txtbox_entry.Text) < decimal.Parse(txtbox_stoploss.Text)))
                && Math.Abs(decimal.Parse(txtbox_entry.Text) - decimal.Parse(txtbox_stoploss.Text)) <= decimal.Parse(txtbox_risk.Text))
            {
                Ticker = new Equity(txtbox_ticker.Text);
                // Remove all errors if exists
                error_ticker.Clear();
                error_entry.Clear();
                error_stoploss.Clear();
                error_risk.Clear();
                error_buyingpower.Clear();
                error_plan.Clear();
                
                while (!order_placed)
                {
                    if (order_error)
                    {
                        switch (order_error_count)
                        {
                            case 1:
                                Ticker.PrimaryExchange = "NYSE";
                                break;
                            case 2:
                                Ticker.PrimaryExchange = "NASDAQ";
                                break;
                            case 3:
                                Ticker.PrimaryExchange = "AMEX";
                                break;
                            case 4:
                                MessageBox.Show("Unable to find " + "'" + txtbox_ticker.Text + "'");
                                order_placed = true;
                                break;
                        }
                    }
                    if (radiobtn_2RAON.Checked || radiobtn_custom.Checked)
                        Place_Bracket_Order(Ticker);
                    else if (radiobtn_1R2R.Checked)
                        Place_Double_Bracket_Order(Ticker);
                    order_error_count++;
                    while (!order_placed && !order_error)
                    {
                        Thread.Sleep(100);
                    }
                }
                order_error_count = 0;
                order_placed = false;

                // Reset textbox fields
                txtbox_ticker.Clear();
                txtbox_entry.Clear();
                txtbox_stoploss.Clear();
            }
            else
            {
                if (String.IsNullOrEmpty(txtbox_ticker.Text))
                    error_ticker.SetError(txtbox_ticker, "Please enter Ticker Symbol");
                else
                    error_ticker.Clear();
                if (String.IsNullOrEmpty(txtbox_entry.Text))
                    error_entry.SetError(txtbox_entry, "Please enter Entry Price");
                else
                    error_entry.Clear();
                if (String.IsNullOrEmpty(txtbox_stoploss.Text))
                    error_stoploss.SetError(txtbox_stoploss, "Please enter Stoploss Price");
                else
                    error_stoploss.Clear();
                if (String.IsNullOrEmpty(txtbox_risk.Text))
                    error_risk.SetError(txtbox_risk, "Please enter Risk Amount");
                else
                    error_risk.Clear();
                if (String.IsNullOrEmpty(txtbox_buyingpower.Text))
                {
                    error_buyingpower.SetIconAlignment(label_buyingpower, ErrorIconAlignment.MiddleLeft);
                    error_buyingpower.SetError(label_buyingpower, "Please enter Buying Power");
                }
                else
                    error_buyingpower.Clear();
                if (!radiobtn_2RAON.Checked && !radiobtn_1R2R.Checked)
                    error_plan.SetError(grpbox_plan, "Please select a plan");
                else
                    error_plan.Clear();

                if (all_filled())
                {
                    if (decimal.Parse(txtbox_entry.Text) <= decimal.Parse(txtbox_stoploss.Text))
                    {
                        error_entry.SetError(txtbox_entry, "Entry Price must be higher than stoploss");
                        error_stoploss.SetError(txtbox_stoploss, "Entry Price must be higher than stoploss");
                    }
                    else if ((decimal.Parse(txtbox_entry.Text) - decimal.Parse(txtbox_stoploss.Text)) > decimal.Parse(txtbox_risk.Text))
                        error_risk.SetError(txtbox_risk, "Risk amount too low");
                    else
                    {
                        error_risk.Clear();
                        error_entry.Clear();
                        error_stoploss.Clear();
                    }
                }
            }
        }

        private void txtbox_entry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtbox_stoploss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtbox_risk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtbox_ticker_Click(object sender, EventArgs e)
        {
            txtbox_ticker.SelectAll();
        }

        private void txtbox_entry_Click(object sender, EventArgs e)
        {
            txtbox_entry.SelectAll();
        }

        private void txtbox_stoploss_Click(object sender, EventArgs e)
        {
            txtbox_stoploss.SelectAll();
        }

        private void txtbox_risk_Click(object sender, EventArgs e)
        {
            txtbox_risk.SelectAll();
        }

        private void txtbox_buyingpower_Click(object sender, EventArgs e)
        {
            txtbox_buyingpower.SelectAll();
        }

        private void menuStrip_file_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip_tools_orderhist_Click(object sender, EventArgs e)
        {
            if (menuStrip_tools_orderhist.Checked)
            {
                ordertable.Show();
            }
            else
                ordertable.Hide();
        }
        private void menuStrip_tools_debug_Click(object sender, EventArgs e)
        {
            if (menuStrip_tools_debug.Checked)
            {
                debugmode = true;
            }
            else
                debugmode = false;
        }

        private void menuStrip_help_guide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }

        private void btn_long_short_Click(object sender, EventArgs e)
        {
            if (btn_long_short.Text == "LONG")
            {
                btn_long_short.Text = "SHORT";
                this.BackColor = Color.LightPink;
            }
            else
            {
                btn_long_short.Text = "LONG";
                this.BackColor = Color.PaleGreen;
            }
        }
        // EVENT HANDLERS

        static void client_ExecDetails(object sender, ExecDetailsEventArgs e)
        {
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                e.Contract.Symbol, e.Execution.AccountNumber, e.Execution.ClientId, e.Execution.Exchange, e.Execution.ExecutionId,
                e.Execution.Liquidation, e.Execution.OrderId, e.Execution.PermId, e.Execution.Price, e.Execution.Shares, e.Execution.Side, e.Execution.Time);
        }

        static void client_RealTimeBar(object sender, RealTimeBarEventArgs e)
        {
            Console.WriteLine("Received Real Time Bar: " + e.Close);
        }

        static void client_OrderStatus(object sender, OrderStatusEventArgs e)
        {
            Console.WriteLine("Order Placed.");
            order_placed = true;
        }

        static void client_UpdateMktDepth(object sender, UpdateMarketDepthEventArgs e)
        {
            Console.WriteLine("Tick ID: " + e.TickerId + " Tick Side: " + EnumDescConverter.GetEnumDescription(e.Side) +
                              " Tick Size: " + e.Size + " Tick Price: " + e.Price + " Tick Position: " + e.Position +
                              " Operation: " + EnumDescConverter.GetEnumDescription(e.Operation));
        }

        static void client_NextValidId(object sender, NextValidIdEventArgs e)
        {
            Console.WriteLine("Next Valid Id: " + e.OrderId);
            NextOrderId = e.OrderId;
            NextOrderReceived = true;
        }

        static void client_TickSize(object sender, TickSizeEventArgs e)
        {
            Console.WriteLine("Tick Size: " + e.Size + " Tick Type: " + EnumDescConverter.GetEnumDescription(e.TickType));
        }

        static void client_Error(object sender, ErrorEventArgs e)
        {
            if ((int)e.ErrorCode == 200)
                order_error = true;

            Console.WriteLine("Error: " + e.ErrorMsg);

            if (debugmode)
                MessageBox.Show("Error: " + e.ErrorMsg);
        }

        static void client_TickPrice(object sender, TickPriceEventArgs e)
        {
            Console.WriteLine("Price: " + e.Price + " Tick Type: " + EnumDescConverter.GetEnumDescription(e.TickType));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
