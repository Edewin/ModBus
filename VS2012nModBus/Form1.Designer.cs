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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.latimeTensiune = new System.Windows.Forms.NumericUpDown();
            this.setInterval = new System.Windows.Forms.NumericUpDown();
            this.Ymax = new System.Windows.Forms.NumericUpDown();
            this.Ymin = new System.Windows.Forms.NumericUpDown();
            this.autoY = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latimeTensiune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ymax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ymin)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(228, 234);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(13, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Disconect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(247, 35);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Tensiune";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(533, 333);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // latimeTensiune
            // 
            this.latimeTensiune.Location = new System.Drawing.Point(120, 66);
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
            this.latimeTensiune.Size = new System.Drawing.Size(121, 20);
            this.latimeTensiune.TabIndex = 6;
            this.latimeTensiune.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.latimeTensiune.ValueChanged += new System.EventHandler(this.latimeTensiune_ValueChanged);
            // 
            // setInterval
            // 
            this.setInterval.Location = new System.Drawing.Point(120, 94);
            this.setInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.setInterval.Name = "setInterval";
            this.setInterval.Size = new System.Drawing.Size(120, 20);
            this.setInterval.TabIndex = 7;
            this.setInterval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.setInterval.ValueChanged += new System.EventHandler(this.setInterval_ValueChanged);
            // 
            // Ymax
            // 
            this.Ymax.Enabled = false;
            this.Ymax.Location = new System.Drawing.Point(373, 12);
            this.Ymax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Ymax.Name = "Ymax";
            this.Ymax.Size = new System.Drawing.Size(120, 20);
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
            this.Ymin.Location = new System.Drawing.Point(247, 12);
            this.Ymin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Ymin.Name = "Ymin";
            this.Ymin.Size = new System.Drawing.Size(120, 20);
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
            this.autoY.Location = new System.Drawing.Point(512, 15);
            this.autoY.Name = "autoY";
            this.autoY.Size = new System.Drawing.Size(55, 17);
            this.autoY.TabIndex = 10;
            this.autoY.Text = "AutoY";
            this.autoY.UseVisualStyleBackColor = true;
            this.autoY.CheckedChanged += new System.EventHandler(this.autoY_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 395);
            this.Controls.Add(this.autoY);
            this.Controls.Add(this.Ymin);
            this.Controls.Add(this.Ymax);
            this.Controls.Add(this.setInterval);
            this.Controls.Add(this.latimeTensiune);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "nModBus Algodue";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latimeTensiune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ymax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ymin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown latimeTensiune;
        private System.Windows.Forms.NumericUpDown setInterval;
        private System.Windows.Forms.NumericUpDown Ymax;
        private System.Windows.Forms.NumericUpDown Ymin;
        private System.Windows.Forms.CheckBox autoY;
    }
}

