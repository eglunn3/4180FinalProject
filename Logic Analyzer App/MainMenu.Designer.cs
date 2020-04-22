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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PortSelectLabel = new System.Windows.Forms.TextBox();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.AnalogSelect = new System.Windows.Forms.Button();
            this.PWMButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DigitalRead
            // 
            this.DigitalRead.Location = new System.Drawing.Point(102, 28);
            this.DigitalRead.Name = "DigitalRead";
            this.DigitalRead.Size = new System.Drawing.Size(109, 36);
            this.DigitalRead.TabIndex = 0;
            this.DigitalRead.Text = "Digital ";
            this.DigitalRead.UseVisualStyleBackColor = true;
            this.DigitalRead.Click += new System.EventHandler(this.DigitalRead_Click);
            // 
            // I2CSelect
            // 
            this.I2CSelect.Location = new System.Drawing.Point(102, 153);
            this.I2CSelect.Margin = new System.Windows.Forms.Padding(6);
            this.I2CSelect.Name = "I2CSelect";
            this.I2CSelect.Size = new System.Drawing.Size(109, 36);
            this.I2CSelect.TabIndex = 1;
            this.I2CSelect.Text = "I2C";
            this.I2CSelect.UseVisualStyleBackColor = true;
            this.I2CSelect.Click += new System.EventHandler(this.I2CSelect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 299);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PortSelectLabel
            // 
            this.PortSelectLabel.Location = new System.Drawing.Point(76, 265);
            this.PortSelectLabel.Margin = new System.Windows.Forms.Padding(6);
            this.PortSelectLabel.Name = "PortSelectLabel";
            this.PortSelectLabel.ReadOnly = true;
            this.PortSelectLabel.Size = new System.Drawing.Size(172, 22);
            this.PortSelectLabel.TabIndex = 5;
            this.PortSelectLabel.Text = "Select Serial Port for Mbed";
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(8, 341);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.Size = new System.Drawing.Size(297, 97);
            this.InfoBox.TabIndex = 6;
            this.InfoBox.Text = "Copyright 2020 under MIT License\nAuthors: eglunn3, sagebrush1111, <insert other a" +
    "uthors>\nWebsite for issues, comments, updates: \nhttps://github.com/eglunn3/4180F" +
    "inalProject";
            // 
            // AnalogSelect
            // 
            this.AnalogSelect.Location = new System.Drawing.Point(102, 91);
            this.AnalogSelect.Margin = new System.Windows.Forms.Padding(6);
            this.AnalogSelect.Name = "AnalogSelect";
            this.AnalogSelect.Size = new System.Drawing.Size(109, 36);
            this.AnalogSelect.TabIndex = 7;
            this.AnalogSelect.Text = "Analog";
            this.AnalogSelect.UseVisualStyleBackColor = true;
            this.AnalogSelect.Click += new System.EventHandler(this.AnalogSelect_Click);
            // 
            // PWMButton
            // 
            this.PWMButton.Location = new System.Drawing.Point(102, 217);
            this.PWMButton.Margin = new System.Windows.Forms.Padding(6);
            this.PWMButton.Name = "PWMButton";
            this.PWMButton.Size = new System.Drawing.Size(109, 36);
            this.PWMButton.TabIndex = 8;
            this.PWMButton.Text = "PWM";
            this.PWMButton.UseVisualStyleBackColor = true;
            this.PWMButton.Click += new System.EventHandler(this.PWMButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 463);
            this.Controls.Add(this.PWMButton);
            this.Controls.Add(this.AnalogSelect);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.PortSelectLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.I2CSelect);
            this.Controls.Add(this.DigitalRead);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "Logic Analyzer Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DigitalRead;
        private System.Windows.Forms.Button I2CSelect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox PortSelectLabel;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button AnalogSelect;
        private System.Windows.Forms.Button PWMButton;
    }
}

