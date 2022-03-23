namespace _2_uzduotis
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
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(16, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Vardas";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(16, 63);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(49, 15);
            this.NumberLabel.TabIndex = 1;
            this.NumberLabel.Text = "Skaicius";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(71, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 23);
            this.NameTextBox.TabIndex = 2;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(71, 60);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.NumberTextBox.TabIndex = 3;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(71, 110);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(186, 177);
            this.OutputTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Konsole";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(182, 25);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 58);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Siusti";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 312);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
    }
}
