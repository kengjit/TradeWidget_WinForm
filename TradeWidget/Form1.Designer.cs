
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.txtbox_customR = new System.Windows.Forms.TextBox();
            this.radiobtn_custom = new System.Windows.Forms.RadioButton();
            this.error_ticker = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_entry = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_stoploss = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_risk = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_buyingpower = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_plan = new System.Windows.Forms.ErrorProvider(this.components);
            this.ordertable = new System.Windows.Forms.DataGridView();
            this.table_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_stoploss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_tools_orderhist = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_tools_debug = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_help_guide = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_long_short = new System.Windows.Forms.Button();
            this.grpbox_plan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_ticker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_entry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_stoploss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_risk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_buyingpower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_plan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticker:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entry:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stoploss:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Risk:";
            // 
            // txtbox_ticker
            // 
            this.txtbox_ticker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbox_ticker.Location = new System.Drawing.Point(62, 38);
            this.txtbox_ticker.Name = "txtbox_ticker";
            this.txtbox_ticker.Size = new System.Drawing.Size(97, 23);
            this.txtbox_ticker.TabIndex = 4;
            this.txtbox_ticker.Click += new System.EventHandler(this.txtbox_ticker_Click);
            // 
            // txtbox_entry
            // 
            this.txtbox_entry.Location = new System.Drawing.Point(62, 72);
            this.txtbox_entry.Name = "txtbox_entry";
            this.txtbox_entry.Size = new System.Drawing.Size(97, 23);
            this.txtbox_entry.TabIndex = 5;
            this.txtbox_entry.Click += new System.EventHandler(this.txtbox_entry_Click);
            this.txtbox_entry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_entry_KeyPress);
            // 
            // txtbox_stoploss
            // 
            this.txtbox_stoploss.Location = new System.Drawing.Point(62, 110);
            this.txtbox_stoploss.Name = "txtbox_stoploss";
            this.txtbox_stoploss.Size = new System.Drawing.Size(97, 23);
            this.txtbox_stoploss.TabIndex = 6;
            this.txtbox_stoploss.Click += new System.EventHandler(this.txtbox_stoploss_Click);
            this.txtbox_stoploss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_stoploss_KeyPress);
            // 
            // txtbox_risk
            // 
            this.txtbox_risk.Location = new System.Drawing.Point(62, 146);
            this.txtbox_risk.Name = "txtbox_risk";
            this.txtbox_risk.Size = new System.Drawing.Size(97, 23);
            this.txtbox_risk.TabIndex = 7;
            this.txtbox_risk.Click += new System.EventHandler(this.txtbox_risk_Click);
            this.txtbox_risk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_risk_KeyPress);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(62, 195);
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
            this.txtbox_buyingpower.Location = new System.Drawing.Point(172, 445);
            this.txtbox_buyingpower.Name = "txtbox_buyingpower";
            this.txtbox_buyingpower.Size = new System.Drawing.Size(154, 23);
            this.txtbox_buyingpower.TabIndex = 10;
            this.txtbox_buyingpower.Click += new System.EventHandler(this.txtbox_buyingpower_Click);
            // 
            // label_buyingpower
            // 
            this.label_buyingpower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buyingpower.AutoSize = true;
            this.label_buyingpower.ForeColor = System.Drawing.Color.Black;
            this.label_buyingpower.Location = new System.Drawing.Point(83, 448);
            this.label_buyingpower.Name = "label_buyingpower";
            this.label_buyingpower.Size = new System.Drawing.Size(83, 15);
            this.label_buyingpower.TabIndex = 11;
            this.label_buyingpower.Text = "Buying Power:";
            // 
            // radiobtn_2RAON
            // 
            this.radiobtn_2RAON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radiobtn_2RAON.AutoSize = true;
            this.radiobtn_2RAON.Location = new System.Drawing.Point(15, 30);
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
            this.radiobtn_1R2R.Location = new System.Drawing.Point(15, 68);
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
            this.grpbox_plan.Controls.Add(this.txtbox_customR);
            this.grpbox_plan.Controls.Add(this.radiobtn_custom);
            this.grpbox_plan.Controls.Add(this.radiobtn_1R2R);
            this.grpbox_plan.Controls.Add(this.radiobtn_2RAON);
            this.grpbox_plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbox_plan.Location = new System.Drawing.Point(196, 97);
            this.grpbox_plan.Name = "grpbox_plan";
            this.grpbox_plan.Size = new System.Drawing.Size(130, 140);
            this.grpbox_plan.TabIndex = 15;
            this.grpbox_plan.TabStop = false;
            this.grpbox_plan.Text = "Plan:";
            // 
            // txtbox_customR
            // 
            this.txtbox_customR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_customR.Location = new System.Drawing.Point(32, 103);
            this.txtbox_customR.Name = "txtbox_customR";
            this.txtbox_customR.Size = new System.Drawing.Size(44, 23);
            this.txtbox_customR.TabIndex = 15;
            // 
            // radiobtn_custom
            // 
            this.radiobtn_custom.AutoSize = true;
            this.radiobtn_custom.Location = new System.Drawing.Point(15, 104);
            this.radiobtn_custom.Name = "radiobtn_custom";
            this.radiobtn_custom.Size = new System.Drawing.Size(103, 19);
            this.radiobtn_custom.TabIndex = 14;
            this.radiobtn_custom.TabStop = true;
            this.radiobtn_custom.Text = "              R AON";
            this.radiobtn_custom.UseVisualStyleBackColor = true;
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
            // ordertable
            // 
            this.ordertable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordertable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordertable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ordertable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordertable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.table_qty,
            this.table_symbol,
            this.table_entry,
            this.table_stoploss});
            this.ordertable.Location = new System.Drawing.Point(20, 266);
            this.ordertable.Name = "ordertable";
            this.ordertable.RowHeadersVisible = false;
            this.ordertable.RowTemplate.Height = 25;
            this.ordertable.Size = new System.Drawing.Size(306, 172);
            this.ordertable.TabIndex = 16;
            // 
            // table_qty
            // 
            this.table_qty.HeaderText = "Quantity";
            this.table_qty.Name = "table_qty";
            this.table_qty.ReadOnly = true;
            // 
            // table_symbol
            // 
            this.table_symbol.HeaderText = "Symbol";
            this.table_symbol.Name = "table_symbol";
            this.table_symbol.ReadOnly = true;
            // 
            // table_entry
            // 
            this.table_entry.HeaderText = "Entry";
            this.table_entry.Name = "table_entry";
            this.table_entry.ReadOnly = true;
            // 
            // table_stoploss
            // 
            this.table_stoploss.HeaderText = "Stoploss";
            this.table_stoploss.Name = "table_stoploss";
            this.table_stoploss.ReadOnly = true;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_file,
            this.menuStrip_tools,
            this.menuStrip_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip_file
            // 
            this.menuStrip_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_file_exit});
            this.menuStrip_file.Name = "menuStrip_file";
            this.menuStrip_file.Size = new System.Drawing.Size(37, 20);
            this.menuStrip_file.Text = "&File";
            // 
            // menuStrip_file_exit
            // 
            this.menuStrip_file_exit.Name = "menuStrip_file_exit";
            this.menuStrip_file_exit.Size = new System.Drawing.Size(93, 22);
            this.menuStrip_file_exit.Text = "Exit";
            this.menuStrip_file_exit.Click += new System.EventHandler(this.menuStrip_file_exit_Click);
            // 
            // menuStrip_tools
            // 
            this.menuStrip_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_tools_orderhist,
            this.menuStrip_tools_debug});
            this.menuStrip_tools.Name = "menuStrip_tools";
            this.menuStrip_tools.Size = new System.Drawing.Size(46, 20);
            this.menuStrip_tools.Text = "&Tools";
            // 
            // menuStrip_tools_orderhist
            // 
            this.menuStrip_tools_orderhist.Checked = true;
            this.menuStrip_tools_orderhist.CheckOnClick = true;
            this.menuStrip_tools_orderhist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuStrip_tools_orderhist.Name = "menuStrip_tools_orderhist";
            this.menuStrip_tools_orderhist.Size = new System.Drawing.Size(145, 22);
            this.menuStrip_tools_orderhist.Text = "Order History";
            this.menuStrip_tools_orderhist.Click += new System.EventHandler(this.menuStrip_tools_orderhist_Click);
            // 
            // menuStrip_tools_debug
            // 
            this.menuStrip_tools_debug.CheckOnClick = true;
            this.menuStrip_tools_debug.Name = "menuStrip_tools_debug";
            this.menuStrip_tools_debug.Size = new System.Drawing.Size(145, 22);
            this.menuStrip_tools_debug.Text = "Debug Mode";
            this.menuStrip_tools_debug.Click += new System.EventHandler(this.menuStrip_tools_debug_Click);
            // 
            // menuStrip_help
            // 
            this.menuStrip_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_help_guide});
            this.menuStrip_help.Name = "menuStrip_help";
            this.menuStrip_help.Size = new System.Drawing.Size(44, 20);
            this.menuStrip_help.Text = "&Help";
            // 
            // menuStrip_help_guide
            // 
            this.menuStrip_help_guide.Name = "menuStrip_help_guide";
            this.menuStrip_help_guide.Size = new System.Drawing.Size(105, 22);
            this.menuStrip_help_guide.Text = "Guide";
            this.menuStrip_help_guide.Click += new System.EventHandler(this.menuStrip_help_guide_Click);
            // 
            // btn_long_short
            // 
            this.btn_long_short.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_long_short.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_long_short.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_long_short.Location = new System.Drawing.Point(215, 38);
            this.btn_long_short.Name = "btn_long_short";
            this.btn_long_short.Size = new System.Drawing.Size(75, 40);
            this.btn_long_short.TabIndex = 18;
            this.btn_long_short.Text = "LONG";
            this.btn_long_short.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_long_short.UseVisualStyleBackColor = true;
            this.btn_long_short.Click += new System.EventHandler(this.btn_long_short_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(344, 477);
            this.Controls.Add(this.btn_long_short);
            this.Controls.Add(this.ordertable);
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
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grpbox_plan.ResumeLayout(false);
            this.grpbox_plan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_ticker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_entry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_stoploss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_risk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_buyingpower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_plan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridView ordertable;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_entry;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_stoploss;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_edit;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_file;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_file_exit;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_tools;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_tools_orderhist;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_help;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_help_guide;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_tools_debug;
        private System.Windows.Forms.RadioButton radiobtn_custom;
        private System.Windows.Forms.TextBox txtbox_customR;
        private System.Windows.Forms.Button btn_long_short;
    }
}

