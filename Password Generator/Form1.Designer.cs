namespace Password_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pwLabel = new System.Windows.Forms.Label();
            this.copiedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pwLabel
            // 
            this.pwLabel.BackColor = System.Drawing.SystemColors.Control;
            this.pwLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pwLabel.Location = new System.Drawing.Point(12, 43);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(264, 39);
            this.pwLabel.TabIndex = 0;
            this.pwLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pwLabel.Click += new System.EventHandler(this.pwLabel_Click);
            // 
            // copiedLabel
            // 
            this.copiedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.copiedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.copiedLabel.Location = new System.Drawing.Point(12, 9);
            this.copiedLabel.Name = "copiedLabel";
            this.copiedLabel.Size = new System.Drawing.Size(264, 27);
            this.copiedLabel.TabIndex = 1;
            this.copiedLabel.Text = "Click below to generate and copy password";
            this.copiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 91);
            this.Controls.Add(this.copiedLabel);
            this.Controls.Add(this.pwLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private Label pwLabel;
        private Label copiedLabel;
    }
}