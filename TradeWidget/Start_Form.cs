using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TradeWidget
{
    public partial class Start_Form : Form
    {
        public static int port = 0;

        public Start_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            port = 7497;
            var Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port = 7496;
            var Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
