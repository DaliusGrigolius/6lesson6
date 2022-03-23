namespace SD_advanced_1_palindromas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.btnCheckPalindrome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iveskite teksta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rezultatas:";
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(135, 24);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTextBox.Size = new System.Drawing.Size(294, 51);
            this.textTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(135, 134);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(294, 23);
            this.outputTextBox.TabIndex = 3;
            // 
            // btnCheckPalindrome
            // 
            this.btnCheckPalindrome.Location = new System.Drawing.Point(135, 81);
            this.btnCheckPalindrome.Name = "btnCheckPalindrome";
            this.btnCheckPalindrome.Size = new System.Drawing.Size(294, 23);
            this.btnCheckPalindrome.TabIndex = 4;
            this.btnCheckPalindrome.Text = "Tikrinti ar tai palindromas";
            this.btnCheckPalindrome.UseVisualStyleBackColor = true;
            this.btnCheckPalindrome.Click += new System.EventHandler(this.btnCheckPalindrome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 216);
            this.Controls.Add(this.btnCheckPalindrome);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button btnCheckPalindrome;
    }
}
