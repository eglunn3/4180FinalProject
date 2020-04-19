namespace Logic_Analyzer_App
{
    partial class MainMenu
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
            this.DigitalRead = new System.Windows.Forms.Button();
            this.I2CSelect = new System.Windows.Forms.Button();
            this.SerialSelect = new System.Windows.Forms.Button();
            this.SPISelect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PortSelectLabel = new System.Windows.Forms.TextBox();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.AnalogSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DigitalRead
            // 
            this.DigitalRead.Location = new System.Drawing.Point(232, 56);
            this.DigitalRead.Margin = new System.Windows.Forms.Padding(6);
            this.DigitalRead.Name = "DigitalRead";
            this.DigitalRead.Size = new System.Drawing.Size(218, 70);
            this.DigitalRead.TabIndex = 0;
            this.DigitalRead.Text = "Digital ";
            this.DigitalRead.UseVisualStyleBackColor = true;
            this.DigitalRead.Click += new System.EventHandler(this.DigitalRead_Click);
            // 
            // I2CSelect
            // 
            this.I2CSelect.Location = new System.Drawing.Point(232, 292);
            this.I2CSelect.Margin = new System.Windows.Forms.Padding(6);
            this.I2CSelect.Name = "I2CSelect";
            this.I2CSelect.Size = new System.Drawing.Size(218, 70);
            this.I2CSelect.TabIndex = 1;
            this.I2CSelect.Text = "I2C";
            this.I2CSelect.UseVisualStyleBackColor = true;
            this.I2CSelect.Click += new System.EventHandler(this.I2CSelect_Click);
            // 
            // SerialSelect
            // 
            this.SerialSelect.Location = new System.Drawing.Point(232, 410);
            this.SerialSelect.Margin = new System.Windows.Forms.Padding(6);
            this.SerialSelect.Name = "SerialSelect";
            this.SerialSelect.Size = new System.Drawing.Size(218, 70);
            this.SerialSelect.TabIndex = 2;
            this.SerialSelect.Text = "Serial";
            this.SerialSelect.UseVisualStyleBackColor = true;
            this.SerialSelect.Click += new System.EventHandler(this.SerialSelect_Click);
            // 
            // SPISelect
            // 
            this.SPISelect.Location = new System.Drawing.Point(232, 528);
            this.SPISelect.Margin = new System.Windows.Forms.Padding(6);
            this.SPISelect.Name = "SPISelect";
            this.SPISelect.Size = new System.Drawing.Size(218, 70);
            this.SPISelect.TabIndex = 3;
            this.SPISelect.Text = "SPI";
            this.SPISelect.UseVisualStyleBackColor = true;
            this.SPISelect.Click += new System.EventHandler(this.SPISelect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 732);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 39);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PortSelectLabel
            // 
            this.PortSelectLabel.Location = new System.Drawing.Point(165, 646);
            this.PortSelectLabel.Margin = new System.Windows.Forms.Padding(6);
            this.PortSelectLabel.Name = "PortSelectLabel";
            this.PortSelectLabel.ReadOnly = true;
            this.PortSelectLabel.Size = new System.Drawing.Size(366, 38);
            this.PortSelectLabel.TabIndex = 5;
            this.PortSelectLabel.Text = "Select Serial Port for Mbed";
            this.PortSelectLabel.TextChanged += new System.EventHandler(this.PortSelectLabel_TextChanged);
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(24, 798);
            this.InfoBox.Margin = new System.Windows.Forms.Padding(6);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.Size = new System.Drawing.Size(590, 185);
            this.InfoBox.TabIndex = 6;
            this.InfoBox.Text = "Copyright 2020 under MIT License\nAuthors: eglunn3, sagebrush1111, <insert other a" +
    "uthors>\nWebsite for issues, comments, updates: \nhttps://github.com/eglunn3/4180F" +
    "inalProject";
            // 
            // AnalogSelect
            // 
            this.AnalogSelect.Location = new System.Drawing.Point(232, 174);
            this.AnalogSelect.Margin = new System.Windows.Forms.Padding(6);
            this.AnalogSelect.Name = "AnalogSelect";
            this.AnalogSelect.Size = new System.Drawing.Size(218, 70);
            this.AnalogSelect.TabIndex = 7;
            this.AnalogSelect.Text = "Analog";
            this.AnalogSelect.UseVisualStyleBackColor = true;
            this.AnalogSelect.Click += new System.EventHandler(this.AnalogSelect_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 1055);
            this.Controls.Add(this.AnalogSelect);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.PortSelectLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SPISelect);
            this.Controls.Add(this.SerialSelect);
            this.Controls.Add(this.I2CSelect);
            this.Controls.Add(this.DigitalRead);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "MainMenu";
            this.Text = "Logic Analyzer Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DigitalRead;
        private System.Windows.Forms.Button I2CSelect;
        private System.Windows.Forms.Button SerialSelect;
        private System.Windows.Forms.Button SPISelect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox PortSelectLabel;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button AnalogSelect;
    }
}

