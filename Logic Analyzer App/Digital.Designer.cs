namespace Logic_Analyzer_App
{
    partial class Digital
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
            this.Pin1Combo = new System.Windows.Forms.ComboBox();
            this.Pin2Combo = new System.Windows.Forms.ComboBox();
            this.Pin3Combo = new System.Windows.Forms.ComboBox();
            this.Pin4Combo = new System.Windows.Forms.ComboBox();
            this.Pin5Combo = new System.Windows.Forms.ComboBox();
            this.PinInfo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Pin1Out = new System.Windows.Forms.TextBox();
            this.Pin2Out = new System.Windows.Forms.TextBox();
            this.Pin3Out = new System.Windows.Forms.TextBox();
            this.Pin4Out = new System.Windows.Forms.TextBox();
            this.Pin5Out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Pin1Combo
            // 
            this.Pin1Combo.FormattingEnabled = true;
            this.Pin1Combo.Items.AddRange(new object[] {
            "Pin 21",
            "Pin 22",
            "Pin 23",
            "Pin 24",
            "Pin 25"});
            this.Pin1Combo.Location = new System.Drawing.Point(24, 141);
            this.Pin1Combo.Margin = new System.Windows.Forms.Padding(6);
            this.Pin1Combo.Name = "Pin1Combo";
            this.Pin1Combo.Size = new System.Drawing.Size(238, 39);
            this.Pin1Combo.TabIndex = 0;
            this.Pin1Combo.SelectedIndexChanged += new System.EventHandler(this.Pin1Combo_SelectedIndexChanged);
            // 
            // Pin2Combo
            // 
            this.Pin2Combo.FormattingEnabled = true;
            this.Pin2Combo.Items.AddRange(new object[] {
            "Pin 21",
            "Pin 22",
            "Pin 23",
            "Pin 24",
            "Pin 25"});
            this.Pin2Combo.Location = new System.Drawing.Point(24, 234);
            this.Pin2Combo.Margin = new System.Windows.Forms.Padding(6);
            this.Pin2Combo.Name = "Pin2Combo";
            this.Pin2Combo.Size = new System.Drawing.Size(238, 39);
            this.Pin2Combo.TabIndex = 1;
            this.Pin2Combo.SelectedIndexChanged += new System.EventHandler(this.Pin2Combo_SelectedIndexChanged);
            // 
            // Pin3Combo
            // 
            this.Pin3Combo.FormattingEnabled = true;
            this.Pin3Combo.Items.AddRange(new object[] {
            "Pin 21",
            "Pin 22",
            "Pin 23",
            "Pin 24",
            "Pin 25"});
            this.Pin3Combo.Location = new System.Drawing.Point(24, 339);
            this.Pin3Combo.Margin = new System.Windows.Forms.Padding(6);
            this.Pin3Combo.Name = "Pin3Combo";
            this.Pin3Combo.Size = new System.Drawing.Size(238, 39);
            this.Pin3Combo.TabIndex = 2;
            this.Pin3Combo.SelectedIndexChanged += new System.EventHandler(this.Pin3Combo_SelectedIndexChanged);
            // 
            // Pin4Combo
            // 
            this.Pin4Combo.FormattingEnabled = true;
            this.Pin4Combo.Items.AddRange(new object[] {
            "Pin 21",
            "Pin 22",
            "Pin 23",
            "Pin 24",
            "Pin 25"});
            this.Pin4Combo.Location = new System.Drawing.Point(24, 438);
            this.Pin4Combo.Margin = new System.Windows.Forms.Padding(6);
            this.Pin4Combo.Name = "Pin4Combo";
            this.Pin4Combo.Size = new System.Drawing.Size(238, 39);
            this.Pin4Combo.TabIndex = 3;
            this.Pin4Combo.SelectedIndexChanged += new System.EventHandler(this.Pin4Combo_SelectedIndexChanged);
            // 
            // Pin5Combo
            // 
            this.Pin5Combo.FormattingEnabled = true;
            this.Pin5Combo.Items.AddRange(new object[] {
            "Pin 21",
            "Pin 22",
            "Pin 23",
            "Pin 24",
            "Pin 25"});
            this.Pin5Combo.Location = new System.Drawing.Point(24, 544);
            this.Pin5Combo.Margin = new System.Windows.Forms.Padding(6);
            this.Pin5Combo.Name = "Pin5Combo";
            this.Pin5Combo.Size = new System.Drawing.Size(238, 39);
            this.Pin5Combo.TabIndex = 4;
            this.Pin5Combo.SelectedIndexChanged += new System.EventHandler(this.Pin5Combo_SelectedIndexChanged);
            // 
            // PinInfo
            // 
            this.PinInfo.Location = new System.Drawing.Point(24, 64);
            this.PinInfo.Margin = new System.Windows.Forms.Padding(6);
            this.PinInfo.Name = "PinInfo";
            this.PinInfo.ReadOnly = true;
            this.PinInfo.Size = new System.Drawing.Size(238, 38);
            this.PinInfo.TabIndex = 5;
            this.PinInfo.Text = "Select Pin";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(336, 64);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(106, 38);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Output";
            // 
            // Pin1Out
            // 
            this.Pin1Out.Location = new System.Drawing.Point(336, 145);
            this.Pin1Out.Margin = new System.Windows.Forms.Padding(6);
            this.Pin1Out.Name = "Pin1Out";
            this.Pin1Out.ReadOnly = true;
            this.Pin1Out.Size = new System.Drawing.Size(74, 38);
            this.Pin1Out.TabIndex = 7;
            // 
            // Pin2Out
            // 
            this.Pin2Out.Location = new System.Drawing.Point(336, 238);
            this.Pin2Out.Margin = new System.Windows.Forms.Padding(6);
            this.Pin2Out.Name = "Pin2Out";
            this.Pin2Out.ReadOnly = true;
            this.Pin2Out.Size = new System.Drawing.Size(74, 38);
            this.Pin2Out.TabIndex = 8;
            // 
            // Pin3Out
            // 
            this.Pin3Out.Location = new System.Drawing.Point(336, 343);
            this.Pin3Out.Margin = new System.Windows.Forms.Padding(6);
            this.Pin3Out.Name = "Pin3Out";
            this.Pin3Out.ReadOnly = true;
            this.Pin3Out.Size = new System.Drawing.Size(74, 38);
            this.Pin3Out.TabIndex = 9;
            // 
            // Pin4Out
            // 
            this.Pin4Out.Location = new System.Drawing.Point(336, 442);
            this.Pin4Out.Margin = new System.Windows.Forms.Padding(6);
            this.Pin4Out.Name = "Pin4Out";
            this.Pin4Out.ReadOnly = true;
            this.Pin4Out.Size = new System.Drawing.Size(74, 38);
            this.Pin4Out.TabIndex = 10;
            // 
            // Pin5Out
            // 
            this.Pin5Out.Location = new System.Drawing.Point(336, 548);
            this.Pin5Out.Margin = new System.Windows.Forms.Padding(6);
            this.Pin5Out.Name = "Pin5Out";
            this.Pin5Out.ReadOnly = true;
            this.Pin5Out.Size = new System.Drawing.Size(74, 38);
            this.Pin5Out.TabIndex = 11;
            // 
            // Digital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 703);
            this.Controls.Add(this.Pin5Out);
            this.Controls.Add(this.Pin4Out);
            this.Controls.Add(this.Pin3Out);
            this.Controls.Add(this.Pin2Out);
            this.Controls.Add(this.Pin1Out);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PinInfo);
            this.Controls.Add(this.Pin5Combo);
            this.Controls.Add(this.Pin4Combo);
            this.Controls.Add(this.Pin3Combo);
            this.Controls.Add(this.Pin2Combo);
            this.Controls.Add(this.Pin1Combo);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Digital";
            this.Text = "Digital";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Digital_FormClosing);
            this.Load += new System.EventHandler(this.Digital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Pin1Combo;
        private System.Windows.Forms.ComboBox Pin2Combo;
        private System.Windows.Forms.ComboBox Pin3Combo;
        private System.Windows.Forms.ComboBox Pin4Combo;
        private System.Windows.Forms.ComboBox Pin5Combo;
        private System.Windows.Forms.TextBox PinInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Pin1Out;
        private System.Windows.Forms.TextBox Pin2Out;
        private System.Windows.Forms.TextBox Pin3Out;
        private System.Windows.Forms.TextBox Pin4Out;
        private System.Windows.Forms.TextBox Pin5Out;
    }
}