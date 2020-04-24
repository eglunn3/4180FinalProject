namespace Logic_Analyzer_App
{
    partial class Scope
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
            this.ScopeTimeSelect = new System.Windows.Forms.ComboBox();
            this.RFChoice = new System.Windows.Forms.ComboBox();
            this.ScopePinInfo = new System.Windows.Forms.Label();
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
            this.PWMStop.Click += new System.EventHandler(this.PWMStop_Click);
            // 
            // ScopeTimeSelect
            // 
            this.ScopeTimeSelect.FormattingEnabled = true;
            this.ScopeTimeSelect.Items.AddRange(new object[] {
            "1ms",
            "5ms",
            "10ms",
            "50ms",
            "100ms",
            "250ms",
            "500ms",
            "1s"});
            this.ScopeTimeSelect.Location = new System.Drawing.Point(684, 645);
            this.ScopeTimeSelect.Name = "ScopeTimeSelect";
            this.ScopeTimeSelect.Size = new System.Drawing.Size(163, 24);
            this.ScopeTimeSelect.TabIndex = 3;
            this.ScopeTimeSelect.Text = "Select Length of Run";
            // 
            // RFChoice
            // 
            this.RFChoice.FormattingEnabled = true;
            this.RFChoice.Items.AddRange(new object[] {
            "Rise",
            "Fall"});
            this.RFChoice.Location = new System.Drawing.Point(483, 645);
            this.RFChoice.Name = "RFChoice";
            this.RFChoice.Size = new System.Drawing.Size(167, 24);
            this.RFChoice.TabIndex = 8;
            this.RFChoice.Text = "Rise or Fall?";
            // 
            // ScopePinInfo
            // 
            this.ScopePinInfo.AutoSize = true;
            this.ScopePinInfo.Location = new System.Drawing.Point(241, 701);
            this.ScopePinInfo.Name = "ScopePinInfo";
            this.ScopePinInfo.Size = new System.Drawing.Size(131, 17);
            this.ScopePinInfo.TabIndex = 9;
            this.ScopePinInfo.Text = "Use P16 for Scope.";
            // 
            // Scope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 727);
            this.Controls.Add(this.ScopePinInfo);
            this.Controls.Add(this.RFChoice);
            this.Controls.Add(this.ScopeTimeSelect);
            this.Controls.Add(this.PWMStop);
            this.Controls.Add(this.PWMStart);
            this.Controls.Add(this.PWMDisplay);
            this.Name = "Scope";
            this.Text = "Scope";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PWM_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PWMDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart PWMDisplay;
        private System.IO.Ports.SerialPort Port;
        private System.Windows.Forms.Button PWMStart;
        private System.Windows.Forms.Button PWMStop;
        private System.Windows.Forms.ComboBox ScopeTimeSelect;
        private System.Windows.Forms.ComboBox RFChoice;
        private System.Windows.Forms.Label ScopePinInfo;
    }
}