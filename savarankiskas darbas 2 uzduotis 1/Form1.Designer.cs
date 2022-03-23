namespace savarankiskas_darbas_2_uzduotis_1
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
            this.TextLabel = new System.Windows.Forms.Label();
            this.SpacesLabel = new System.Windows.Forms.Label();
            this.TextTextBox = new System.Windows.Forms.TextBox();
            this.SpacesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(31, 31);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(44, 15);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "Tekstas";
            // 
            // SpacesLabel
            // 
            this.SpacesLabel.AutoSize = true;
            this.SpacesLabel.Location = new System.Drawing.Point(31, 116);
            this.SpacesLabel.Name = "SpacesLabel";
            this.SpacesLabel.Size = new System.Drawing.Size(38, 15);
            this.SpacesLabel.TabIndex = 1;
            this.SpacesLabel.Text = "Tarpai";
            // 
            // TextTextBox
            // 
            this.TextTextBox.Location = new System.Drawing.Point(75, 28);
            this.TextTextBox.Multiline = true;
            this.TextTextBox.Name = "TextTextBox";
            this.TextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextTextBox.Size = new System.Drawing.Size(266, 70);
            this.TextTextBox.TabIndex = 2;
            this.TextTextBox.TextChanged += new System.EventHandler(this.TextTextBox_TextChanged);
            // 
            // SpacesTextBox
            // 
            this.SpacesTextBox.Location = new System.Drawing.Point(75, 113);
            this.SpacesTextBox.Name = "SpacesTextBox";
            this.SpacesTextBox.ReadOnly = true;
            this.SpacesTextBox.Size = new System.Drawing.Size(100, 23);
            this.SpacesTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 294);
            this.Controls.Add(this.SpacesTextBox);
            this.Controls.Add(this.TextTextBox);
            this.Controls.Add(this.SpacesLabel);
            this.Controls.Add(this.TextLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label SpacesLabel;
        private System.Windows.Forms.TextBox TextTextBox;
        private System.Windows.Forms.TextBox SpacesTextBox;
    }
}
