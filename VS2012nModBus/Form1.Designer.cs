namespace VS2012nModBus
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ymax = new System.Windows.Forms.NumericUpDown();
            this.Ymin = new System.Windows.Forms.NumericUpDown();
            this.autoY = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numCuvinte = new System.Windows.Forms.NumericUpDown();
            this.numAdresa = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.latimeTensiune = new System.Windows.Forms.NumericUpDown();
            this.setInterval = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textSetIP = new System.Windows.Forms.TextBox();
            this.textSetPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConTCP = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxMBTCPsetIP = new System.Windows.Forms.TextBox();
            this.txtBoxMBTCPsetPort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConnectModTCP = new System.Windows.Forms.Button();
            this.btnReadModTCP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ymax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ymin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCuvinte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latimeTensiune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setInterval)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(257, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Tensiune";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Frecventa";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(765, 602);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ymax
            // 
            this.Ymax.Enabled = false;
            this.Ymax.Location = new System.Drawing.Point(179, 35);
            this.Ymax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Ymax.Name = "Ymax";
            this.Ymax.Size = new System.Drawing.Size(58, 23);
            this.Ymax.TabIndex = 8;
            this.Ymax.Value = new decimal(new int[] {
            230,
            0,
            0,
            0});
            this.Ymax.ValueChanged += new System.EventHandler(this.Ymax_ValueChanged);
            // 
            // Ymin
            // 
            this.Ymin.Enabled = false;
            this.Ymin.Location = new System.Drawing.Point(179, 6);
            this.Ymin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Ymin.Name = "Ymin";
            this.Ymin.Size = new System.Drawing.Size(58, 23);
            this.Ymin.TabIndex = 9;
            this.Ymin.Value = new decimal(new int[] {
            220,
            0,
            0,
            0});
            this.Ymin.ValueChanged += new System.EventHandler(this.Ymin_ValueChanged);
            // 
            // autoY
            // 
            this.autoY.AutoSize = true;
            this.autoY.Checked = true;
            this.autoY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoY.Location = new System.Drawing.Point(150, 64);
            this.autoY.Name = "autoY";
            this.autoY.Size = new System.Drawing.Size(65, 21);
            this.autoY.TabIndex = 10;
            this.autoY.Text = "AutoY";
            this.autoY.UseVisualStyleBackColor = true;
            this.autoY.CheckedChanged += new System.EventHandler(this.autoY_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 602);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 396);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(251, 203);
            this.textBox1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 157);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurari";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 19);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(245, 135);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(237, 106);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Contor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.19913F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.80087F));
            this.tableLayoutPanel2.Controls.Add(this.numCuvinte, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.numAdresa, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.numID, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.47059F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.52941F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(231, 100);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // numCuvinte
            // 
            this.numCuvinte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numCuvinte.Location = new System.Drawing.Point(81, 72);
            this.numCuvinte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.numCuvinte.Name = "numCuvinte";
            this.numCuvinte.Size = new System.Drawing.Size(147, 23);
            this.numCuvinte.TabIndex = 5;
            this.numCuvinte.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numAdresa
            // 
            this.numAdresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numAdresa.Location = new System.Drawing.Point(81, 41);
            this.numAdresa.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.numAdresa.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numAdresa.Name = "numAdresa";
            this.numAdresa.Size = new System.Drawing.Size(147, 23);
            this.numAdresa.TabIndex = 4;
            this.numAdresa.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(50, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Location = new System.Drawing.Point(16, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cuvinte:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Location = new System.Drawing.Point(18, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Adresa:";
            // 
            // numID
            // 
            this.numID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numID.Location = new System.Drawing.Point(81, 6);
            this.numID.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.numID.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(147, 23);
            this.numID.TabIndex = 3;
            this.numID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.latimeTensiune);
            this.tabPage4.Controls.Add(this.setInterval);
            this.tabPage4.Controls.Add(this.autoY);
            this.tabPage4.Controls.Add(this.Ymax);
            this.tabPage4.Controls.Add(this.Ymin);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(237, 106);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Grafic";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ymax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ymin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Interval:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Latime:";
            // 
            // latimeTensiune
            // 
            this.latimeTensiune.Location = new System.Drawing.Point(63, 6);
            this.latimeTensiune.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.latimeTensiune.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.latimeTensiune.Name = "latimeTensiune";
            this.latimeTensiune.Size = new System.Drawing.Size(45, 23);
            this.latimeTensiune.TabIndex = 12;
            this.latimeTensiune.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.latimeTensiune.ValueChanged += new System.EventHandler(this.latimeTensiune_ValueChanged);
            // 
            // setInterval
            // 
            this.setInterval.Location = new System.Drawing.Point(63, 35);
            this.setInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.setInterval.Name = "setInterval";
            this.setInterval.Size = new System.Drawing.Size(45, 23);
            this.setInterval.TabIndex = 13;
            this.setInterval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.setInterval.ValueChanged += new System.EventHandler(this.setInterval_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(3, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(251, 220);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 16;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(243, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 38);
            this.button3.TabIndex = 15;
            this.button3.Text = "Disconect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 65);
            this.button2.TabIndex = 14;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 32);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Select Port";
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(243, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RTU over TCP/IP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.34147F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.82927F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.82927F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textSetIP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textSetPort, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConTCP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.testBtn, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 185);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // textSetIP
            // 
            this.textSetIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSetIP.Location = new System.Drawing.Point(65, 3);
            this.textSetIP.Name = "textSetIP";
            this.textSetIP.Size = new System.Drawing.Size(104, 23);
            this.textSetIP.TabIndex = 2;
            this.textSetIP.Text = "46.97.201.40";
            // 
            // textSetPort
            // 
            this.textSetPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSetPort.Location = new System.Drawing.Point(65, 35);
            this.textSetPort.Name = "textSetPort";
            this.textSetPort.Size = new System.Drawing.Size(104, 23);
            this.textSetPort.TabIndex = 3;
            this.textSetPort.Text = "8080";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP:";
            // 
            // btnConTCP
            // 
            this.btnConTCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConTCP.Location = new System.Drawing.Point(65, 69);
            this.btnConTCP.Name = "btnConTCP";
            this.btnConTCP.Size = new System.Drawing.Size(104, 31);
            this.btnConTCP.TabIndex = 4;
            this.btnConTCP.Text = "Connect";
            this.btnConTCP.UseVisualStyleBackColor = true;
            this.btnConTCP.Click += new System.EventHandler(this.btnConTCP_Click);
            // 
            // testBtn
            // 
            this.testBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testBtn.Location = new System.Drawing.Point(65, 106);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(104, 76);
            this.testBtn.TabIndex = 5;
            this.testBtn.Text = "Test Read";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel3);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(243, 191);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "TCP/IP";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.34147F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.82927F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.82927F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.txtBoxMBTCPsetIP, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtBoxMBTCPsetPort, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnConnectModTCP, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnReadModTCP, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(243, 191);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // txtBoxMBTCPsetIP
            // 
            this.txtBoxMBTCPsetIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxMBTCPsetIP.Location = new System.Drawing.Point(67, 3);
            this.txtBoxMBTCPsetIP.Name = "txtBoxMBTCPsetIP";
            this.txtBoxMBTCPsetIP.Size = new System.Drawing.Size(107, 23);
            this.txtBoxMBTCPsetIP.TabIndex = 2;
            this.txtBoxMBTCPsetIP.Text = "192.168.15.137";
            // 
            // txtBoxMBTCPsetPort
            // 
            this.txtBoxMBTCPsetPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxMBTCPsetPort.Location = new System.Drawing.Point(67, 38);
            this.txtBoxMBTCPsetPort.Name = "txtBoxMBTCPsetPort";
            this.txtBoxMBTCPsetPort.Size = new System.Drawing.Size(107, 23);
            this.txtBoxMBTCPsetPort.TabIndex = 3;
            this.txtBoxMBTCPsetPort.Text = "502";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 37);
            this.label10.TabIndex = 1;
            this.label10.Text = "Port:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 35);
            this.label11.TabIndex = 1;
            this.label11.Text = "IP:";
            // 
            // btnConnectModTCP
            // 
            this.btnConnectModTCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnectModTCP.Location = new System.Drawing.Point(67, 75);
            this.btnConnectModTCP.Name = "btnConnectModTCP";
            this.btnConnectModTCP.Size = new System.Drawing.Size(107, 31);
            this.btnConnectModTCP.TabIndex = 4;
            this.btnConnectModTCP.Text = "Connect";
            this.btnConnectModTCP.UseVisualStyleBackColor = true;
            this.btnConnectModTCP.Click += new System.EventHandler(this.btnConnectModTCP_Click);
            // 
            // btnReadModTCP
            // 
            this.btnReadModTCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReadModTCP.Location = new System.Drawing.Point(67, 112);
            this.btnReadModTCP.Name = "btnReadModTCP";
            this.btnReadModTCP.Size = new System.Drawing.Size(107, 76);
            this.btnReadModTCP.TabIndex = 5;
            this.btnReadModTCP.Text = "Test Read";
            this.btnReadModTCP.UseVisualStyleBackColor = true;
            this.btnReadModTCP.Click += new System.EventHandler(this.btnReadModTCP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nModBus Algodue";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ymax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ymin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCuvinte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latimeTensiune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setInterval)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown Ymax;
        private System.Windows.Forms.NumericUpDown Ymin;
        private System.Windows.Forms.CheckBox autoY;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown setInterval;
        private System.Windows.Forms.NumericUpDown latimeTensiune;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textSetPort;
        private System.Windows.Forms.TextBox textSetIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConTCP;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown numCuvinte;
        private System.Windows.Forms.NumericUpDown numAdresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtBoxMBTCPsetIP;
        private System.Windows.Forms.TextBox txtBoxMBTCPsetPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConnectModTCP;
        private System.Windows.Forms.Button btnReadModTCP;
    }
}

