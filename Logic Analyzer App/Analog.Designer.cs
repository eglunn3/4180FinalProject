namespace Logic_Analyzer_App
{
    partial class Analog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analog));
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.StopButton = new System.Windows.Forms.Button();
            this.Pin16_Select = new System.Windows.Forms.CheckBox();
            this.Pin17_Select = new System.Windows.Forms.CheckBox();
            this.Pin18_Select = new System.Windows.Forms.CheckBox();
            this.Pin19_Select = new System.Windows.Forms.CheckBox();
            this.Pin20_Select = new System.Windows.Forms.CheckBox();
            this.Pin16_Value = new System.Windows.Forms.TextBox();
            this.Pin17_Value = new System.Windows.Forms.TextBox();
            this.Pin18_Value = new System.Windows.Forms.TextBox();
            this.Pin19_Value = new System.Windows.Forms.TextBox();
            this.Pin20_Value = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pin16_12 = new System.Windows.Forms.TextBox();
            this.Pin16_09 = new System.Windows.Forms.TextBox();
            this.Pin16_06 = new System.Windows.Forms.TextBox();
            this.Pin16_15 = new System.Windows.Forms.TextBox();
            this.Pin16_03 = new System.Windows.Forms.TextBox();
            this.Pin16_18 = new System.Windows.Forms.TextBox();
            this.Pin16_21 = new System.Windows.Forms.TextBox();
            this.Pin16_33 = new System.Windows.Forms.TextBox();
            this.Pin16_24 = new System.Windows.Forms.TextBox();
            this.Pin16_30 = new System.Windows.Forms.TextBox();
            this.Pin16_27 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pin17_12 = new System.Windows.Forms.TextBox();
            this.Pin17_09 = new System.Windows.Forms.TextBox();
            this.Pin17_06 = new System.Windows.Forms.TextBox();
            this.Pin17_15 = new System.Windows.Forms.TextBox();
            this.Pin17_03 = new System.Windows.Forms.TextBox();
            this.Pin17_18 = new System.Windows.Forms.TextBox();
            this.Pin17_21 = new System.Windows.Forms.TextBox();
            this.Pin17_33 = new System.Windows.Forms.TextBox();
            this.Pin17_24 = new System.Windows.Forms.TextBox();
            this.Pin17_30 = new System.Windows.Forms.TextBox();
            this.Pin17_27 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Pin19_12 = new System.Windows.Forms.TextBox();
            this.Pin19_09 = new System.Windows.Forms.TextBox();
            this.Pin19_06 = new System.Windows.Forms.TextBox();
            this.Pin19_15 = new System.Windows.Forms.TextBox();
            this.Pin19_03 = new System.Windows.Forms.TextBox();
            this.Pin19_18 = new System.Windows.Forms.TextBox();
            this.Pin19_21 = new System.Windows.Forms.TextBox();
            this.Pin19_33 = new System.Windows.Forms.TextBox();
            this.Pin19_24 = new System.Windows.Forms.TextBox();
            this.Pin19_30 = new System.Windows.Forms.TextBox();
            this.Pin19_27 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Pin18_12 = new System.Windows.Forms.TextBox();
            this.Pin18_09 = new System.Windows.Forms.TextBox();
            this.Pin18_06 = new System.Windows.Forms.TextBox();
            this.Pin18_15 = new System.Windows.Forms.TextBox();
            this.Pin18_03 = new System.Windows.Forms.TextBox();
            this.Pin18_18 = new System.Windows.Forms.TextBox();
            this.Pin18_21 = new System.Windows.Forms.TextBox();
            this.Pin18_33 = new System.Windows.Forms.TextBox();
            this.Pin18_24 = new System.Windows.Forms.TextBox();
            this.Pin18_30 = new System.Windows.Forms.TextBox();
            this.Pin18_27 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Pin20_12 = new System.Windows.Forms.TextBox();
            this.Pin20_09 = new System.Windows.Forms.TextBox();
            this.Pin20_06 = new System.Windows.Forms.TextBox();
            this.Pin20_15 = new System.Windows.Forms.TextBox();
            this.Pin20_03 = new System.Windows.Forms.TextBox();
            this.Pin20_18 = new System.Windows.Forms.TextBox();
            this.Pin20_21 = new System.Windows.Forms.TextBox();
            this.Pin20_33 = new System.Windows.Forms.TextBox();
            this.Pin20_24 = new System.Windows.Forms.TextBox();
            this.Pin20_30 = new System.Windows.Forms.TextBox();
            this.Pin20_27 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Port
            // 
            this.Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.CerealKiller);
            // 
            // StartButton
            // 
            this.StartButton.ImageIndex = 0;
            this.StartButton.ImageList = this.imageList1;
            this.StartButton.Location = new System.Drawing.Point(422, 783);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(134, 102);
            this.StartButton.TabIndex = 13;
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
            this.StopButton.Location = new System.Drawing.Point(562, 783);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(134, 102);
            this.StopButton.TabIndex = 14;
            this.StopButton.Text = "Stop";
            this.StopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Pin16_Select
            // 
            this.Pin16_Select.AutoSize = true;
            this.Pin16_Select.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pin16_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_Select.Location = new System.Drawing.Point(63, 675);
            this.Pin16_Select.Name = "Pin16_Select";
            this.Pin16_Select.Size = new System.Drawing.Size(137, 83);
            this.Pin16_Select.TabIndex = 15;
            this.Pin16_Select.Text = "Pin 16";
            this.Pin16_Select.UseVisualStyleBackColor = true;
            // 
            // Pin17_Select
            // 
            this.Pin17_Select.AutoSize = true;
            this.Pin17_Select.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pin17_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_Select.Location = new System.Drawing.Point(276, 675);
            this.Pin17_Select.Name = "Pin17_Select";
            this.Pin17_Select.Size = new System.Drawing.Size(137, 83);
            this.Pin17_Select.TabIndex = 16;
            this.Pin17_Select.Text = "Pin 17";
            this.Pin17_Select.UseVisualStyleBackColor = true;
            // 
            // Pin18_Select
            // 
            this.Pin18_Select.AutoSize = true;
            this.Pin18_Select.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pin18_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_Select.Location = new System.Drawing.Point(489, 675);
            this.Pin18_Select.Name = "Pin18_Select";
            this.Pin18_Select.Size = new System.Drawing.Size(137, 83);
            this.Pin18_Select.TabIndex = 17;
            this.Pin18_Select.Text = "Pin 18";
            this.Pin18_Select.UseVisualStyleBackColor = true;
            // 
            // Pin19_Select
            // 
            this.Pin19_Select.AutoSize = true;
            this.Pin19_Select.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pin19_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_Select.Location = new System.Drawing.Point(702, 675);
            this.Pin19_Select.Name = "Pin19_Select";
            this.Pin19_Select.Size = new System.Drawing.Size(137, 83);
            this.Pin19_Select.TabIndex = 18;
            this.Pin19_Select.Text = "Pin 19";
            this.Pin19_Select.UseVisualStyleBackColor = true;
            // 
            // Pin20_Select
            // 
            this.Pin20_Select.AutoSize = true;
            this.Pin20_Select.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pin20_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_Select.Location = new System.Drawing.Point(915, 675);
            this.Pin20_Select.Name = "Pin20_Select";
            this.Pin20_Select.Size = new System.Drawing.Size(137, 83);
            this.Pin20_Select.TabIndex = 19;
            this.Pin20_Select.Text = "Pin 20";
            this.Pin20_Select.UseVisualStyleBackColor = true;
            // 
            // Pin16_Value
            // 
            this.Pin16_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_Value.Location = new System.Drawing.Point(84, 598);
            this.Pin16_Value.Name = "Pin16_Value";
            this.Pin16_Value.Size = new System.Drawing.Size(90, 49);
            this.Pin16_Value.TabIndex = 21;
            // 
            // Pin17_Value
            // 
            this.Pin17_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_Value.Location = new System.Drawing.Point(297, 598);
            this.Pin17_Value.Name = "Pin17_Value";
            this.Pin17_Value.Size = new System.Drawing.Size(90, 49);
            this.Pin17_Value.TabIndex = 37;
            // 
            // Pin18_Value
            // 
            this.Pin18_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_Value.Location = new System.Drawing.Point(511, 598);
            this.Pin18_Value.Name = "Pin18_Value";
            this.Pin18_Value.Size = new System.Drawing.Size(90, 49);
            this.Pin18_Value.TabIndex = 38;
            // 
            // Pin19_Value
            // 
            this.Pin19_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_Value.Location = new System.Drawing.Point(725, 598);
            this.Pin19_Value.Name = "Pin19_Value";
            this.Pin19_Value.Size = new System.Drawing.Size(90, 49);
            this.Pin19_Value.TabIndex = 39;
            // 
            // Pin20_Value
            // 
            this.Pin20_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_Value.Location = new System.Drawing.Point(938, 598);
            this.Pin20_Value.Name = "Pin20_Value";
            this.Pin20_Value.Size = new System.Drawing.Size(90, 49);
            this.Pin20_Value.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Pin16_12);
            this.groupBox2.Controls.Add(this.Pin16_09);
            this.groupBox2.Controls.Add(this.Pin16_06);
            this.groupBox2.Controls.Add(this.Pin16_15);
            this.groupBox2.Controls.Add(this.Pin16_03);
            this.groupBox2.Controls.Add(this.Pin16_18);
            this.groupBox2.Controls.Add(this.Pin16_21);
            this.groupBox2.Controls.Add(this.Pin16_33);
            this.groupBox2.Controls.Add(this.Pin16_24);
            this.groupBox2.Controls.Add(this.Pin16_30);
            this.groupBox2.Controls.Add(this.Pin16_27);
            this.groupBox2.Location = new System.Drawing.Point(63, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 543);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // Pin16_12
            // 
            this.Pin16_12.BackColor = System.Drawing.SystemColors.Control;
            this.Pin16_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_12.Location = new System.Drawing.Point(33, 343);
            this.Pin16_12.Name = "Pin16_12";
            this.Pin16_12.Size = new System.Drawing.Size(68, 38);
            this.Pin16_12.TabIndex = 4;
            // 
            // Pin16_09
            // 
            this.Pin16_09.BackColor = System.Drawing.SystemColors.Control;
            this.Pin16_09.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_09.Location = new System.Drawing.Point(33, 387);
            this.Pin16_09.Name = "Pin16_09";
            this.Pin16_09.Size = new System.Drawing.Size(68, 38);
            this.Pin16_09.TabIndex = 3;
            // 
            // Pin16_06
            // 
            this.Pin16_06.BackColor = System.Drawing.SystemColors.Control;
            this.Pin16_06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_06.Location = new System.Drawing.Point(33, 431);
            this.Pin16_06.Name = "Pin16_06";
            this.Pin16_06.Size = new System.Drawing.Size(68, 38);
            this.Pin16_06.TabIndex = 2;
            // 
            // Pin16_15
            // 
            this.Pin16_15.BackColor = System.Drawing.SystemColors.Control;
            this.Pin16_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_15.Location = new System.Drawing.Point(33, 299);
            this.Pin16_15.Name = "Pin16_15";
            this.Pin16_15.Size = new System.Drawing.Size(68, 38);
            this.Pin16_15.TabIndex = 5;
            // 
            // Pin16_03
            // 
            this.Pin16_03.BackColor = System.Drawing.SystemColors.Control;
            this.Pin16_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_03.Location = new System.Drawing.Point(33, 475);
            this.Pin16_03.Name = "Pin16_03";
            this.Pin16_03.Size = new System.Drawing.Size(68, 38);
            this.Pin16_03.TabIndex = 1;
            // 
            // Pin16_18
            // 
            this.Pin16_18.BackColor = System.Drawing.SystemColors.Control;
            this.Pin16_18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_18.Location = new System.Drawing.Point(33, 255);
            this.Pin16_18.Name = "Pin16_18";
            this.Pin16_18.Size = new System.Drawing.Size(68, 38);
            this.Pin16_18.TabIndex = 6;
            // 
            // Pin16_21
            // 
            this.Pin16_21.BackColor = System.Drawing.SystemColors.Control;
            this.Pin16_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_21.Location = new System.Drawing.Point(33, 211);
            this.Pin16_21.Name = "Pin16_21";
            this.Pin16_21.Size = new System.Drawing.Size(68, 38);
            this.Pin16_21.TabIndex = 7;
            // 
            // Pin16_33
            // 
            this.Pin16_33.BackColor = System.Drawing.SystemColors.Control;
            this.Pin16_33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_33.Location = new System.Drawing.Point(33, 35);
            this.Pin16_33.Name = "Pin16_33";
            this.Pin16_33.Size = new System.Drawing.Size(68, 38);
            this.Pin16_33.TabIndex = 11;
            // 
            // Pin16_24
            // 
            this.Pin16_24.BackColor = System.Drawing.SystemColors.Control;
            this.Pin16_24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_24.Location = new System.Drawing.Point(33, 167);
            this.Pin16_24.Name = "Pin16_24";
            this.Pin16_24.Size = new System.Drawing.Size(68, 38);
            this.Pin16_24.TabIndex = 8;
            // 
            // Pin16_30
            // 
            this.Pin16_30.BackColor = System.Drawing.SystemColors.Control;
            this.Pin16_30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_30.Location = new System.Drawing.Point(33, 79);
            this.Pin16_30.Name = "Pin16_30";
            this.Pin16_30.Size = new System.Drawing.Size(68, 38);
            this.Pin16_30.TabIndex = 10;
            // 
            // Pin16_27
            // 
            this.Pin16_27.BackColor = System.Drawing.SystemColors.Control;
            this.Pin16_27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin16_27.Location = new System.Drawing.Point(33, 123);
            this.Pin16_27.Name = "Pin16_27";
            this.Pin16_27.Size = new System.Drawing.Size(68, 38);
            this.Pin16_27.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pin17_12);
            this.groupBox1.Controls.Add(this.Pin17_09);
            this.groupBox1.Controls.Add(this.Pin17_06);
            this.groupBox1.Controls.Add(this.Pin17_15);
            this.groupBox1.Controls.Add(this.Pin17_03);
            this.groupBox1.Controls.Add(this.Pin17_18);
            this.groupBox1.Controls.Add(this.Pin17_21);
            this.groupBox1.Controls.Add(this.Pin17_33);
            this.groupBox1.Controls.Add(this.Pin17_24);
            this.groupBox1.Controls.Add(this.Pin17_30);
            this.groupBox1.Controls.Add(this.Pin17_27);
            this.groupBox1.Location = new System.Drawing.Point(276, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 543);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // Pin17_12
            // 
            this.Pin17_12.BackColor = System.Drawing.SystemColors.Control;
            this.Pin17_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_12.Location = new System.Drawing.Point(33, 343);
            this.Pin17_12.Name = "Pin17_12";
            this.Pin17_12.Size = new System.Drawing.Size(68, 38);
            this.Pin17_12.TabIndex = 4;
            // 
            // Pin17_09
            // 
            this.Pin17_09.BackColor = System.Drawing.SystemColors.Control;
            this.Pin17_09.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_09.Location = new System.Drawing.Point(33, 387);
            this.Pin17_09.Name = "Pin17_09";
            this.Pin17_09.Size = new System.Drawing.Size(68, 38);
            this.Pin17_09.TabIndex = 3;
            // 
            // Pin17_06
            // 
            this.Pin17_06.BackColor = System.Drawing.SystemColors.Control;
            this.Pin17_06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_06.Location = new System.Drawing.Point(33, 431);
            this.Pin17_06.Name = "Pin17_06";
            this.Pin17_06.Size = new System.Drawing.Size(68, 38);
            this.Pin17_06.TabIndex = 2;
            // 
            // Pin17_15
            // 
            this.Pin17_15.BackColor = System.Drawing.SystemColors.Control;
            this.Pin17_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_15.Location = new System.Drawing.Point(33, 299);
            this.Pin17_15.Name = "Pin17_15";
            this.Pin17_15.Size = new System.Drawing.Size(68, 38);
            this.Pin17_15.TabIndex = 5;
            // 
            // Pin17_03
            // 
            this.Pin17_03.BackColor = System.Drawing.SystemColors.Control;
            this.Pin17_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_03.Location = new System.Drawing.Point(33, 475);
            this.Pin17_03.Name = "Pin17_03";
            this.Pin17_03.Size = new System.Drawing.Size(68, 38);
            this.Pin17_03.TabIndex = 1;
            // 
            // Pin17_18
            // 
            this.Pin17_18.BackColor = System.Drawing.SystemColors.Control;
            this.Pin17_18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_18.Location = new System.Drawing.Point(33, 255);
            this.Pin17_18.Name = "Pin17_18";
            this.Pin17_18.Size = new System.Drawing.Size(68, 38);
            this.Pin17_18.TabIndex = 6;
            // 
            // Pin17_21
            // 
            this.Pin17_21.BackColor = System.Drawing.SystemColors.Control;
            this.Pin17_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_21.Location = new System.Drawing.Point(33, 211);
            this.Pin17_21.Name = "Pin17_21";
            this.Pin17_21.Size = new System.Drawing.Size(68, 38);
            this.Pin17_21.TabIndex = 7;
            // 
            // Pin17_33
            // 
            this.Pin17_33.BackColor = System.Drawing.SystemColors.Control;
            this.Pin17_33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_33.Location = new System.Drawing.Point(33, 35);
            this.Pin17_33.Name = "Pin17_33";
            this.Pin17_33.Size = new System.Drawing.Size(68, 38);
            this.Pin17_33.TabIndex = 11;
            // 
            // Pin17_24
            // 
            this.Pin17_24.BackColor = System.Drawing.SystemColors.Control;
            this.Pin17_24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_24.Location = new System.Drawing.Point(33, 167);
            this.Pin17_24.Name = "Pin17_24";
            this.Pin17_24.Size = new System.Drawing.Size(68, 38);
            this.Pin17_24.TabIndex = 8;
            // 
            // Pin17_30
            // 
            this.Pin17_30.BackColor = System.Drawing.SystemColors.Control;
            this.Pin17_30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_30.Location = new System.Drawing.Point(33, 79);
            this.Pin17_30.Name = "Pin17_30";
            this.Pin17_30.Size = new System.Drawing.Size(68, 38);
            this.Pin17_30.TabIndex = 10;
            // 
            // Pin17_27
            // 
            this.Pin17_27.BackColor = System.Drawing.SystemColors.Control;
            this.Pin17_27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin17_27.Location = new System.Drawing.Point(33, 123);
            this.Pin17_27.Name = "Pin17_27";
            this.Pin17_27.Size = new System.Drawing.Size(68, 38);
            this.Pin17_27.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Pin19_12);
            this.groupBox3.Controls.Add(this.Pin19_09);
            this.groupBox3.Controls.Add(this.Pin19_06);
            this.groupBox3.Controls.Add(this.Pin19_15);
            this.groupBox3.Controls.Add(this.Pin19_03);
            this.groupBox3.Controls.Add(this.Pin19_18);
            this.groupBox3.Controls.Add(this.Pin19_21);
            this.groupBox3.Controls.Add(this.Pin19_33);
            this.groupBox3.Controls.Add(this.Pin19_24);
            this.groupBox3.Controls.Add(this.Pin19_30);
            this.groupBox3.Controls.Add(this.Pin19_27);
            this.groupBox3.Location = new System.Drawing.Point(702, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 543);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // Pin19_12
            // 
            this.Pin19_12.BackColor = System.Drawing.SystemColors.Control;
            this.Pin19_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_12.Location = new System.Drawing.Point(33, 343);
            this.Pin19_12.Name = "Pin19_12";
            this.Pin19_12.Size = new System.Drawing.Size(68, 38);
            this.Pin19_12.TabIndex = 4;
            // 
            // Pin19_09
            // 
            this.Pin19_09.BackColor = System.Drawing.SystemColors.Control;
            this.Pin19_09.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_09.Location = new System.Drawing.Point(33, 387);
            this.Pin19_09.Name = "Pin19_09";
            this.Pin19_09.Size = new System.Drawing.Size(68, 38);
            this.Pin19_09.TabIndex = 3;
            // 
            // Pin19_06
            // 
            this.Pin19_06.BackColor = System.Drawing.SystemColors.Control;
            this.Pin19_06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_06.Location = new System.Drawing.Point(33, 431);
            this.Pin19_06.Name = "Pin19_06";
            this.Pin19_06.Size = new System.Drawing.Size(68, 38);
            this.Pin19_06.TabIndex = 2;
            // 
            // Pin19_15
            // 
            this.Pin19_15.BackColor = System.Drawing.SystemColors.Control;
            this.Pin19_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_15.Location = new System.Drawing.Point(33, 299);
            this.Pin19_15.Name = "Pin19_15";
            this.Pin19_15.Size = new System.Drawing.Size(68, 38);
            this.Pin19_15.TabIndex = 5;
            // 
            // Pin19_03
            // 
            this.Pin19_03.BackColor = System.Drawing.SystemColors.Control;
            this.Pin19_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_03.Location = new System.Drawing.Point(33, 475);
            this.Pin19_03.Name = "Pin19_03";
            this.Pin19_03.Size = new System.Drawing.Size(68, 38);
            this.Pin19_03.TabIndex = 1;
            // 
            // Pin19_18
            // 
            this.Pin19_18.BackColor = System.Drawing.SystemColors.Control;
            this.Pin19_18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_18.Location = new System.Drawing.Point(33, 255);
            this.Pin19_18.Name = "Pin19_18";
            this.Pin19_18.Size = new System.Drawing.Size(68, 38);
            this.Pin19_18.TabIndex = 6;
            // 
            // Pin19_21
            // 
            this.Pin19_21.BackColor = System.Drawing.SystemColors.Control;
            this.Pin19_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_21.Location = new System.Drawing.Point(33, 211);
            this.Pin19_21.Name = "Pin19_21";
            this.Pin19_21.Size = new System.Drawing.Size(68, 38);
            this.Pin19_21.TabIndex = 7;
            // 
            // Pin19_33
            // 
            this.Pin19_33.BackColor = System.Drawing.SystemColors.Control;
            this.Pin19_33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_33.Location = new System.Drawing.Point(33, 35);
            this.Pin19_33.Name = "Pin19_33";
            this.Pin19_33.Size = new System.Drawing.Size(68, 38);
            this.Pin19_33.TabIndex = 11;
            // 
            // Pin19_24
            // 
            this.Pin19_24.BackColor = System.Drawing.SystemColors.Control;
            this.Pin19_24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_24.Location = new System.Drawing.Point(33, 167);
            this.Pin19_24.Name = "Pin19_24";
            this.Pin19_24.Size = new System.Drawing.Size(68, 38);
            this.Pin19_24.TabIndex = 8;
            // 
            // Pin19_30
            // 
            this.Pin19_30.BackColor = System.Drawing.SystemColors.Control;
            this.Pin19_30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_30.Location = new System.Drawing.Point(33, 79);
            this.Pin19_30.Name = "Pin19_30";
            this.Pin19_30.Size = new System.Drawing.Size(68, 38);
            this.Pin19_30.TabIndex = 10;
            // 
            // Pin19_27
            // 
            this.Pin19_27.BackColor = System.Drawing.SystemColors.Control;
            this.Pin19_27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin19_27.Location = new System.Drawing.Point(33, 123);
            this.Pin19_27.Name = "Pin19_27";
            this.Pin19_27.Size = new System.Drawing.Size(68, 38);
            this.Pin19_27.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Pin18_12);
            this.groupBox4.Controls.Add(this.Pin18_09);
            this.groupBox4.Controls.Add(this.Pin18_06);
            this.groupBox4.Controls.Add(this.Pin18_15);
            this.groupBox4.Controls.Add(this.Pin18_03);
            this.groupBox4.Controls.Add(this.Pin18_18);
            this.groupBox4.Controls.Add(this.Pin18_21);
            this.groupBox4.Controls.Add(this.Pin18_33);
            this.groupBox4.Controls.Add(this.Pin18_24);
            this.groupBox4.Controls.Add(this.Pin18_30);
            this.groupBox4.Controls.Add(this.Pin18_27);
            this.groupBox4.Location = new System.Drawing.Point(489, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(137, 543);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            // 
            // Pin18_12
            // 
            this.Pin18_12.BackColor = System.Drawing.SystemColors.Control;
            this.Pin18_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_12.Location = new System.Drawing.Point(33, 343);
            this.Pin18_12.Name = "Pin18_12";
            this.Pin18_12.Size = new System.Drawing.Size(68, 38);
            this.Pin18_12.TabIndex = 4;
            // 
            // Pin18_09
            // 
            this.Pin18_09.BackColor = System.Drawing.SystemColors.Control;
            this.Pin18_09.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_09.Location = new System.Drawing.Point(33, 387);
            this.Pin18_09.Name = "Pin18_09";
            this.Pin18_09.Size = new System.Drawing.Size(68, 38);
            this.Pin18_09.TabIndex = 3;
            // 
            // Pin18_06
            // 
            this.Pin18_06.BackColor = System.Drawing.SystemColors.Control;
            this.Pin18_06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_06.Location = new System.Drawing.Point(33, 431);
            this.Pin18_06.Name = "Pin18_06";
            this.Pin18_06.Size = new System.Drawing.Size(68, 38);
            this.Pin18_06.TabIndex = 2;
            // 
            // Pin18_15
            // 
            this.Pin18_15.BackColor = System.Drawing.SystemColors.Control;
            this.Pin18_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_15.Location = new System.Drawing.Point(33, 299);
            this.Pin18_15.Name = "Pin18_15";
            this.Pin18_15.Size = new System.Drawing.Size(68, 38);
            this.Pin18_15.TabIndex = 5;
            // 
            // Pin18_03
            // 
            this.Pin18_03.BackColor = System.Drawing.SystemColors.Control;
            this.Pin18_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_03.Location = new System.Drawing.Point(33, 475);
            this.Pin18_03.Name = "Pin18_03";
            this.Pin18_03.Size = new System.Drawing.Size(68, 38);
            this.Pin18_03.TabIndex = 1;
            // 
            // Pin18_18
            // 
            this.Pin18_18.BackColor = System.Drawing.SystemColors.Control;
            this.Pin18_18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_18.Location = new System.Drawing.Point(33, 255);
            this.Pin18_18.Name = "Pin18_18";
            this.Pin18_18.Size = new System.Drawing.Size(68, 38);
            this.Pin18_18.TabIndex = 6;
            // 
            // Pin18_21
            // 
            this.Pin18_21.BackColor = System.Drawing.SystemColors.Control;
            this.Pin18_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_21.Location = new System.Drawing.Point(33, 211);
            this.Pin18_21.Name = "Pin18_21";
            this.Pin18_21.Size = new System.Drawing.Size(68, 38);
            this.Pin18_21.TabIndex = 7;
            // 
            // Pin18_33
            // 
            this.Pin18_33.BackColor = System.Drawing.SystemColors.Control;
            this.Pin18_33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_33.Location = new System.Drawing.Point(33, 35);
            this.Pin18_33.Name = "Pin18_33";
            this.Pin18_33.Size = new System.Drawing.Size(68, 38);
            this.Pin18_33.TabIndex = 11;
            // 
            // Pin18_24
            // 
            this.Pin18_24.BackColor = System.Drawing.SystemColors.Control;
            this.Pin18_24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_24.Location = new System.Drawing.Point(33, 167);
            this.Pin18_24.Name = "Pin18_24";
            this.Pin18_24.Size = new System.Drawing.Size(68, 38);
            this.Pin18_24.TabIndex = 8;
            // 
            // Pin18_30
            // 
            this.Pin18_30.BackColor = System.Drawing.SystemColors.Control;
            this.Pin18_30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_30.Location = new System.Drawing.Point(33, 79);
            this.Pin18_30.Name = "Pin18_30";
            this.Pin18_30.Size = new System.Drawing.Size(68, 38);
            this.Pin18_30.TabIndex = 10;
            // 
            // Pin18_27
            // 
            this.Pin18_27.BackColor = System.Drawing.SystemColors.Control;
            this.Pin18_27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin18_27.Location = new System.Drawing.Point(33, 123);
            this.Pin18_27.Name = "Pin18_27";
            this.Pin18_27.Size = new System.Drawing.Size(68, 38);
            this.Pin18_27.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Pin20_12);
            this.groupBox5.Controls.Add(this.Pin20_09);
            this.groupBox5.Controls.Add(this.Pin20_06);
            this.groupBox5.Controls.Add(this.Pin20_15);
            this.groupBox5.Controls.Add(this.Pin20_03);
            this.groupBox5.Controls.Add(this.Pin20_18);
            this.groupBox5.Controls.Add(this.Pin20_21);
            this.groupBox5.Controls.Add(this.Pin20_33);
            this.groupBox5.Controls.Add(this.Pin20_24);
            this.groupBox5.Controls.Add(this.Pin20_30);
            this.groupBox5.Controls.Add(this.Pin20_27);
            this.groupBox5.Location = new System.Drawing.Point(915, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(137, 543);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            // 
            // Pin20_12
            // 
            this.Pin20_12.BackColor = System.Drawing.SystemColors.Control;
            this.Pin20_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_12.Location = new System.Drawing.Point(33, 343);
            this.Pin20_12.Name = "Pin20_12";
            this.Pin20_12.Size = new System.Drawing.Size(68, 38);
            this.Pin20_12.TabIndex = 4;
            // 
            // Pin20_09
            // 
            this.Pin20_09.BackColor = System.Drawing.SystemColors.Control;
            this.Pin20_09.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_09.Location = new System.Drawing.Point(33, 387);
            this.Pin20_09.Name = "Pin20_09";
            this.Pin20_09.Size = new System.Drawing.Size(68, 38);
            this.Pin20_09.TabIndex = 3;
            // 
            // Pin20_06
            // 
            this.Pin20_06.BackColor = System.Drawing.SystemColors.Control;
            this.Pin20_06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_06.Location = new System.Drawing.Point(33, 431);
            this.Pin20_06.Name = "Pin20_06";
            this.Pin20_06.Size = new System.Drawing.Size(68, 38);
            this.Pin20_06.TabIndex = 2;
            // 
            // Pin20_15
            // 
            this.Pin20_15.BackColor = System.Drawing.SystemColors.Control;
            this.Pin20_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_15.Location = new System.Drawing.Point(33, 299);
            this.Pin20_15.Name = "Pin20_15";
            this.Pin20_15.Size = new System.Drawing.Size(68, 38);
            this.Pin20_15.TabIndex = 5;
            // 
            // Pin20_03
            // 
            this.Pin20_03.BackColor = System.Drawing.SystemColors.Control;
            this.Pin20_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_03.Location = new System.Drawing.Point(33, 475);
            this.Pin20_03.Name = "Pin20_03";
            this.Pin20_03.Size = new System.Drawing.Size(68, 38);
            this.Pin20_03.TabIndex = 1;
            // 
            // Pin20_18
            // 
            this.Pin20_18.BackColor = System.Drawing.SystemColors.Control;
            this.Pin20_18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_18.Location = new System.Drawing.Point(33, 255);
            this.Pin20_18.Name = "Pin20_18";
            this.Pin20_18.Size = new System.Drawing.Size(68, 38);
            this.Pin20_18.TabIndex = 6;
            // 
            // Pin20_21
            // 
            this.Pin20_21.BackColor = System.Drawing.SystemColors.Control;
            this.Pin20_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_21.Location = new System.Drawing.Point(33, 211);
            this.Pin20_21.Name = "Pin20_21";
            this.Pin20_21.Size = new System.Drawing.Size(68, 38);
            this.Pin20_21.TabIndex = 7;
            // 
            // Pin20_33
            // 
            this.Pin20_33.BackColor = System.Drawing.SystemColors.Control;
            this.Pin20_33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_33.Location = new System.Drawing.Point(33, 35);
            this.Pin20_33.Name = "Pin20_33";
            this.Pin20_33.Size = new System.Drawing.Size(68, 38);
            this.Pin20_33.TabIndex = 11;
            // 
            // Pin20_24
            // 
            this.Pin20_24.BackColor = System.Drawing.SystemColors.Control;
            this.Pin20_24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_24.Location = new System.Drawing.Point(33, 167);
            this.Pin20_24.Name = "Pin20_24";
            this.Pin20_24.Size = new System.Drawing.Size(68, 38);
            this.Pin20_24.TabIndex = 8;
            // 
            // Pin20_30
            // 
            this.Pin20_30.BackColor = System.Drawing.SystemColors.Control;
            this.Pin20_30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_30.Location = new System.Drawing.Point(33, 79);
            this.Pin20_30.Name = "Pin20_30";
            this.Pin20_30.Size = new System.Drawing.Size(68, 38);
            this.Pin20_30.TabIndex = 10;
            // 
            // Pin20_27
            // 
            this.Pin20_27.BackColor = System.Drawing.SystemColors.Control;
            this.Pin20_27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin20_27.Location = new System.Drawing.Point(33, 123);
            this.Pin20_27.Name = "Pin20_27";
            this.Pin20_27.Size = new System.Drawing.Size(68, 38);
            this.Pin20_27.TabIndex = 9;
            // 
            // Analog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1120, 940);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Pin20_Value);
            this.Controls.Add(this.Pin19_Value);
            this.Controls.Add(this.Pin18_Value);
            this.Controls.Add(this.Pin17_Value);
            this.Controls.Add(this.Pin16_Value);
            this.Controls.Add(this.Pin20_Select);
            this.Controls.Add(this.Pin19_Select);
            this.Controls.Add(this.Pin18_Select);
            this.Controls.Add(this.Pin17_Select);
            this.Controls.Add(this.Pin16_Select);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Analog";
            this.Text = "Analog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Analog_FormClosing);
            this.Load += new System.EventHandler(this.Analog_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort Port;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox Pin16_Select;
        private System.Windows.Forms.CheckBox Pin17_Select;
        private System.Windows.Forms.CheckBox Pin18_Select;
        private System.Windows.Forms.CheckBox Pin19_Select;
        private System.Windows.Forms.CheckBox Pin20_Select;
        private System.Windows.Forms.TextBox Pin16_Value;
        private System.Windows.Forms.TextBox Pin17_Value;
        private System.Windows.Forms.TextBox Pin18_Value;
        private System.Windows.Forms.TextBox Pin19_Value;
        private System.Windows.Forms.TextBox Pin20_Value;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Pin16_33;
        private System.Windows.Forms.TextBox Pin16_30;
        private System.Windows.Forms.TextBox Pin16_27;
        private System.Windows.Forms.TextBox Pin16_24;
        private System.Windows.Forms.TextBox Pin16_21;
        private System.Windows.Forms.TextBox Pin16_18;
        private System.Windows.Forms.TextBox Pin16_15;
        private System.Windows.Forms.TextBox Pin16_12;
        private System.Windows.Forms.TextBox Pin16_09;
        private System.Windows.Forms.TextBox Pin16_06;
        private System.Windows.Forms.TextBox Pin16_03;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Pin17_12;
        private System.Windows.Forms.TextBox Pin17_09;
        private System.Windows.Forms.TextBox Pin17_06;
        private System.Windows.Forms.TextBox Pin17_15;
        private System.Windows.Forms.TextBox Pin17_03;
        private System.Windows.Forms.TextBox Pin17_18;
        private System.Windows.Forms.TextBox Pin17_21;
        private System.Windows.Forms.TextBox Pin17_33;
        private System.Windows.Forms.TextBox Pin17_24;
        private System.Windows.Forms.TextBox Pin17_30;
        private System.Windows.Forms.TextBox Pin17_27;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Pin19_12;
        private System.Windows.Forms.TextBox Pin19_09;
        private System.Windows.Forms.TextBox Pin19_06;
        private System.Windows.Forms.TextBox Pin19_15;
        private System.Windows.Forms.TextBox Pin19_03;
        private System.Windows.Forms.TextBox Pin19_18;
        private System.Windows.Forms.TextBox Pin19_21;
        private System.Windows.Forms.TextBox Pin19_33;
        private System.Windows.Forms.TextBox Pin19_24;
        private System.Windows.Forms.TextBox Pin19_30;
        private System.Windows.Forms.TextBox Pin19_27;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Pin18_12;
        private System.Windows.Forms.TextBox Pin18_09;
        private System.Windows.Forms.TextBox Pin18_06;
        private System.Windows.Forms.TextBox Pin18_15;
        private System.Windows.Forms.TextBox Pin18_03;
        private System.Windows.Forms.TextBox Pin18_18;
        private System.Windows.Forms.TextBox Pin18_21;
        private System.Windows.Forms.TextBox Pin18_33;
        private System.Windows.Forms.TextBox Pin18_24;
        private System.Windows.Forms.TextBox Pin18_30;
        private System.Windows.Forms.TextBox Pin18_27;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Pin20_12;
        private System.Windows.Forms.TextBox Pin20_09;
        private System.Windows.Forms.TextBox Pin20_06;
        private System.Windows.Forms.TextBox Pin20_15;
        private System.Windows.Forms.TextBox Pin20_03;
        private System.Windows.Forms.TextBox Pin20_18;
        private System.Windows.Forms.TextBox Pin20_21;
        private System.Windows.Forms.TextBox Pin20_33;
        private System.Windows.Forms.TextBox Pin20_24;
        private System.Windows.Forms.TextBox Pin20_30;
        private System.Windows.Forms.TextBox Pin20_27;
    }
}