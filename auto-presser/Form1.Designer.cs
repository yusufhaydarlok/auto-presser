namespace auto_presser
{
    partial class AutoPresser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AutoClicker = new System.Windows.Forms.Button();
            this.AutoKeyboardPresser = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AutoClicker
            // 
            this.AutoClicker.Location = new System.Drawing.Point(12, 12);
            this.AutoClicker.Name = "AutoClicker";
            this.AutoClicker.Size = new System.Drawing.Size(229, 23);
            this.AutoClicker.TabIndex = 0;
            this.AutoClicker.Text = "Auto Clicker";
            this.AutoClicker.UseVisualStyleBackColor = true;
            this.AutoClicker.Click += new System.EventHandler(this.AutoClicker_Click);
            // 
            // AutoKeyboardPresser
            // 
            this.AutoKeyboardPresser.Location = new System.Drawing.Point(243, 12);
            this.AutoKeyboardPresser.Name = "AutoKeyboardPresser";
            this.AutoKeyboardPresser.Size = new System.Drawing.Size(229, 23);
            this.AutoKeyboardPresser.TabIndex = 1;
            this.AutoKeyboardPresser.Text = "Auto Keyboard Presser";
            this.AutoKeyboardPresser.UseVisualStyleBackColor = true;
            this.AutoKeyboardPresser.Click += new System.EventHandler(this.AutoKeyboardPresser_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(12, 41);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(460, 408);
            this.panelContainer.TabIndex = 2;
            // 
            // AutoPresser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.AutoKeyboardPresser);
            this.Controls.Add(this.AutoClicker);
            this.Name = "AutoPresser";
            this.Text = "Auto Presser";
            this.ResumeLayout(false);

        }

        #endregion

        private Button AutoClicker;
        private Button AutoKeyboardPresser;
        private Panel panelContainer;
    }
}