namespace Logic_Analyzer_App
{
    partial class I2C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(I2C));
            this.I2CPinInfo = new System.Windows.Forms.Label();
            this.I2CStop = new System.Windows.Forms.Button();
            this.I2CStart = new System.Windows.Forms.Button();
            this.I2CTimeSelect = new System.Windows.Forms.ComboBox();
            this.I2CDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.I2CDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // I2CPinInfo
            // 
            this.I2CPinInfo.AutoSize = true;
            this.I2CPinInfo.Location = new System.Drawing.Point(91, 676);
            this.I2CPinInfo.Name = "I2CPinInfo";
            this.I2CPinInfo.Size = new System.Drawing.Size(111, 17);
            this.I2CPinInfo.TabIndex = 12;
            this.I2CPinInfo.Text = "Use P16 for I2C.";
            // 
            // I2CStop
            // 
            this.I2CStop.Location = new System.Drawing.Point(193, 609);
            this.I2CStop.Name = "I2CStop";
            this.I2CStop.Size = new System.Drawing.Size(110, 44);
            this.I2CStop.TabIndex = 11;
            this.I2CStop.Text = "Stop";
            this.I2CStop.UseVisualStyleBackColor = true;
            this.I2CStop.Click += new System.EventHandler(this.I2CStop_Click);
            // 
            // I2CStart
            // 
            this.I2CStart.Location = new System.Drawing.Point(12, 609);
            this.I2CStart.Name = "I2CStart";
            this.I2CStart.Size = new System.Drawing.Size(110, 44);
            this.I2CStart.TabIndex = 10;
            this.I2CStart.Text = "Start";
            this.I2CStart.UseVisualStyleBackColor = true;
            this.I2CStart.Click += new System.EventHandler(this.I2CStart_Click);
            // 
            // I2CTimeSelect
            // 
            this.I2CTimeSelect.FormattingEnabled = true;
            this.I2CTimeSelect.Items.AddRange(new object[] {
            "1ms",
            "5ms",
            "10ms",
            "50ms",
            "100ms",
            "250ms",
            "500ms",
            "1s"});
            this.I2CTimeSelect.Location = new System.Drawing.Point(362, 620);
            this.I2CTimeSelect.Name = "I2CTimeSelect";
            this.I2CTimeSelect.Size = new System.Drawing.Size(163, 24);
            this.I2CTimeSelect.TabIndex = 13;
            this.I2CTimeSelect.Text = "Select Length of Run";
            // 
            // I2CDisplay
            // 
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.Name = "SDAChart";
            this.I2CDisplay.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.I2CDisplay.Legends.Add(legend1);
            this.I2CDisplay.Location = new System.Drawing.Point(12, 12);
            this.I2CDisplay.Name = "I2CDisplay";
            series1.ChartArea = "SDAChart";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "SDA";
            this.I2CDisplay.Series.Add(series1);
            this.I2CDisplay.Size = new System.Drawing.Size(1830, 548);
            this.I2CDisplay.TabIndex = 14;
            this.I2CDisplay.Text = "I2C Display";
            this.I2CDisplay.DoubleClick += new System.EventHandler(this.I2CDisplay_DoubleClick);
            // 
            // Port
            // 
            this.Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.CerealKiller);
            // 
            // I2C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 702);
            this.Controls.Add(this.I2CDisplay);
            this.Controls.Add(this.I2CTimeSelect);
            this.Controls.Add(this.I2CPinInfo);
            this.Controls.Add(this.I2CStop);
            this.Controls.Add(this.I2CStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "I2C";
            this.Text = "I2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.I2C_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.I2CDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label I2CPinInfo;
        private System.Windows.Forms.Button I2CStop;
        private System.Windows.Forms.Button I2CStart;
        private System.Windows.Forms.ComboBox I2CTimeSelect;
        private System.Windows.Forms.DataVisualization.Charting.Chart I2CDisplay;
        private System.IO.Ports.SerialPort Port;
    }
}