namespace Act14_Paginacion
{
  partial class MainWindow
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
      if(disposing && (components != null)) {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.bttnStart = new System.Windows.Forms.Button();
      this.txtBoxQuantum = new System.Windows.Forms.NumericUpDown();
      this.txtBoxTotalProc = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.Ready = new System.Windows.Forms.GroupBox();
      this.tblReady = new System.Windows.Forms.DataGridView();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TME = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Blocked = new System.Windows.Forms.GroupBox();
      this.tblBlocked = new System.Windows.Forms.DataGridView();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.tblTerminated = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.lblQuantum = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.lblNextPro = new System.Windows.Forms.Label();
      this.lblProRes = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblGloTime = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.tblMemory = new System.Windows.Forms.DataGridView();
      this.one = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.two = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.three = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.four = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.five = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lblTieRes = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.lblTieTra = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.lblOpe_PE = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.lblTME_PE = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.lblNumPro = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.txtBoxQuantum)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtBoxTotalProc)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.Ready.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tblReady)).BeginInit();
      this.Blocked.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tblBlocked)).BeginInit();
      this.groupBox5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tblTerminated)).BeginInit();
      this.groupBox6.SuspendLayout();
      this.groupBox7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tblMemory)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // bttnStart
      // 
      this.bttnStart.Location = new System.Drawing.Point(6, 71);
      this.bttnStart.Name = "bttnStart";
      this.bttnStart.Size = new System.Drawing.Size(149, 28);
      this.bttnStart.TabIndex = 2;
      this.bttnStart.Text = "Start";
      this.bttnStart.UseVisualStyleBackColor = true;
      this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
      // 
      // txtBoxQuantum
      // 
      this.txtBoxQuantum.Location = new System.Drawing.Point(95, 45);
      this.txtBoxQuantum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.txtBoxQuantum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtBoxQuantum.Name = "txtBoxQuantum";
      this.txtBoxQuantum.Size = new System.Drawing.Size(60, 20);
      this.txtBoxQuantum.TabIndex = 1;
      this.txtBoxQuantum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // txtBoxTotalProc
      // 
      this.txtBoxTotalProc.Location = new System.Drawing.Point(95, 19);
      this.txtBoxTotalProc.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.txtBoxTotalProc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtBoxTotalProc.Name = "txtBoxTotalProc";
      this.txtBoxTotalProc.Size = new System.Drawing.Size(60, 20);
      this.txtBoxTotalProc.TabIndex = 0;
      this.txtBoxTotalProc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(6, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "No. Procesos:";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.bttnStart);
      this.groupBox1.Controls.Add(this.txtBoxQuantum);
      this.groupBox1.Controls.Add(this.txtBoxTotalProc);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(161, 105);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(6, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(61, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Quantum:";
      // 
      // Ready
      // 
      this.Ready.Controls.Add(this.tblReady);
      this.Ready.Location = new System.Drawing.Point(12, 123);
      this.Ready.Name = "Ready";
      this.Ready.Size = new System.Drawing.Size(161, 336);
      this.Ready.TabIndex = 11;
      this.Ready.TabStop = false;
      this.Ready.Text = "Listos";
      // 
      // tblReady
      // 
      this.tblReady.AllowUserToAddRows = false;
      this.tblReady.AllowUserToDeleteRows = false;
      this.tblReady.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tblReady.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TME,
            this.TT});
      this.tblReady.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tblReady.Location = new System.Drawing.Point(3, 16);
      this.tblReady.Name = "tblReady";
      this.tblReady.ReadOnly = true;
      this.tblReady.RowHeadersVisible = false;
      this.tblReady.Size = new System.Drawing.Size(155, 317);
      this.tblReady.TabIndex = 10;
      // 
      // Id
      // 
      this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Width = 41;
      // 
      // TME
      // 
      this.TME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.TME.HeaderText = "TME";
      this.TME.Name = "TME";
      this.TME.ReadOnly = true;
      this.TME.Width = 55;
      // 
      // TT
      // 
      this.TT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.TT.HeaderText = "TT";
      this.TT.Name = "TT";
      this.TT.ReadOnly = true;
      this.TT.Width = 46;
      // 
      // Blocked
      // 
      this.Blocked.Controls.Add(this.tblBlocked);
      this.Blocked.Location = new System.Drawing.Point(179, 309);
      this.Blocked.Name = "Blocked";
      this.Blocked.Size = new System.Drawing.Size(161, 150);
      this.Blocked.TabIndex = 13;
      this.Blocked.TabStop = false;
      this.Blocked.Text = "Bloqueados";
      // 
      // tblBlocked
      // 
      this.tblBlocked.AllowUserToAddRows = false;
      this.tblBlocked.AllowUserToDeleteRows = false;
      this.tblBlocked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tblBlocked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
      this.tblBlocked.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tblBlocked.Location = new System.Drawing.Point(3, 16);
      this.tblBlocked.Name = "tblBlocked";
      this.tblBlocked.ReadOnly = true;
      this.tblBlocked.RowHeadersVisible = false;
      this.tblBlocked.Size = new System.Drawing.Size(155, 131);
      this.tblBlocked.TabIndex = 0;
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.tblTerminated);
      this.groupBox5.Location = new System.Drawing.Point(349, 126);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(186, 333);
      this.groupBox5.TabIndex = 12;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Terminados";
      // 
      // tblTerminated
      // 
      this.tblTerminated.AllowUserToAddRows = false;
      this.tblTerminated.AllowUserToDeleteRows = false;
      this.tblTerminated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tblTerminated.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
      this.tblTerminated.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tblTerminated.Location = new System.Drawing.Point(3, 16);
      this.tblTerminated.Name = "tblTerminated";
      this.tblTerminated.ReadOnly = true;
      this.tblTerminated.RowHeadersVisible = false;
      this.tblTerminated.Size = new System.Drawing.Size(180, 314);
      this.tblTerminated.TabIndex = 0;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.dataGridViewTextBoxColumn7.HeaderText = "Id";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.ReadOnly = true;
      this.dataGridViewTextBoxColumn7.Width = 41;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.dataGridViewTextBoxColumn8.HeaderText = "Ope";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.ReadOnly = true;
      this.dataGridViewTextBoxColumn8.Width = 52;
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.dataGridViewTextBoxColumn9.HeaderText = "Res";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn9.ReadOnly = true;
      this.dataGridViewTextBoxColumn9.Width = 51;
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.lblQuantum);
      this.groupBox6.Controls.Add(this.label6);
      this.groupBox6.Controls.Add(this.lblNextPro);
      this.groupBox6.Controls.Add(this.lblProRes);
      this.groupBox6.Controls.Add(this.label5);
      this.groupBox6.Controls.Add(this.lblGloTime);
      this.groupBox6.Controls.Add(this.label3);
      this.groupBox6.Location = new System.Drawing.Point(182, 13);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(517, 104);
      this.groupBox6.TabIndex = 14;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "groupBox6";
      // 
      // lblQuantum
      // 
      this.lblQuantum.AutoSize = true;
      this.lblQuantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblQuantum.Location = new System.Drawing.Point(471, 46);
      this.lblQuantum.Name = "lblQuantum";
      this.lblQuantum.Size = new System.Drawing.Size(24, 20);
      this.lblQuantum.TabIndex = 6;
      this.lblQuantum.Text = "...";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(378, 46);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(87, 20);
      this.label6.TabIndex = 5;
      this.label6.Text = "Quantum:";
      // 
      // lblNextPro
      // 
      this.lblNextPro.AutoSize = true;
      this.lblNextPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNextPro.Location = new System.Drawing.Point(298, 46);
      this.lblNextPro.Name = "lblNextPro";
      this.lblNextPro.Size = new System.Drawing.Size(24, 20);
      this.lblNextPro.TabIndex = 4;
      this.lblNextPro.Text = "...";
      // 
      // lblProRes
      // 
      this.lblProRes.AutoSize = true;
      this.lblProRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblProRes.Location = new System.Drawing.Point(268, 46);
      this.lblProRes.Name = "lblProRes";
      this.lblProRes.Size = new System.Drawing.Size(24, 20);
      this.lblProRes.TabIndex = 3;
      this.lblProRes.Text = "...";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(189, 46);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(73, 20);
      this.label5.TabIndex = 2;
      this.label5.Text = "Nuevos:";
      // 
      // lblGloTime
      // 
      this.lblGloTime.AutoSize = true;
      this.lblGloTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblGloTime.Location = new System.Drawing.Point(98, 46);
      this.lblGloTime.Name = "lblGloTime";
      this.lblGloTime.Size = new System.Drawing.Size(24, 20);
      this.lblGloTime.TabIndex = 1;
      this.lblGloTime.Text = "...";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(37, 46);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 20);
      this.label3.TabIndex = 0;
      this.label3.Text = "Reloj:";
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.tblMemory);
      this.groupBox7.Location = new System.Drawing.Point(541, 126);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(158, 333);
      this.groupBox7.TabIndex = 13;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "groupBox7";
      // 
      // tblMemory
      // 
      this.tblMemory.AllowUserToAddRows = false;
      this.tblMemory.AllowUserToDeleteRows = false;
      this.tblMemory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.tblMemory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.tblMemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tblMemory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.one,
            this.two,
            this.three,
            this.four,
            this.five});
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.tblMemory.DefaultCellStyle = dataGridViewCellStyle1;
      this.tblMemory.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tblMemory.Location = new System.Drawing.Point(3, 16);
      this.tblMemory.Name = "tblMemory";
      this.tblMemory.ReadOnly = true;
      this.tblMemory.RowHeadersVisible = false;
      this.tblMemory.Size = new System.Drawing.Size(152, 314);
      this.tblMemory.TabIndex = 0;
      // 
      // one
      // 
      this.one.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.one.HeaderText = "";
      this.one.Name = "one";
      this.one.ReadOnly = true;
      this.one.Width = 19;
      // 
      // two
      // 
      this.two.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.two.HeaderText = "";
      this.two.Name = "two";
      this.two.ReadOnly = true;
      this.two.Width = 19;
      // 
      // three
      // 
      this.three.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.three.HeaderText = "";
      this.three.Name = "three";
      this.three.ReadOnly = true;
      this.three.Width = 19;
      // 
      // four
      // 
      this.four.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.four.HeaderText = "";
      this.four.Name = "four";
      this.four.ReadOnly = true;
      this.four.Width = 19;
      // 
      // five
      // 
      this.five.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.five.HeaderText = "";
      this.five.Name = "five";
      this.five.ReadOnly = true;
      this.five.Width = 19;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lblTieRes);
      this.groupBox2.Controls.Add(this.label18);
      this.groupBox2.Controls.Add(this.lblTieTra);
      this.groupBox2.Controls.Add(this.label16);
      this.groupBox2.Controls.Add(this.lblOpe_PE);
      this.groupBox2.Controls.Add(this.label14);
      this.groupBox2.Controls.Add(this.lblTME_PE);
      this.groupBox2.Controls.Add(this.label12);
      this.groupBox2.Controls.Add(this.lblNumPro);
      this.groupBox2.Controls.Add(this.label10);
      this.groupBox2.Location = new System.Drawing.Point(185, 129);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(155, 174);
      this.groupBox2.TabIndex = 15;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "groupBox2";
      // 
      // lblTieRes
      // 
      this.lblTieRes.AutoSize = true;
      this.lblTieRes.Location = new System.Drawing.Point(105, 143);
      this.lblTieRes.Name = "lblTieRes";
      this.lblTieRes.Size = new System.Drawing.Size(16, 13);
      this.lblTieRes.TabIndex = 16;
      this.lblTieRes.Text = "...";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(21, 143);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(45, 13);
      this.label18.TabIndex = 15;
      this.label18.Text = "T. Res.:";
      this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblTieTra
      // 
      this.lblTieTra.AutoSize = true;
      this.lblTieTra.Location = new System.Drawing.Point(105, 112);
      this.lblTieTra.Name = "lblTieTra";
      this.lblTieTra.Size = new System.Drawing.Size(16, 13);
      this.lblTieTra.TabIndex = 14;
      this.lblTieTra.Text = "...";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(21, 112);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(42, 13);
      this.label16.TabIndex = 13;
      this.label16.Text = "T. Tra.:";
      this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblOpe_PE
      // 
      this.lblOpe_PE.AutoSize = true;
      this.lblOpe_PE.Location = new System.Drawing.Point(105, 84);
      this.lblOpe_PE.Name = "lblOpe_PE";
      this.lblOpe_PE.Size = new System.Drawing.Size(16, 13);
      this.lblOpe_PE.TabIndex = 12;
      this.lblOpe_PE.Text = "...";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(21, 84);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(59, 13);
      this.label14.TabIndex = 11;
      this.label14.Text = "Operación:";
      this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblTME_PE
      // 
      this.lblTME_PE.AutoSize = true;
      this.lblTME_PE.Location = new System.Drawing.Point(105, 57);
      this.lblTME_PE.Name = "lblTME_PE";
      this.lblTME_PE.Size = new System.Drawing.Size(16, 13);
      this.lblTME_PE.TabIndex = 10;
      this.lblTME_PE.Text = "...";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(21, 57);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(33, 13);
      this.label12.TabIndex = 9;
      this.label12.Text = "TME:";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblNumPro
      // 
      this.lblNumPro.AutoSize = true;
      this.lblNumPro.Location = new System.Drawing.Point(105, 27);
      this.lblNumPro.Name = "lblNumPro";
      this.lblNumPro.Size = new System.Drawing.Size(16, 13);
      this.lblNumPro.TabIndex = 8;
      this.lblNumPro.Text = "...";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(21, 27);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(19, 13);
      this.label10.TabIndex = 7;
      this.label10.Text = "Id:";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.dataGridViewTextBoxColumn4.HeaderText = "Id";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 41;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.dataGridViewTextBoxColumn5.HeaderText = "TME";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.Width = 55;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.dataGridViewTextBoxColumn6.HeaderText = "TRB";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Width = 54;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(711, 471);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox7);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.Blocked);
      this.Controls.Add(this.Ready);
      this.Controls.Add(this.groupBox1);
      this.KeyPreview = true;
      this.Name = "MainWindow";
      this.Text = "Form1";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPresionada);
      ((System.ComponentModel.ISupportInitialize)(this.txtBoxQuantum)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtBoxTotalProc)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.Ready.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tblReady)).EndInit();
      this.Blocked.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tblBlocked)).EndInit();
      this.groupBox5.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tblTerminated)).EndInit();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox7.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tblMemory)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.NumericUpDown txtBoxQuantum;
        private System.Windows.Forms.NumericUpDown txtBoxTotalProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Ready;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.GroupBox Blocked;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView tblMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label lblGloTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    public System.Windows.Forms.DataGridView tblReady;
    public System.Windows.Forms.DataGridView tblTerminated;
    private System.Windows.Forms.DataGridViewTextBoxColumn one;
    private System.Windows.Forms.DataGridViewTextBoxColumn two;
    private System.Windows.Forms.DataGridViewTextBoxColumn three;
    private System.Windows.Forms.DataGridViewTextBoxColumn four;
    private System.Windows.Forms.DataGridViewTextBoxColumn five;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label lblTieRes;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label lblTieTra;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label lblOpe_PE;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label lblTME_PE;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label lblNumPro;
    private System.Windows.Forms.Label label10;
    public System.Windows.Forms.DataGridView tblBlocked;
    private System.Windows.Forms.Label lblProRes;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblNextPro;
    private System.Windows.Forms.Label lblQuantum;
    private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

