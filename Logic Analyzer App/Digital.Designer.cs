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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Digital));
            this.PinInfo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Pin1Out = new System.Windows.Forms.TextBox();
            this.Pin2Out = new System.Windows.Forms.TextBox();
            this.Pin3Out = new System.Windows.Forms.TextBox();
            this.Pin4Out = new System.Windows.Forms.TextBox();
            this.Pin5Out = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.StopButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Pin21_Select = new System.Windows.Forms.CheckBox();
            this.Pin24_Select = new System.Windows.Forms.CheckBox();
            this.Pin23_Select = new System.Windows.Forms.CheckBox();
            this.Pin22_Select = new System.Windows.Forms.CheckBox();
            this.Pin25_Select = new System.Windows.Forms.CheckBox();
            this.PinName1 = new System.Windows.Forms.TextBox();
            this.PinName2 = new System.Windows.Forms.TextBox();
            this.PinName3 = new System.Windows.Forms.TextBox();
            this.PinName4 = new System.Windows.Forms.TextBox();
            this.PinName5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PinInfo
            // 
            this.PinInfo.Enabled = false;
            this.PinInfo.Location = new System.Drawing.Point(139, 64);
            this.PinInfo.Margin = new System.Windows.Forms.Padding(6);
            this.PinInfo.Name = "PinInfo";
            this.PinInfo.ReadOnly = true;
            this.PinInfo.Size = new System.Drawing.Size(231, 38);
            this.PinInfo.TabIndex = 5;
            this.PinInfo.Text = "Select Pin";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(442, 64);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(106, 38);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Output";
            // 
            // Pin1Out
            // 
            this.Pin1Out.Location = new System.Drawing.Point(441, 141);
            this.Pin1Out.Margin = new System.Windows.Forms.Padding(6);
            this.Pin1Out.Name = "Pin1Out";
            this.Pin1Out.ReadOnly = true;
            this.Pin1Out.Size = new System.Drawing.Size(74, 38);
            this.Pin1Out.TabIndex = 7;
            this.Pin1Out.TextChanged += new System.EventHandler(this.Pin1Out_TextChanged);
            // 
            // Pin2Out
            // 
            this.Pin2Out.Location = new System.Drawing.Point(441, 234);
            this.Pin2Out.Margin = new System.Windows.Forms.Padding(6);
            this.Pin2Out.Name = "Pin2Out";
            this.Pin2Out.ReadOnly = true;
            this.Pin2Out.Size = new System.Drawing.Size(74, 38);
            this.Pin2Out.TabIndex = 8;
            // 
            // Pin3Out
            // 
            this.Pin3Out.Location = new System.Drawing.Point(441, 340);
            this.Pin3Out.Margin = new System.Windows.Forms.Padding(6);
            this.Pin3Out.Name = "Pin3Out";
            this.Pin3Out.ReadOnly = true;
            this.Pin3Out.Size = new System.Drawing.Size(74, 38);
            this.Pin3Out.TabIndex = 9;
            // 
            // Pin4Out
            // 
            this.Pin4Out.Location = new System.Drawing.Point(441, 439);
            this.Pin4Out.Margin = new System.Windows.Forms.Padding(6);
            this.Pin4Out.Name = "Pin4Out";
            this.Pin4Out.ReadOnly = true;
            this.Pin4Out.Size = new System.Drawing.Size(74, 38);
            this.Pin4Out.TabIndex = 10;
            // 
            // Pin5Out
            // 
            this.Pin5Out.Location = new System.Drawing.Point(441, 545);
            this.Pin5Out.Margin = new System.Windows.Forms.Padding(6);
            this.Pin5Out.Name = "Pin5Out";
            this.Pin5Out.ReadOnly = true;
            this.Pin5Out.Size = new System.Drawing.Size(74, 38);
            this.Pin5Out.TabIndex = 11;
            // 
            // StartButton
            // 
            this.StartButton.ImageIndex = 0;
            this.StartButton.ImageList = this.imageList1;
            this.StartButton.Location = new System.Drawing.Point(143, 665);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(134, 102);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Start";
            this.StartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Start-icon.png");
            this.imageList1.Images.SetKeyName(1, "Stop-red-icon.png");
            // 
            // StopButton
            // 
            this.StopButton.ImageIndex = 1;
            this.StopButton.ImageList = this.imageList1;
            this.StopButton.Location = new System.Drawing.Point(293, 665);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(134, 102);
            this.StopButton.TabIndex = 13;
            this.StopButton.Text = "Stop";
            this.StopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.YouveGotCereal);
            // 
            // Pin21_Select
            // 
            this.Pin21_Select.AutoSize = true;
            this.Pin21_Select.Location = new System.Drawing.Point(34, 147);
            this.Pin21_Select.Name = "Pin21_Select";
            this.Pin21_Select.Size = new System.Drawing.Size(34, 33);
            this.Pin21_Select.TabIndex = 14;
            this.Pin21_Select.UseVisualStyleBackColor = true;
            this.Pin21_Select.CheckedChanged += new System.EventHandler(this.Pin21_Select_CheckedChanged);
            // 
            // Pin24_Select
            // 
            this.Pin24_Select.AutoSize = true;
            this.Pin24_Select.Location = new System.Drawing.Point(34, 447);
            this.Pin24_Select.Name = "Pin24_Select";
            this.Pin24_Select.Size = new System.Drawing.Size(34, 33);
            this.Pin24_Select.TabIndex = 15;
            this.Pin24_Select.UseVisualStyleBackColor = true;
            this.Pin24_Select.CheckedChanged += new System.EventHandler(this.Pin24_Select_CheckedChanged);
            // 
            // Pin23_Select
            // 
            this.Pin23_Select.AutoSize = true;
            this.Pin23_Select.Location = new System.Drawing.Point(34, 347);
            this.Pin23_Select.Name = "Pin23_Select";
            this.Pin23_Select.Size = new System.Drawing.Size(34, 33);
            this.Pin23_Select.TabIndex = 16;
            this.Pin23_Select.UseVisualStyleBackColor = true;
            this.Pin23_Select.CheckedChanged += new System.EventHandler(this.Pin23_Select_CheckedChanged);
            // 
            // Pin22_Select
            // 
            this.Pin22_Select.AutoSize = true;
            this.Pin22_Select.Location = new System.Drawing.Point(34, 247);
            this.Pin22_Select.Name = "Pin22_Select";
            this.Pin22_Select.Size = new System.Drawing.Size(34, 33);
            this.Pin22_Select.TabIndex = 17;
            this.Pin22_Select.UseVisualStyleBackColor = true;
            this.Pin22_Select.CheckedChanged += new System.EventHandler(this.Pin22_Select_CheckedChanged);
            // 
            // Pin25_Select
            // 
            this.Pin25_Select.AutoSize = true;
            this.Pin25_Select.Location = new System.Drawing.Point(34, 547);
            this.Pin25_Select.Name = "Pin25_Select";
            this.Pin25_Select.Size = new System.Drawing.Size(34, 33);
            this.Pin25_Select.TabIndex = 18;
            this.Pin25_Select.UseVisualStyleBackColor = true;
            this.Pin25_Select.CheckedChanged += new System.EventHandler(this.Pin25_Select_CheckedChanged);
            // 
            // PinName1
            // 
            this.PinName1.Location = new System.Drawing.Point(139, 146);
            this.PinName1.Name = "PinName1";
            this.PinName1.ReadOnly = true;
            this.PinName1.Size = new System.Drawing.Size(231, 38);
            this.PinName1.TabIndex = 19;
            this.PinName1.Text = "Pin 21";
            // 
            // PinName2
            // 
            this.PinName2.Location = new System.Drawing.Point(139, 245);
            this.PinName2.Name = "PinName2";
            this.PinName2.ReadOnly = true;
            this.PinName2.Size = new System.Drawing.Size(231, 38);
            this.PinName2.TabIndex = 20;
            this.PinName2.Text = "Pin 22";
            // 
            // PinName3
            // 
            this.PinName3.Location = new System.Drawing.Point(139, 344);
            this.PinName3.Name = "PinName3";
            this.PinName3.ReadOnly = true;
            this.PinName3.Size = new System.Drawing.Size(231, 38);
            this.PinName3.TabIndex = 21;
            this.PinName3.Text = "Pin 23";
            // 
            // PinName4
            // 
            this.PinName4.Location = new System.Drawing.Point(139, 443);
            this.PinName4.Name = "PinName4";
            this.PinName4.ReadOnly = true;
            this.PinName4.Size = new System.Drawing.Size(231, 38);
            this.PinName4.TabIndex = 22;
            this.PinName4.Text = "Pin 24";
            // 
            // PinName5
            // 
            this.PinName5.Location = new System.Drawing.Point(139, 542);
            this.PinName5.Name = "PinName5";
            this.PinName5.ReadOnly = true;
            this.PinName5.Size = new System.Drawing.Size(231, 38);
            this.PinName5.TabIndex = 23;
            this.PinName5.Text = "Pin 25";
            // 
            // Digital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 799);
            this.Controls.Add(this.PinName5);
            this.Controls.Add(this.PinName4);
            this.Controls.Add(this.PinName3);
            this.Controls.Add(this.PinName2);
            this.Controls.Add(this.PinName1);
            this.Controls.Add(this.Pin25_Select);
            this.Controls.Add(this.Pin22_Select);
            this.Controls.Add(this.Pin23_Select);
            this.Controls.Add(this.Pin24_Select);
            this.Controls.Add(this.Pin21_Select);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Pin5Out);
            this.Controls.Add(this.Pin4Out);
            this.Controls.Add(this.Pin3Out);
            this.Controls.Add(this.Pin2Out);
            this.Controls.Add(this.Pin1Out);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PinInfo);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Digital";
            this.Text = "Digital";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Digital_FormClosing);
            this.Load += new System.EventHandler(this.Digital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PinInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Pin1Out;
        private System.Windows.Forms.TextBox Pin2Out;
        private System.Windows.Forms.TextBox Pin3Out;
        private System.Windows.Forms.TextBox Pin4Out;
        private System.Windows.Forms.TextBox Pin5Out;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox Pin21_Select;
        private System.Windows.Forms.CheckBox Pin24_Select;
        private System.Windows.Forms.CheckBox Pin23_Select;
        private System.Windows.Forms.CheckBox Pin22_Select;
        private System.Windows.Forms.CheckBox Pin25_Select;
        private System.Windows.Forms.TextBox PinName1;
        private System.Windows.Forms.TextBox PinName2;
        private System.Windows.Forms.TextBox PinName3;
        private System.Windows.Forms.TextBox PinName4;
        private System.Windows.Forms.TextBox PinName5;
        private System.Windows.Forms.ImageList imageList1;
    }
}