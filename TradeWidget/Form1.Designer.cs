
namespace TradeWidget
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_ticker = new System.Windows.Forms.TextBox();
            this.txtbox_entry = new System.Windows.Forms.TextBox();
            this.txtbox_stoploss = new System.Windows.Forms.TextBox();
            this.txtbox_risk = new System.Windows.Forms.TextBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.txtbox_buyingpower = new System.Windows.Forms.TextBox();
            this.label_buyingpower = new System.Windows.Forms.Label();
            this.radiobtn_2RAON = new System.Windows.Forms.RadioButton();
            this.radiobtn_1R2R = new System.Windows.Forms.RadioButton();
            this.grpbox_plan = new System.Windows.Forms.GroupBox();
            this.error_ticker = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_entry = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_stoploss = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_risk = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_buyingpower = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_plan = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpbox_plan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_ticker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_entry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_stoploss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_risk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_buyingpower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_plan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticker:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entry:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stoploss:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Risk:";
            // 
            // txtbox_ticker
            // 
            this.txtbox_ticker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbox_ticker.Location = new System.Drawing.Point(62, 22);
            this.txtbox_ticker.Name = "txtbox_ticker";
            this.txtbox_ticker.Size = new System.Drawing.Size(97, 23);
            this.txtbox_ticker.TabIndex = 4;
            this.txtbox_ticker.Click += new System.EventHandler(this.txtbox_ticker_Click);
            // 
            // txtbox_entry
            // 
            this.txtbox_entry.Location = new System.Drawing.Point(62, 56);
            this.txtbox_entry.Name = "txtbox_entry";
            this.txtbox_entry.Size = new System.Drawing.Size(97, 23);
            this.txtbox_entry.TabIndex = 5;
            this.txtbox_entry.Click += new System.EventHandler(this.txtbox_entry_Click);
            this.txtbox_entry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_entry_KeyPress);
            // 
            // txtbox_stoploss
            // 
            this.txtbox_stoploss.Location = new System.Drawing.Point(62, 94);
            this.txtbox_stoploss.Name = "txtbox_stoploss";
            this.txtbox_stoploss.Size = new System.Drawing.Size(97, 23);
            this.txtbox_stoploss.TabIndex = 6;
            this.txtbox_stoploss.Click += new System.EventHandler(this.txtbox_stoploss_Click);
            this.txtbox_stoploss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_stoploss_KeyPress);
            // 
            // txtbox_risk
            // 
            this.txtbox_risk.Location = new System.Drawing.Point(62, 130);
            this.txtbox_risk.Name = "txtbox_risk";
            this.txtbox_risk.Size = new System.Drawing.Size(97, 23);
            this.txtbox_risk.TabIndex = 7;
            this.txtbox_risk.Click += new System.EventHandler(this.txtbox_risk_Click);
            this.txtbox_risk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_risk_KeyPress);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(62, 179);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(80, 42);
            this.btn_order.TabIndex = 8;
            this.btn_order.Text = "Place Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // txtbox_buyingpower
            // 
            this.txtbox_buyingpower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_buyingpower.Location = new System.Drawing.Point(204, 447);
            this.txtbox_buyingpower.Name = "txtbox_buyingpower";
            this.txtbox_buyingpower.Size = new System.Drawing.Size(154, 23);
            this.txtbox_buyingpower.TabIndex = 10;
            this.txtbox_buyingpower.Click += new System.EventHandler(this.txtbox_buyingpower_Click);
            // 
            // label_buyingpower
            // 
            this.label_buyingpower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buyingpower.AutoSize = true;
            this.label_buyingpower.Location = new System.Drawing.Point(118, 451);
            this.label_buyingpower.Name = "label_buyingpower";
            this.label_buyingpower.Size = new System.Drawing.Size(83, 15);
            this.label_buyingpower.TabIndex = 11;
            this.label_buyingpower.Text = "Buying Power:";
            // 
            // radiobtn_2RAON
            // 
            this.radiobtn_2RAON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radiobtn_2RAON.AutoSize = true;
            this.radiobtn_2RAON.Location = new System.Drawing.Point(15, 50);
            this.radiobtn_2RAON.Name = "radiobtn_2RAON";
            this.radiobtn_2RAON.Size = new System.Drawing.Size(67, 19);
            this.radiobtn_2RAON.TabIndex = 12;
            this.radiobtn_2RAON.TabStop = true;
            this.radiobtn_2RAON.Text = "2R AON";
            this.radiobtn_2RAON.UseVisualStyleBackColor = true;
            // 
            // radiobtn_1R2R
            // 
            this.radiobtn_1R2R.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radiobtn_1R2R.AutoSize = true;
            this.radiobtn_1R2R.Location = new System.Drawing.Point(15, 78);
            this.radiobtn_1R2R.Name = "radiobtn_1R2R";
            this.radiobtn_1R2R.Size = new System.Drawing.Size(105, 19);
            this.radiobtn_1R2R.TabIndex = 13;
            this.radiobtn_1R2R.TabStop = true;
            this.radiobtn_1R2R.Text = "1R + 2R Targets";
            this.radiobtn_1R2R.UseVisualStyleBackColor = true;
            // 
            // grpbox_plan
            // 
            this.grpbox_plan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbox_plan.Controls.Add(this.radiobtn_1R2R);
            this.grpbox_plan.Controls.Add(this.radiobtn_2RAON);
            this.grpbox_plan.Location = new System.Drawing.Point(204, 25);
            this.grpbox_plan.Name = "grpbox_plan";
            this.grpbox_plan.Size = new System.Drawing.Size(130, 140);
            this.grpbox_plan.TabIndex = 15;
            this.grpbox_plan.TabStop = false;
            this.grpbox_plan.Text = "Plan:";
            // 
            // error_ticker
            // 
            this.error_ticker.ContainerControl = this;
            // 
            // error_entry
            // 
            this.error_entry.ContainerControl = this;
            // 
            // error_stoploss
            // 
            this.error_stoploss.ContainerControl = this;
            // 
            // error_risk
            // 
            this.error_risk.ContainerControl = this;
            // 
            // error_buyingpower
            // 
            this.error_buyingpower.ContainerControl = this;
            // 
            // error_plan
            // 
            this.error_plan.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 471);
            this.Controls.Add(this.grpbox_plan);
            this.Controls.Add(this.label_buyingpower);
            this.Controls.Add(this.txtbox_buyingpower);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.txtbox_risk);
            this.Controls.Add(this.txtbox_stoploss);
            this.Controls.Add(this.txtbox_entry);
            this.Controls.Add(this.txtbox_ticker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbox_plan.ResumeLayout(false);
            this.grpbox_plan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_ticker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_entry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_stoploss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_risk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_buyingpower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_plan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_ticker;
        private System.Windows.Forms.TextBox txtbox_entry;
        private System.Windows.Forms.TextBox txtbox_stoploss;
        private System.Windows.Forms.TextBox txtbox_risk;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.TextBox txtbox_buyingpower;
        private System.Windows.Forms.Label label_buyingpower;
        private System.Windows.Forms.RadioButton radiobtn_2RAON;
        private System.Windows.Forms.RadioButton radiobtn_1R2R;
        private System.Windows.Forms.GroupBox grpbox_plan;
        private System.Windows.Forms.ErrorProvider error_ticker;
        private System.Windows.Forms.ErrorProvider error_entry;
        private System.Windows.Forms.ErrorProvider error_stoploss;
        private System.Windows.Forms.ErrorProvider error_risk;
        private System.Windows.Forms.ErrorProvider error_buyingpower;
        private System.Windows.Forms.ErrorProvider error_plan;
    }
}

