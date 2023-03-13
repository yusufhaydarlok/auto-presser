namespace auto_presser
{
    partial class AutoClicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.milliseconds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pickedYValue = new System.Windows.Forms.TextBox();
            this.pickedXValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pickLocation = new System.Windows.Forms.Button();
            this.pickedLocation = new System.Windows.Forms.RadioButton();
            this.currentLocation = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.recordPlayback = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.milliseconds);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.seconds);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.minutes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hours);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click Interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Milliseconds";
            // 
            // milliseconds
            // 
            this.milliseconds.Location = new System.Drawing.Point(332, 22);
            this.milliseconds.Name = "milliseconds";
            this.milliseconds.Size = new System.Drawing.Size(50, 23);
            this.milliseconds.TabIndex = 6;
            this.milliseconds.TextChanged += new System.EventHandler(this.milliseconds_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seconds";
            // 
            // seconds
            // 
            this.seconds.Location = new System.Drawing.Point(219, 22);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(50, 23);
            this.seconds.TabIndex = 4;
            this.seconds.TextChanged += new System.EventHandler(this.seconds_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutes";
            // 
            // minutes
            // 
            this.minutes.Location = new System.Drawing.Point(107, 22);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(50, 23);
            this.minutes.TabIndex = 2;
            this.minutes.TextChanged += new System.EventHandler(this.minutes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hours";
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(6, 22);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(50, 23);
            this.hours.TabIndex = 8;
            this.hours.TextChanged += new System.EventHandler(this.hours_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(237, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Click Repeat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(144, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Times";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(95, 27);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(43, 23);
            this.textBox9.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Repeat until stoped";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Repeat";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pickedYValue);
            this.groupBox3.Controls.Add(this.pickedXValue);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.pickLocation);
            this.groupBox3.Controls.Add(this.pickedLocation);
            this.groupBox3.Controls.Add(this.currentLocation);
            this.groupBox3.Location = new System.Drawing.Point(0, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 93);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cursor Position";
            // 
            // pickedYValue
            // 
            this.pickedYValue.Location = new System.Drawing.Point(387, 39);
            this.pickedYValue.Name = "pickedYValue";
            this.pickedYValue.Size = new System.Drawing.Size(50, 23);
            this.pickedYValue.TabIndex = 6;
            // 
            // pickedXValue
            // 
            this.pickedXValue.Location = new System.Drawing.Point(311, 39);
            this.pickedXValue.Name = "pickedXValue";
            this.pickedXValue.Size = new System.Drawing.Size(50, 23);
            this.pickedXValue.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "X";
            // 
            // pickLocation
            // 
            this.pickLocation.Location = new System.Drawing.Point(189, 39);
            this.pickLocation.Name = "pickLocation";
            this.pickLocation.Size = new System.Drawing.Size(100, 23);
            this.pickLocation.TabIndex = 2;
            this.pickLocation.Text = "Pick Location";
            this.pickLocation.UseVisualStyleBackColor = true;
            this.pickLocation.Click += new System.EventHandler(this.pickLocation_Click);
            // 
            // pickedLocation
            // 
            this.pickedLocation.AutoSize = true;
            this.pickedLocation.Location = new System.Drawing.Point(169, 42);
            this.pickedLocation.Name = "pickedLocation";
            this.pickedLocation.Size = new System.Drawing.Size(14, 13);
            this.pickedLocation.TabIndex = 1;
            this.pickedLocation.TabStop = true;
            this.pickedLocation.UseVisualStyleBackColor = true;
            // 
            // currentLocation
            // 
            this.currentLocation.AutoSize = true;
            this.currentLocation.Location = new System.Drawing.Point(6, 40);
            this.currentLocation.Name = "currentLocation";
            this.currentLocation.Size = new System.Drawing.Size(114, 19);
            this.currentLocation.TabIndex = 0;
            this.currentLocation.TabStop = true;
            this.currentLocation.Text = "Current Location";
            this.currentLocation.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(179, 30);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(0, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Click Options";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(92, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Click Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mouse Button";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(3, 272);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(110, 50);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(119, 272);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(110, 50);
            this.stop.TabIndex = 5;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(114, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Current Location";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(199, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Pick Location";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Y";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(300, 29);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(50, 23);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(374, 29);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(50, 23);
            this.textBox6.TabIndex = 7;
            // 
            // recordPlayback
            // 
            this.recordPlayback.Location = new System.Drawing.Point(231, 272);
            this.recordPlayback.Name = "recordPlayback";
            this.recordPlayback.Size = new System.Drawing.Size(110, 50);
            this.recordPlayback.TabIndex = 8;
            this.recordPlayback.Text = "Hotkey Settings";
            this.recordPlayback.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Record and Play";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recordPlayback);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AutoClicker";
            this.Size = new System.Drawing.Size(460, 325);
            this.Load += new System.EventHandler(this.AutoClicker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button start;
        private Button stop;
        private Label label4;
        private TextBox milliseconds;
        private Label label3;
        private TextBox seconds;
        private Label label2;
        private TextBox minutes;
        private Label label1;
        private TextBox hours;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private Label label6;
        private Label label5;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label8;
        private Label label7;
        private Button button4;
        private RadioButton radioButton3;
        private TextBox pickedYValue;
        private TextBox pickedXValue;
        private Label label10;
        private Label label9;
        private Button pickLocation;
        private RadioButton pickedLocation;
        private RadioButton currentLocation;
        private Label label11;
        private TextBox textBox9;
        private Button recordPlayback;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}
