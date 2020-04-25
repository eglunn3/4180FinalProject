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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.ScopePinInfo.Location = new System.Drawing.Point(119, 826);
            this.ScopePinInfo.Name = "ScopePinInfo";
            this.ScopePinInfo.Size = new System.Drawing.Size(131, 17);
            this.ScopePinInfo.TabIndex = 12;
            this.ScopePinInfo.Text = "Use P16 for Scope.";
            // 
            // I2CStop
            // 
            this.I2CStop.Location = new System.Drawing.Point(221, 759);
            this.I2CStop.Name = "I2CStop";
            this.I2CStop.Size = new System.Drawing.Size(110, 44);
            this.I2CStop.TabIndex = 11;
            this.I2CStop.Text = "Stop";
            this.I2CStop.UseVisualStyleBackColor = true;
            // 
            // I2CStart
            // 
            this.I2CStart.Location = new System.Drawing.Point(40, 759);
            this.I2CStart.Name = "I2CStart";
            this.I2CStart.Size = new System.Drawing.Size(110, 44);
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
            this.I2CTimeSelect.Location = new System.Drawing.Point(390, 770);
            this.I2CTimeSelect.Name = "I2CTimeSelect";
            this.I2CTimeSelect.Size = new System.Drawing.Size(163, 24);
            this.I2CTimeSelect.TabIndex = 13;
            this.I2CTimeSelect.Text = "Select Length of Run";
            // 
            // I2CDisplay
            // 
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea3.Name = "SDAChart";
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.Name = "SCLChart";
            this.I2CDisplay.ChartAreas.Add(chartArea3);
            this.I2CDisplay.ChartAreas.Add(chartArea4);
            legend2.Name = "Legend1";
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.I2CDisplay.Legends.Add(legend2);
            this.I2CDisplay.Location = new System.Drawing.Point(12, 12);
            this.I2CDisplay.Name = "I2CDisplay";
            series3.ChartArea = "SDAChart";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "SDA";
            series4.ChartArea = "SCLChart";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "SCL";
            this.I2CDisplay.Series.Add(series3);
            this.I2CDisplay.Series.Add(series4);
            this.I2CDisplay.Size = new System.Drawing.Size(1774, 717);
            this.I2CDisplay.TabIndex = 14;
            this.I2CDisplay.Text = "I2C Display";
            // 
            // I2C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 841);
            this.Controls.Add(this.I2CDisplay);
            this.Controls.Add(this.I2CTimeSelect);
            this.Controls.Add(this.ScopePinInfo);
            this.Controls.Add(this.I2CStop);
            this.Controls.Add(this.I2CStart);
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