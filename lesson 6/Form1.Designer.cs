namespace lesson_6
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.btnForAddName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(16, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(67, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Jusu vardas";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(89, 27);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 23);
            this.NameTextBox.TabIndex = 1;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(89, 92);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(211, 199);
            this.OutputTextBox.TabIndex = 2;
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Location = new System.Drawing.Point(29, 95);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(49, 15);
            this.ConsoleLabel.TabIndex = 3;
            this.ConsoleLabel.Text = "Konsole";
            // 
            // btnForAddName
            // 
            this.btnForAddName.Location = new System.Drawing.Point(205, 27);
            this.btnForAddName.Name = "btnForAddName";
            this.btnForAddName.Size = new System.Drawing.Size(95, 23);
            this.btnForAddName.TabIndex = 4;
            this.btnForAddName.Text = "Siusti";
            this.btnForAddName.UseVisualStyleBackColor = true;
            this.btnForAddName.Click += new System.EventHandler(this.btnForAddName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 321);
            this.Controls.Add(this.btnForAddName);
            this.Controls.Add(this.ConsoleLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label ConsoleLabel;
        private System.Windows.Forms.Button btnForAddName;
    }
}
