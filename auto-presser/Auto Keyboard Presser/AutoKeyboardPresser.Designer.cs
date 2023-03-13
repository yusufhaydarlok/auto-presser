namespace auto_presser
{
    partial class AutoKeyboardPresser
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
            this.Hotkeys = new System.Windows.Forms.Button();
            this.startStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Hotkeys
            // 
            this.Hotkeys.Location = new System.Drawing.Point(232, 272);
            this.Hotkeys.Name = "Hotkeys";
            this.Hotkeys.Size = new System.Drawing.Size(225, 50);
            this.Hotkeys.TabIndex = 13;
            this.Hotkeys.Text = "Hotkeys";
            this.Hotkeys.UseVisualStyleBackColor = true;
            // 
            // startStop
            // 
            this.startStop.Location = new System.Drawing.Point(3, 272);
            this.startStop.Name = "startStop";
            this.startStop.Size = new System.Drawing.Size(225, 50);
            this.startStop.TabIndex = 11;
            this.startStop.Text = "Start / Stop";
            this.startStop.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 73);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keyboard Log";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click Interval";
            // 
            // AutoKeyboardPresser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.Hotkeys);
            this.Controls.Add(this.startStop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AutoKeyboardPresser";
            this.Size = new System.Drawing.Size(460, 325);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Hotkeys;
        private Button startStop;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}
