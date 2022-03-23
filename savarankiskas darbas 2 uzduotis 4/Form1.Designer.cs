namespace savarankiskas_darbas_2_uzduotis_4
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
            this.NumberFromTextBox = new System.Windows.Forms.TextBox();
            this.NumberToTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateSumDontShowIntermediateCalculationsButton = new System.Windows.Forms.Button();
            this.CalculateSumShowIntermediateCalculationsButton = new System.Windows.Forms.Button();
            this.CalculateSumButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberFromTextBox
            // 
            this.NumberFromTextBox.Location = new System.Drawing.Point(162, 74);
            this.NumberFromTextBox.Name = "NumberFromTextBox";
            this.NumberFromTextBox.Size = new System.Drawing.Size(100, 23);
            this.NumberFromTextBox.TabIndex = 0;
            // 
            // NumberToTextBox
            // 
            this.NumberToTextBox.Location = new System.Drawing.Point(162, 118);
            this.NumberToTextBox.Name = "NumberToTextBox";
            this.NumberToTextBox.Size = new System.Drawing.Size(100, 23);
            this.NumberToTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skaicius nuo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skaicius iki";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(551, 74);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(209, 163);
            this.ResultTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rezultatas";
            // 
            // CalculateSumDontShowIntermediateCalculationsButton
            // 
            this.CalculateSumDontShowIntermediateCalculationsButton.Location = new System.Drawing.Point(357, 112);
            this.CalculateSumDontShowIntermediateCalculationsButton.Name = "CalculateSumDontShowIntermediateCalculationsButton";
            this.CalculateSumDontShowIntermediateCalculationsButton.Size = new System.Drawing.Size(188, 23);
            this.CalculateSumDontShowIntermediateCalculationsButton.TabIndex = 6;
            this.CalculateSumDontShowIntermediateCalculationsButton.Text = "Suskaiciuoti nerodant tarpines sumos";
            this.CalculateSumDontShowIntermediateCalculationsButton.UseVisualStyleBackColor = true;
            this.CalculateSumDontShowIntermediateCalculationsButton.Click += new System.EventHandler(this.CalculateSumDontShowIntermediateCalculationsButton_Click);
            // 
            // CalculateSumShowIntermediateCalculationsButton
            // 
            this.CalculateSumShowIntermediateCalculationsButton.Location = new System.Drawing.Point(357, 151);
            this.CalculateSumShowIntermediateCalculationsButton.Name = "CalculateSumShowIntermediateCalculationsButton";
            this.CalculateSumShowIntermediateCalculationsButton.Size = new System.Drawing.Size(188, 23);
            this.CalculateSumShowIntermediateCalculationsButton.TabIndex = 7;
            this.CalculateSumShowIntermediateCalculationsButton.Text = "Suskaiciuoti rodant tarpine suma";
            this.CalculateSumShowIntermediateCalculationsButton.UseVisualStyleBackColor = true;
            this.CalculateSumShowIntermediateCalculationsButton.Click += new System.EventHandler(this.CalculateSumShowIntermediateCalculationsButton_Click);
            // 
            // CalculateSumButton
            // 
            this.CalculateSumButton.Location = new System.Drawing.Point(357, 73);
            this.CalculateSumButton.Name = "CalculateSumButton";
            this.CalculateSumButton.Size = new System.Drawing.Size(188, 23);
            this.CalculateSumButton.TabIndex = 8;
            this.CalculateSumButton.Text = "Suskaiciuoti suma";
            this.CalculateSumButton.UseVisualStyleBackColor = true;
            this.CalculateSumButton.Click += new System.EventHandler(this.CalculateSumButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculateSumButton);
            this.Controls.Add(this.CalculateSumShowIntermediateCalculationsButton);
            this.Controls.Add(this.CalculateSumDontShowIntermediateCalculationsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberToTextBox);
            this.Controls.Add(this.NumberFromTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberFromTextBox;
        private System.Windows.Forms.TextBox NumberToTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateSumDontShowIntermediateCalculationsButton;
        private System.Windows.Forms.Button CalculateSumShowIntermediateCalculationsButton;
        private System.Windows.Forms.Button CalculateSumButton;
    }
}