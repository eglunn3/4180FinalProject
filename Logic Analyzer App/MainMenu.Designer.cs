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
            this.SuspendLayout();
            // 
            // DigitalRead
            // 
            this.DigitalRead.Location = new System.Drawing.Point(116, 29);
            this.DigitalRead.Name = "DigitalRead";
            this.DigitalRead.Size = new System.Drawing.Size(109, 36);
            this.DigitalRead.TabIndex = 0;
            this.DigitalRead.Text = "Digital ";
            this.DigitalRead.UseVisualStyleBackColor = true;
            // 
            // I2CSelect
            // 
            this.I2CSelect.Location = new System.Drawing.Point(116, 101);
            this.I2CSelect.Name = "I2CSelect";
            this.I2CSelect.Size = new System.Drawing.Size(109, 36);
            this.I2CSelect.TabIndex = 1;
            this.I2CSelect.Text = "I2C";
            this.I2CSelect.UseVisualStyleBackColor = true;
            // 
            // SerialSelect
            // 
            this.SerialSelect.Location = new System.Drawing.Point(116, 176);
            this.SerialSelect.Name = "SerialSelect";
            this.SerialSelect.Size = new System.Drawing.Size(109, 36);
            this.SerialSelect.TabIndex = 2;
            this.SerialSelect.Text = "Serial";
            this.SerialSelect.UseVisualStyleBackColor = true;
            // 
            // SPISelect
            // 
            this.SPISelect.Location = new System.Drawing.Point(116, 252);
            this.SPISelect.Name = "SPISelect";
            this.SPISelect.Size = new System.Drawing.Size(109, 36);
            this.SPISelect.TabIndex = 3;
            this.SPISelect.Text = "SPI";
            this.SPISelect.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 354);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // PortSelectLabel
            // 
            this.PortSelectLabel.Location = new System.Drawing.Point(79, 310);
            this.PortSelectLabel.Name = "PortSelectLabel";
            this.PortSelectLabel.ReadOnly = true;
            this.PortSelectLabel.Size = new System.Drawing.Size(185, 22);
            this.PortSelectLabel.TabIndex = 5;
            this.PortSelectLabel.Text = "Select Serial Port for Mbed";
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(12, 394);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.Size = new System.Drawing.Size(297, 97);
            this.InfoBox.TabIndex = 6;
            this.InfoBox.Text = "Copyright 2020 under MIT License\nAuthors: eglunn3, sagebrush1111, <insert other a" +
    "uthors>\nWebsite for issues, comments, updates: \nhttps://github.com/eglunn3/4180F" +
    "inalProject";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 538);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.PortSelectLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SPISelect);
            this.Controls.Add(this.SerialSelect);
            this.Controls.Add(this.I2CSelect);
            this.Controls.Add(this.DigitalRead);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

