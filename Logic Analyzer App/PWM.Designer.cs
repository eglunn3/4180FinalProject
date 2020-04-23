namespace Logic_Analyzer_App
{
    partial class PWM
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
            this.PWMDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.PWMStart = new System.Windows.Forms.Button();
            this.PWMStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PWMDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // PWMDisplay
            // 
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.PWMDisplay.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.PWMDisplay.Legends.Add(legend1);
            this.PWMDisplay.Location = new System.Drawing.Point(101, 29);
            this.PWMDisplay.Name = "PWMDisplay";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.Turquoise;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "PWMShow";
            this.PWMDisplay.Series.Add(series1);
            this.PWMDisplay.Size = new System.Drawing.Size(746, 577);
            this.PWMDisplay.TabIndex = 0;
            this.PWMDisplay.Text = "PWM Display";
            // 
            // Port
            // 
            this.Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.CerealKiller);
            // 
            // PWMStart
            // 
            this.PWMStart.Location = new System.Drawing.Point(162, 634);
            this.PWMStart.Name = "PWMStart";
            this.PWMStart.Size = new System.Drawing.Size(110, 44);
            this.PWMStart.TabIndex = 1;
            this.PWMStart.Text = "Start";
            this.PWMStart.UseVisualStyleBackColor = true;
            this.PWMStart.Click += new System.EventHandler(this.PWMStart_Click);
            // 
            // PWMStop
            // 
            this.PWMStop.Location = new System.Drawing.Point(343, 634);
            this.PWMStop.Name = "PWMStop";
            this.PWMStop.Size = new System.Drawing.Size(110, 44);
            this.PWMStop.TabIndex = 2;
            this.PWMStop.Text = "Stop";
            this.PWMStop.UseVisualStyleBackColor = true;
            // 
            // PWM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 708);
            this.Controls.Add(this.PWMStop);
            this.Controls.Add(this.PWMStart);
            this.Controls.Add(this.PWMDisplay);
            this.Name = "PWM";
            this.Text = "PWM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PWM_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PWMDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart PWMDisplay;
        private System.IO.Ports.SerialPort Port;
        private System.Windows.Forms.Button PWMStart;
        private System.Windows.Forms.Button PWMStop;
    }
}