namespace SD1_3
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
            this.btnCalcNumSum = new System.Windows.Forms.Button();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Įveskite skaičių:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rezultatas:";
            // 
            // btnCalcNumSum
            // 
            this.btnCalcNumSum.Location = new System.Drawing.Point(14, 40);
            this.btnCalcNumSum.Name = "btnCalcNumSum";
            this.btnCalcNumSum.Size = new System.Drawing.Size(212, 23);
            this.btnCalcNumSum.TabIndex = 2;
            this.btnCalcNumSum.Text = "Skaičiuoti skaičiaus skaitmenų sumą";
            this.btnCalcNumSum.UseVisualStyleBackColor = true;
            this.btnCalcNumSum.Click += new System.EventHandler(this.btnCalcNumSum_Click);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(108, 11);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(118, 23);
            this.NumberTextBox.TabIndex = 3;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(108, 77);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(118, 23);
            this.OutputTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 124);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.btnCalcNumSum);
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
        private System.Windows.Forms.Button btnCalcNumSum;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}
