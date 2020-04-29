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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scope));
            this.ScopeDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.ScopeStart = new System.Windows.Forms.Button();
            this.ScopeStop = new System.Windows.Forms.Button();
            this.ScopeTimeSelect = new System.Windows.Forms.ComboBox();
            this.RFChoice = new System.Windows.Forms.ComboBox();
            this.ScopePinInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScopeDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // ScopeDisplay
            // 
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.ScopeDisplay.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.ScopeDisplay.Legends.Add(legend1);
            this.ScopeDisplay.Location = new System.Drawing.Point(5, 29);
            this.ScopeDisplay.Name = "ScopeDisplay";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Turquoise;
            series1.Legend = "Legend1";
            series1.Name = "ScopeShow";
            this.ScopeDisplay.Series.Add(series1);
            this.ScopeDisplay.Size = new System.Drawing.Size(1535, 577);
            this.ScopeDisplay.TabIndex = 0;
            this.ScopeDisplay.Text = "Scope Display";
            // 
            // Port
            // 
            this.Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.CerealKiller);
            // 
            // ScopeStart
            // 
            this.ScopeStart.Location = new System.Drawing.Point(162, 634);
            this.ScopeStart.Name = "ScopeStart";
            this.ScopeStart.Size = new System.Drawing.Size(110, 44);
            this.ScopeStart.TabIndex = 1;
            this.ScopeStart.Text = "Start";
            this.ScopeStart.UseVisualStyleBackColor = true;
            this.ScopeStart.Click += new System.EventHandler(this.ScopeStart_Click);
            // 
            // ScopeStop
            // 
            this.ScopeStop.Location = new System.Drawing.Point(343, 634);
            this.ScopeStop.Name = "ScopeStop";
            this.ScopeStop.Size = new System.Drawing.Size(110, 44);
            this.ScopeStop.TabIndex = 2;
            this.ScopeStop.Text = "Stop";
            this.ScopeStop.UseVisualStyleBackColor = true;
            this.ScopeStop.Click += new System.EventHandler(this.ScopeStop_Click);
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
            this.ClientSize = new System.Drawing.Size(1546, 684);
            this.Controls.Add(this.ScopePinInfo);
            this.Controls.Add(this.RFChoice);
            this.Controls.Add(this.ScopeTimeSelect);
            this.Controls.Add(this.ScopeStop);
            this.Controls.Add(this.ScopeStart);
            this.Controls.Add(this.ScopeDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scope";
            this.Text = "Scope";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scope_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ScopeDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart ScopeDisplay;
        private System.IO.Ports.SerialPort Port;
        private System.Windows.Forms.Button ScopeStart;
        private System.Windows.Forms.Button ScopeStop;
        private System.Windows.Forms.ComboBox ScopeTimeSelect;
        private System.Windows.Forms.ComboBox RFChoice;
        private System.Windows.Forms.Label ScopePinInfo;
    }
}