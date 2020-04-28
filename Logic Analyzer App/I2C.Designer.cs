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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(I2C));
            this.ScopePinInfo = new System.Windows.Forms.Label();
            this.I2CStop = new System.Windows.Forms.Button();
            this.I2CStart = new System.Windows.Forms.Button();
            this.I2CTimeSelect = new System.Windows.Forms.ComboBox();
            this.I2CDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.I2CDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // ScopePinInfo
            // 
            this.ScopePinInfo.AutoSize = true;
            this.ScopePinInfo.Location = new System.Drawing.Point(238, 1600);
            this.ScopePinInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ScopePinInfo.Name = "ScopePinInfo";
            this.ScopePinInfo.Size = new System.Drawing.Size(259, 32);
            this.ScopePinInfo.TabIndex = 12;
            this.ScopePinInfo.Text = "Use P16 for Scope.";
            // 
            // I2CStop
            // 
            this.I2CStop.Location = new System.Drawing.Point(442, 1471);
            this.I2CStop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.I2CStop.Name = "I2CStop";
            this.I2CStop.Size = new System.Drawing.Size(220, 85);
            this.I2CStop.TabIndex = 11;
            this.I2CStop.Text = "Stop";
            this.I2CStop.UseVisualStyleBackColor = true;
            // 
            // I2CStart
            // 
            this.I2CStart.Location = new System.Drawing.Point(80, 1471);
            this.I2CStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.I2CStart.Name = "I2CStart";
            this.I2CStart.Size = new System.Drawing.Size(220, 85);
            this.I2CStart.TabIndex = 10;
            this.I2CStart.Text = "Start";
            this.I2CStart.UseVisualStyleBackColor = true;
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
            this.I2CTimeSelect.Location = new System.Drawing.Point(780, 1492);
            this.I2CTimeSelect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.I2CTimeSelect.Name = "I2CTimeSelect";
            this.I2CTimeSelect.Size = new System.Drawing.Size(322, 39);
            this.I2CTimeSelect.TabIndex = 13;
            this.I2CTimeSelect.Text = "Select Length of Run";
            // 
            // I2CDisplay
            // 
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.Name = "SDAChart";
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "SCLChart";
            this.I2CDisplay.ChartAreas.Add(chartArea1);
            this.I2CDisplay.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.I2CDisplay.Legends.Add(legend1);
            this.I2CDisplay.Location = new System.Drawing.Point(24, 23);
            this.I2CDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.I2CDisplay.Name = "I2CDisplay";
            series1.ChartArea = "SDAChart";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "SDA";
            series2.ChartArea = "SCLChart";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "SCL";
            this.I2CDisplay.Series.Add(series1);
            this.I2CDisplay.Series.Add(series2);
            this.I2CDisplay.Size = new System.Drawing.Size(3548, 1389);
            this.I2CDisplay.TabIndex = 14;
            this.I2CDisplay.Text = "I2C Display";
            // 
            // I2C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3624, 1629);
            this.Controls.Add(this.I2CDisplay);
            this.Controls.Add(this.I2CTimeSelect);
            this.Controls.Add(this.ScopePinInfo);
            this.Controls.Add(this.I2CStop);
            this.Controls.Add(this.I2CStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "I2C";
            this.Text = "I2C";
            ((System.ComponentModel.ISupportInitialize)(this.I2CDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScopePinInfo;
        private System.Windows.Forms.Button I2CStop;
        private System.Windows.Forms.Button I2CStart;
        private System.Windows.Forms.ComboBox I2CTimeSelect;
        private System.Windows.Forms.DataVisualization.Charting.Chart I2CDisplay;
        private System.IO.Ports.SerialPort Port;
    }
}