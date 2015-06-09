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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ymax = new System.Windows.Forms.NumericUpDown();
            this.Ymin = new System.Windows.Forms.NumericUpDown();
            this.autoY = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.setInterval = new System.Windows.Forms.NumericUpDown();
            this.latimeTensiune = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ymax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ymin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latimeTensiune)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(242, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Blue;
            series7.Legend = "Legend1";
            series7.Name = "Tensiune";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.Name = "Frecventa";
            series8.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series8.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(780, 602);
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
            this.Ymax.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Ymax.Enabled = false;
            this.Ymax.Location = new System.Drawing.Point(3, 553);
            this.Ymax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Ymax.Name = "Ymax";
            this.Ymax.Size = new System.Drawing.Size(236, 23);
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
            this.Ymin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Ymin.Enabled = false;
            this.Ymin.Location = new System.Drawing.Point(3, 576);
            this.Ymin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Ymin.Name = "Ymin";
            this.Ymin.Size = new System.Drawing.Size(236, 23);
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
            this.autoY.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.autoY.Location = new System.Drawing.Point(3, 532);
            this.autoY.Name = "autoY";
            this.autoY.Size = new System.Drawing.Size(236, 21);
            this.autoY.TabIndex = 10;
            this.autoY.Text = "AutoY";
            this.autoY.UseVisualStyleBackColor = true;
            this.autoY.CheckedChanged += new System.EventHandler(this.autoY_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.autoY);
            this.groupBox1.Controls.Add(this.setInterval);
            this.groupBox1.Controls.Add(this.Ymax);
            this.groupBox1.Controls.Add(this.Ymin);
            this.groupBox1.Controls.Add(this.latimeTensiune);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 602);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 246);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(236, 286);
            this.textBox1.TabIndex = 14;
            // 
            // setInterval
            // 
            this.setInterval.Dock = System.Windows.Forms.DockStyle.Top;
            this.setInterval.Location = new System.Drawing.Point(3, 223);
            this.setInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.setInterval.Name = "setInterval";
            this.setInterval.Size = new System.Drawing.Size(236, 23);
            this.setInterval.TabIndex = 13;
            this.setInterval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.setInterval.ValueChanged += new System.EventHandler(this.setInterval_ValueChanged);
            // 
            // latimeTensiune
            // 
            this.latimeTensiune.Dock = System.Windows.Forms.DockStyle.Top;
            this.latimeTensiune.Location = new System.Drawing.Point(3, 200);
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
            this.latimeTensiune.Size = new System.Drawing.Size(236, 23);
            this.latimeTensiune.TabIndex = 12;
            this.latimeTensiune.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.latimeTensiune.ValueChanged += new System.EventHandler(this.latimeTensiune_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 32);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Select Port";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 38);
            this.button3.TabIndex = 10;
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
            this.button2.Location = new System.Drawing.Point(3, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 65);
            this.button2.TabIndex = 9;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nModBus Algodue";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ymax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ymin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latimeTensiune)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown Ymax;
        private System.Windows.Forms.NumericUpDown Ymin;
        private System.Windows.Forms.CheckBox autoY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown setInterval;
        private System.Windows.Forms.NumericUpDown latimeTensiune;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

