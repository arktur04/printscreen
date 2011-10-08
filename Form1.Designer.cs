namespace WindowsFormsApplication6
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Dundas.Charting.WinControl.ChartArea chartArea15 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend15 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series15 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.DataPoint dataPoint43 = new Dundas.Charting.WinControl.DataPoint(0D, 20D);
            Dundas.Charting.WinControl.DataPoint dataPoint44 = new Dundas.Charting.WinControl.DataPoint(0D, 25D);
            Dundas.Charting.WinControl.DataPoint dataPoint45 = new Dundas.Charting.WinControl.DataPoint(0D, 34D);
            Dundas.Charting.WinControl.DataPoint dataPoint46 = new Dundas.Charting.WinControl.DataPoint(0D, 18D);
            Dundas.Charting.WinControl.DataPoint dataPoint47 = new Dundas.Charting.WinControl.DataPoint(0D, 22D);
            Dundas.Charting.WinControl.DataPoint dataPoint48 = new Dundas.Charting.WinControl.DataPoint(0D, 21D);
            Dundas.Charting.WinControl.Title title8 = new Dundas.Charting.WinControl.Title();
            Dundas.Charting.WinControl.ChartArea chartArea16 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend16 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.LegendItem legendItem8 = new Dundas.Charting.WinControl.LegendItem();
            Dundas.Charting.WinControl.Series series16 = new Dundas.Charting.WinControl.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new Dundas.Charting.WinControl.Chart();
            this.chart2 = new Dundas.Charting.WinControl.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(848, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 722);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 690);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.panel1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(42, 662);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(0, 154);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 479);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "0\r\n1\r\n2\r\n3\r\n4";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(0, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 77);
            this.button2.TabIndex = 5;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonStopClick);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 77);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonStartClick);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart2);
            this.splitContainer1.Size = new System.Drawing.Size(848, 722);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.TabIndex = 5;
            // 
            // chart1
            // 
            this.chart1.AlwaysRecreateHotregions = true;
            this.chart1.BackGradientEndColor = System.Drawing.Color.White;
            this.chart1.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft;
            this.chart1.BorderLineColor = System.Drawing.Color.LightGray;
            this.chart1.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue;
            this.chart1.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue;
            this.chart1.BorderSkin.FrameBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart1.BorderSkin.FrameBorderWidth = 2;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            chartArea15.Area3DStyle.Light = Dundas.Charting.WinControl.LightStyle.Realistic;
            chartArea15.AxisX.LabelStyle.Interval = 100D;
            chartArea15.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea15.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea15.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot;
            chartArea15.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea15.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross;
            chartArea15.AxisX.MinorTickMark.Size = 2F;
            chartArea15.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea15.AxisY.LabelStyle.Format = "F";
            chartArea15.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea15.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea15.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot;
            chartArea15.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea15.AxisY.MinorTickMark.Size = 2F;
            chartArea15.AxisY.StartFromZero = false;
            chartArea15.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea15.BackColor = System.Drawing.Color.Transparent;
            chartArea15.BorderColor = System.Drawing.Color.DimGray;
            chartArea15.Name = "Default";
            this.chart1.ChartAreas.Add(chartArea15);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend15.Alignment = System.Drawing.StringAlignment.Center;
            legend15.BackColor = System.Drawing.Color.Transparent;
            legend15.BorderColor = System.Drawing.Color.Transparent;
            legend15.Docking = Dundas.Charting.WinControl.LegendDocking.Bottom;
            legend15.Enabled = false;
            legend15.LegendStyle = Dundas.Charting.WinControl.LegendStyle.Column;
            legend15.Name = "Default";
            this.chart1.Legends.Add(legend15);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent;
            series15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            series15.BorderWidth = 2;
            series15.ChartType = "Spline";
            series15.CustomAttributes = "PolarDrawingStyle=Line";
            series15.MarkerStyle = Dundas.Charting.WinControl.MarkerStyle.Circle;
            series15.Name = "Series1";
            series15.PaletteCustomColors = new System.Drawing.Color[0];
            dataPoint43.FontAngle = 0;
            dataPoint44.FontAngle = 0;
            dataPoint45.FontAngle = 0;
            dataPoint46.FontAngle = 0;
            dataPoint47.FontAngle = 0;
            dataPoint48.FontAngle = 0;
            series15.Points.Add(dataPoint43);
            series15.Points.Add(dataPoint44);
            series15.Points.Add(dataPoint45);
            series15.Points.Add(dataPoint46);
            series15.Points.Add(dataPoint47);
            series15.Points.Add(dataPoint48);
            series15.SmartLabels.Enabled = true;
            this.chart1.Series.Add(series15);
            this.chart1.Size = new System.Drawing.Size(848, 348);
            this.chart1.SoftShadows = false;
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title8.Name = "Title1";
            this.chart1.Titles.Add(title8);
            this.chart1.UI.ContextMenu.Enabled = true;
            this.chart1.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart1.UI.Toolbar.Enabled = true;
            // 
            // chart2
            // 
            this.chart2.AlwaysRecreateHotregions = true;
            this.chart2.BackColor = System.Drawing.Color.Black;
            this.chart2.BorderSkin.FrameBackColor = System.Drawing.Color.Black;
            chartArea16.AxisX.LabelStyle.FontColor = System.Drawing.Color.White;
            chartArea16.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY.LabelStyle.FontColor = System.Drawing.Color.White;
            chartArea16.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.BackColor = System.Drawing.Color.Black;
            chartArea16.BorderColor = System.Drawing.Color.Empty;
            chartArea16.Name = "Default";
            this.chart2.ChartAreas.Add(chartArea16);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legendItem8.Name = "Legend Item";
            legend16.CustomItems.Add(legendItem8);
            legend16.Enabled = false;
            legend16.LegendStyle = Dundas.Charting.WinControl.LegendStyle.Row;
            legend16.Name = "Default";
            legend16.Title = "The Legend";
            this.chart2.Legends.Add(legend16);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            this.chart2.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel;
            series16.BackGradientEndColor = System.Drawing.Color.Transparent;
            series16.ChartType = "FastPoint";
            series16.Color = System.Drawing.Color.Lime;
            series16.Name = "Series1";
            series16.PaletteCustomColors = new System.Drawing.Color[0];
            series16.ShadowOffset = 1;
            this.chart2.Series.Add(series16);
            this.chart2.Size = new System.Drawing.Size(848, 370);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            this.chart2.UI.ContextMenu.Enabled = true;
            this.chart2.UI.Toolbar.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            this.chart2.UI.Toolbar.Enabled = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.PortName = "COM7";
            this.serialPort1.ReadTimeout = 10;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "float",
            "ui32",
            "si32"});
            this.comboBox1.Location = new System.Drawing.Point(212, 662);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "float";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 662);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Addr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tag prop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(175, 665);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1114, 722);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Dundas.Charting.WinControl.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private Dundas.Charting.WinControl.Chart chart2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;



    }
}

