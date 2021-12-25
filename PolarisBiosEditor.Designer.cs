namespace PolarisBiosEditor
{
  partial class PolarisBiosEditor
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolarisBiosEditor));
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.txtChecksum = new System.Windows.Forms.TextBox();
            this.txtBIOSBootupMessage = new System.Windows.Forms.TextBox();
            this.boxROM = new System.Windows.Forms.GroupBox();
            this.tableROM = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxPOWERPLAY = new System.Windows.Forms.GroupBox();
            this.tablePOWERPLAY = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxPOWERTUNE = new System.Windows.Forms.GroupBox();
            this.tablePOWERTUNE = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxFAN = new System.Windows.Forms.GroupBox();
            this.tableFAN = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxGPU = new System.Windows.Forms.GroupBox();
            this.tableGPU = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxMEM = new System.Windows.Forms.GroupBox();
            this.tableMEMORY = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boxVRAM = new System.Windows.Forms.GroupBox();
            this.tableVRAM_TIMING = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listVRAM = new System.Windows.Forms.ComboBox();
            this.tableVRAM = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editSubItem1 = new System.Windows.Forms.TextBox();
            this.editSubItem2 = new System.Windows.Forms.TextBox();
            this.apply = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RbETH = new System.Windows.Forms.RadioButton();
            this.RbXMR = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbPower = new System.Windows.Forms.RadioButton();
            this.RbOC = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbWin = new System.Windows.Forms.RadioButton();
            this.RbLin = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.boxROM.SuspendLayout();
            this.boxPOWERPLAY.SuspendLayout();
            this.boxPOWERTUNE.SuspendLayout();
            this.boxFAN.SuspendLayout();
            this.boxGPU.SuspendLayout();
            this.boxMEM.SuspendLayout();
            this.boxVRAM.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(12, 12);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 0;
            this.open.Text = "OPEN BIOS";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.OpenFileDialog_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(93, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "SAVE AS";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.SaveFileDialog_Click);
            // 
            // txtChecksum
            // 
            this.txtChecksum.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtChecksum.Location = new System.Drawing.Point(174, 14);
            this.txtChecksum.Name = "txtChecksum";
            this.txtChecksum.Size = new System.Drawing.Size(100, 20);
            this.txtChecksum.TabIndex = 2;
            // 
            // txtBIOSBootupMessage
            // 
            this.txtBIOSBootupMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBIOSBootupMessage.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtBIOSBootupMessage.Location = new System.Drawing.Point(280, 14);
            this.txtBIOSBootupMessage.Name = "txtBIOSBootupMessage";
            this.txtBIOSBootupMessage.Size = new System.Drawing.Size(815, 20);
            this.txtBIOSBootupMessage.TabIndex = 5;
            // 
            // boxROM
            // 
            this.boxROM.Controls.Add(this.tableROM);
            this.boxROM.Location = new System.Drawing.Point(9, 41);
            this.boxROM.Name = "boxROM";
            this.boxROM.Size = new System.Drawing.Size(265, 140);
            this.boxROM.TabIndex = 3;
            this.boxROM.TabStop = false;
            this.boxROM.Text = "ROM";
            // 
            // tableROM
            // 
            this.tableROM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.tableROM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableROM.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.tableROM.Location = new System.Drawing.Point(3, 16);
            this.tableROM.Name = "tableROM";
            this.tableROM.Size = new System.Drawing.Size(259, 121);
            this.tableROM.TabIndex = 4;
            this.tableROM.UseCompatibleStateImageBehavior = false;
            this.tableROM.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            // 
            // boxPOWERPLAY
            // 
            this.boxPOWERPLAY.Controls.Add(this.tablePOWERPLAY);
            this.boxPOWERPLAY.Location = new System.Drawing.Point(9, 184);
            this.boxPOWERPLAY.Name = "boxPOWERPLAY";
            this.boxPOWERPLAY.Size = new System.Drawing.Size(265, 157);
            this.boxPOWERPLAY.TabIndex = 0;
            this.boxPOWERPLAY.TabStop = false;
            this.boxPOWERPLAY.Text = "POWERPLAY";
            // 
            // tablePOWERPLAY
            // 
            this.tablePOWERPLAY.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.tablePOWERPLAY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePOWERPLAY.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.tablePOWERPLAY.Location = new System.Drawing.Point(3, 16);
            this.tablePOWERPLAY.Name = "tablePOWERPLAY";
            this.tablePOWERPLAY.Size = new System.Drawing.Size(259, 138);
            this.tablePOWERPLAY.TabIndex = 5;
            this.tablePOWERPLAY.UseCompatibleStateImageBehavior = false;
            this.tablePOWERPLAY.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            // 
            // boxPOWERTUNE
            // 
            this.boxPOWERTUNE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.boxPOWERTUNE.Controls.Add(this.tablePOWERTUNE);
            this.boxPOWERTUNE.Location = new System.Drawing.Point(277, 374);
            this.boxPOWERTUNE.Name = "boxPOWERTUNE";
            this.boxPOWERTUNE.Size = new System.Drawing.Size(260, 252);
            this.boxPOWERTUNE.TabIndex = 0;
            this.boxPOWERTUNE.TabStop = false;
            this.boxPOWERTUNE.Text = "POWERTUNE";
            // 
            // tablePOWERTUNE
            // 
            this.tablePOWERTUNE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tablePOWERTUNE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.tablePOWERTUNE.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.tablePOWERTUNE.Location = new System.Drawing.Point(3, 16);
            this.tablePOWERTUNE.Name = "tablePOWERTUNE";
            this.tablePOWERTUNE.Size = new System.Drawing.Size(254, 233);
            this.tablePOWERTUNE.TabIndex = 6;
            this.tablePOWERTUNE.UseCompatibleStateImageBehavior = false;
            this.tablePOWERTUNE.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            // 
            // boxFAN
            // 
            this.boxFAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.boxFAN.Controls.Add(this.tableFAN);
            this.boxFAN.Location = new System.Drawing.Point(9, 344);
            this.boxFAN.Name = "boxFAN";
            this.boxFAN.Size = new System.Drawing.Size(265, 282);
            this.boxFAN.TabIndex = 0;
            this.boxFAN.TabStop = false;
            this.boxFAN.Text = "FAN";
            // 
            // tableFAN
            // 
            this.tableFAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableFAN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.tableFAN.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.tableFAN.Location = new System.Drawing.Point(3, 16);
            this.tableFAN.Name = "tableFAN";
            this.tableFAN.Size = new System.Drawing.Size(259, 263);
            this.tableFAN.TabIndex = 7;
            this.tableFAN.UseCompatibleStateImageBehavior = false;
            this.tableFAN.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Value";
            // 
            // boxGPU
            // 
            this.boxGPU.Controls.Add(this.tableGPU);
            this.boxGPU.Location = new System.Drawing.Point(277, 41);
            this.boxGPU.Name = "boxGPU";
            this.boxGPU.Size = new System.Drawing.Size(260, 203);
            this.boxGPU.TabIndex = 0;
            this.boxGPU.TabStop = false;
            this.boxGPU.Text = "GPU";
            // 
            // tableGPU
            // 
            this.tableGPU.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.tableGPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableGPU.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.tableGPU.Location = new System.Drawing.Point(3, 16);
            this.tableGPU.Name = "tableGPU";
            this.tableGPU.Size = new System.Drawing.Size(254, 184);
            this.tableGPU.TabIndex = 8;
            this.tableGPU.UseCompatibleStateImageBehavior = false;
            this.tableGPU.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "MHz";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "mV";
            // 
            // boxMEM
            // 
            this.boxMEM.Controls.Add(this.tableMEMORY);
            this.boxMEM.Location = new System.Drawing.Point(277, 247);
            this.boxMEM.Name = "boxMEM";
            this.boxMEM.Size = new System.Drawing.Size(260, 124);
            this.boxMEM.TabIndex = 0;
            this.boxMEM.TabStop = false;
            this.boxMEM.Text = "MEMORY";
            // 
            // tableMEMORY
            // 
            this.tableMEMORY.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.tableMEMORY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMEMORY.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.tableMEMORY.Location = new System.Drawing.Point(3, 16);
            this.tableMEMORY.Name = "tableMEMORY";
            this.tableMEMORY.Size = new System.Drawing.Size(254, 105);
            this.tableMEMORY.TabIndex = 9;
            this.tableMEMORY.UseCompatibleStateImageBehavior = false;
            this.tableMEMORY.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "MHz";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "mV";
            // 
            // boxVRAM
            // 
            this.boxVRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxVRAM.Controls.Add(this.tableVRAM_TIMING);
            this.boxVRAM.Controls.Add(this.listVRAM);
            this.boxVRAM.Controls.Add(this.tableVRAM);
            this.boxVRAM.Location = new System.Drawing.Point(540, 41);
            this.boxVRAM.Name = "boxVRAM";
            this.boxVRAM.Size = new System.Drawing.Size(552, 585);
            this.boxVRAM.TabIndex = 0;
            this.boxVRAM.TabStop = false;
            this.boxVRAM.Text = "VRAM";
            // 
            // tableVRAM_TIMING
            // 
            this.tableVRAM_TIMING.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableVRAM_TIMING.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16});
            this.tableVRAM_TIMING.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.tableVRAM_TIMING.Location = new System.Drawing.Point(3, 209);
            this.tableVRAM_TIMING.Name = "tableVRAM_TIMING";
            this.tableVRAM_TIMING.Size = new System.Drawing.Size(546, 373);
            this.tableVRAM_TIMING.TabIndex = 11;
            this.tableVRAM_TIMING.UseCompatibleStateImageBehavior = false;
            this.tableVRAM_TIMING.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "MHz";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Timing Strap";
            this.columnHeader16.Width = 110;
            // 
            // listVRAM
            // 
            this.listVRAM.Dock = System.Windows.Forms.DockStyle.Top;
            this.listVRAM.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.listVRAM.FormattingEnabled = true;
            this.listVRAM.Location = new System.Drawing.Point(3, 16);
            this.listVRAM.Name = "listVRAM";
            this.listVRAM.Size = new System.Drawing.Size(546, 22);
            this.listVRAM.TabIndex = 12;
            this.listVRAM.SelectedIndexChanged += new System.EventHandler(this.listVRAM_SelectedIndexChanged);
            this.listVRAM.SelectedValueChanged += new System.EventHandler(this.listVRAM_SelectionChanged);
            // 
            // tableVRAM
            // 
            this.tableVRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableVRAM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.tableVRAM.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.tableVRAM.Location = new System.Drawing.Point(3, 43);
            this.tableVRAM.Name = "tableVRAM";
            this.tableVRAM.Size = new System.Drawing.Size(546, 160);
            this.tableVRAM.TabIndex = 10;
            this.tableVRAM.UseCompatibleStateImageBehavior = false;
            this.tableVRAM.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Value";
            // 
            // editSubItem1
            // 
            this.editSubItem1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editSubItem1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.editSubItem1.Location = new System.Drawing.Point(100, 643);
            this.editSubItem1.Name = "editSubItem1";
            this.editSubItem1.Size = new System.Drawing.Size(206, 20);
            this.editSubItem1.TabIndex = 2;
            // 
            // editSubItem2
            // 
            this.editSubItem2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editSubItem2.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.editSubItem2.Location = new System.Drawing.Point(6, 698);
            this.editSubItem2.Name = "editSubItem2";
            this.editSubItem2.Size = new System.Drawing.Size(1083, 20);
            this.editSubItem2.TabIndex = 2;
            this.editSubItem2.Click += new System.EventHandler(this.editSubItem2_Click);
            this.editSubItem2.TextChanged += new System.EventHandler(this.editSubItem2_TextChanged);
            // 
            // apply
            // 
            this.apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.apply.Location = new System.Drawing.Point(10, 642);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(84, 23);
            this.apply.TabIndex = 0;
            this.apply.Text = "APPLY CHG";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(933, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "ONE CLICK TIMING PATCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.RbETH);
            this.groupBox3.Controls.Add(this.RbXMR);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(639, 632);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 63);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Algo";
            // 
            // RbETH
            // 
            this.RbETH.AutoSize = true;
            this.RbETH.Enabled = false;
            this.RbETH.Location = new System.Drawing.Point(6, 16);
            this.RbETH.Name = "RbETH";
            this.RbETH.Size = new System.Drawing.Size(47, 17);
            this.RbETH.TabIndex = 6;
            this.RbETH.Text = "ETH";
            this.RbETH.UseVisualStyleBackColor = true;
            // 
            // RbXMR
            // 
            this.RbXMR.AutoSize = true;
            this.RbXMR.Enabled = false;
            this.RbXMR.Location = new System.Drawing.Point(6, 35);
            this.RbXMR.Name = "RbXMR";
            this.RbXMR.Size = new System.Drawing.Size(150, 17);
            this.RbXMR.TabIndex = 7;
            this.RbXMR.Text = "CN (XMR, RYO, AEON,...)";
            this.RbXMR.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.RbPower);
            this.groupBox2.Controls.Add(this.RbOC);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(416, 632);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 63);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Power";
            // 
            // RbPower
            // 
            this.RbPower.AutoSize = true;
            this.RbPower.Location = new System.Drawing.Point(6, 16);
            this.RbPower.Name = "RbPower";
            this.RbPower.Size = new System.Drawing.Size(89, 17);
            this.RbPower.TabIndex = 6;
            this.RbPower.Text = "Power saving";
            this.RbPower.UseVisualStyleBackColor = true;
            // 
            // RbOC
            // 
            this.RbOC.AutoSize = true;
            this.RbOC.Enabled = false;
            this.RbOC.Location = new System.Drawing.Point(6, 35);
            this.RbOC.Name = "RbOC";
            this.RbOC.Size = new System.Drawing.Size(150, 17);
            this.RbOC.TabIndex = 7;
            this.RbOC.Text = "OC with slight undervolting";
            this.RbOC.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RbWin);
            this.groupBox1.Controls.Add(this.RbLin);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(312, 632);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 63);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OS";
            // 
            // RbWin
            // 
            this.RbWin.AutoSize = true;
            this.RbWin.Enabled = false;
            this.RbWin.Location = new System.Drawing.Point(6, 16);
            this.RbWin.Name = "RbWin";
            this.RbWin.Size = new System.Drawing.Size(69, 17);
            this.RbWin.TabIndex = 6;
            this.RbWin.Text = "Windows";
            this.RbWin.UseVisualStyleBackColor = true;
            // 
            // RbLin
            // 
            this.RbLin.AutoSize = true;
            this.RbLin.Enabled = false;
            this.RbLin.Location = new System.Drawing.Point(6, 35);
            this.RbLin.Name = "RbLin";
            this.RbLin.Size = new System.Drawing.Size(50, 17);
            this.RbLin.TabIndex = 7;
            this.RbLin.Text = "Linux";
            this.RbLin.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(12, 671);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(163, 24);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Buy Pro Version";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PolarisBiosEditor
            // 
            this.ClientSize = new System.Drawing.Size(1104, 733);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxFAN);
            this.Controls.Add(this.boxVRAM);
            this.Controls.Add(this.boxMEM);
            this.Controls.Add(this.boxGPU);
            this.Controls.Add(this.boxPOWERTUNE);
            this.Controls.Add(this.boxPOWERPLAY);
            this.Controls.Add(this.boxROM);
            this.Controls.Add(this.txtChecksum);
            this.Controls.Add(this.txtBIOSBootupMessage);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Controls.Add(this.editSubItem1);
            this.Controls.Add(this.editSubItem2);
            this.Controls.Add(this.apply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PolarisBiosEditor";
            this.Text = "PBE";
            this.Load += new System.EventHandler(this.PolarisBiosEditor_Load);
            this.boxROM.ResumeLayout(false);
            this.boxPOWERPLAY.ResumeLayout(false);
            this.boxPOWERTUNE.ResumeLayout(false);
            this.boxFAN.ResumeLayout(false);
            this.boxGPU.ResumeLayout(false);
            this.boxMEM.ResumeLayout(false);
            this.boxVRAM.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button open;
    private System.Windows.Forms.Button save;
    private System.Windows.Forms.TextBox txtChecksum;
    private System.Windows.Forms.TextBox txtBIOSBootupMessage;
    private System.Windows.Forms.GroupBox boxROM;
    private System.Windows.Forms.GroupBox boxPOWERPLAY;
    private System.Windows.Forms.GroupBox boxPOWERTUNE;
    private System.Windows.Forms.GroupBox boxFAN;
    private System.Windows.Forms.GroupBox boxGPU;
    private System.Windows.Forms.GroupBox boxMEM;
    private System.Windows.Forms.GroupBox boxVRAM;
    private System.Windows.Forms.ListView tableROM;
    private System.Windows.Forms.ListView tablePOWERPLAY;
    private System.Windows.Forms.ListView tablePOWERTUNE;
    private System.Windows.Forms.ListView tableFAN;
    private System.Windows.Forms.ListView tableGPU;
    private System.Windows.Forms.ListView tableMEMORY;
    private System.Windows.Forms.ListView tableVRAM;
    private System.Windows.Forms.ListView tableVRAM_TIMING;
    private System.Windows.Forms.ComboBox listVRAM;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.ColumnHeader columnHeader9;
    private System.Windows.Forms.ColumnHeader columnHeader10;
    private System.Windows.Forms.ColumnHeader columnHeader11;
    private System.Windows.Forms.ColumnHeader columnHeader12;
    private System.Windows.Forms.ColumnHeader columnHeader13;
    private System.Windows.Forms.ColumnHeader columnHeader14;
    private System.Windows.Forms.ColumnHeader columnHeader15;
    private System.Windows.Forms.ColumnHeader columnHeader16;
    private System.Windows.Forms.ColumnHeader columnHeader7;
    private System.Windows.Forms.ColumnHeader columnHeader8;
    private System.Windows.Forms.TextBox editSubItem1;
    private System.Windows.Forms.TextBox editSubItem2;
    private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RbETH;
        private System.Windows.Forms.RadioButton RbXMR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbPower;
        private System.Windows.Forms.RadioButton RbOC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbWin;
        private System.Windows.Forms.RadioButton RbLin;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
