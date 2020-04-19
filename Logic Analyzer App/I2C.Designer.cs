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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.I2CChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.I2CStart = new System.Windows.Forms.Button();
            this.I2CStop = new System.Windows.Forms.Button();
            this.I2CPinInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.I2CChart)).BeginInit();
            this.SuspendLayout();
            // 
            // I2CChart
            // 
            this.I2CChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.Lime;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.I2CChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.I2CChart.Legends.Add(legend1);
            this.I2CChart.Location = new System.Drawing.Point(65, 30);
            this.I2CChart.Name = "I2CChart";
            this.I2CChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.Lime;
            series1.LabelForeColor = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "I2C";
            this.I2CChart.Series.Add(series1);
            this.I2CChart.Size = new System.Drawing.Size(553, 405);
            this.I2CChart.TabIndex = 0;
            this.I2CChart.Text = "I2CChart";
            this.I2CChart.Click += new System.EventHandler(this.I2CChart_Click);
            // 
            // I2CStart
            // 
            this.I2CStart.Location = new System.Drawing.Point(65, 460);
            this.I2CStart.Name = "I2CStart";
            this.I2CStart.Size = new System.Drawing.Size(105, 39);
            this.I2CStart.TabIndex = 1;
            this.I2CStart.Text = "Start";
            this.I2CStart.UseVisualStyleBackColor = true;
            this.I2CStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // I2CStop
            // 
            this.I2CStop.Location = new System.Drawing.Point(176, 460);
            this.I2CStop.Name = "I2CStop";
            this.I2CStop.Size = new System.Drawing.Size(105, 39);
            this.I2CStop.TabIndex = 2;
            this.I2CStop.Text = "Stop";
            this.I2CStop.UseVisualStyleBackColor = true;
            // 
            // I2CPinInfo
            // 
            this.I2CPinInfo.AutoSize = true;
            this.I2CPinInfo.Location = new System.Drawing.Point(305, 471);
            this.I2CPinInfo.Name = "I2CPinInfo";
            this.I2CPinInfo.Size = new System.Drawing.Size(243, 17);
            this.I2CPinInfo.TabIndex = 3;
            this.I2CPinInfo.Text = "The pins used for I2C Monitoring Are:";
            // 
            // I2C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 528);
            this.Controls.Add(this.I2CPinInfo);
            this.Controls.Add(this.I2CStop);
            this.Controls.Add(this.I2CStart);
            this.Controls.Add(this.I2CChart);
            this.Name = "I2C";
            this.Text = "I2C";
            ((System.ComponentModel.ISupportInitialize)(this.I2CChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart I2CChart;
        private System.Windows.Forms.Button I2CStart;
        private System.Windows.Forms.Button I2CStop;
        private System.Windows.Forms.Label I2CPinInfo;
    }
}