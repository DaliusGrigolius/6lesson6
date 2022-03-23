namespace SD_advanced1_2
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
            this.FibNumTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcFibNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iveskite fibonaci sekos n-aji skaiciu:";
            // 
            // FibNumTextBox
            // 
            this.FibNumTextBox.Location = new System.Drawing.Point(243, 34);
            this.FibNumTextBox.Name = "FibNumTextBox";
            this.FibNumTextBox.Size = new System.Drawing.Size(100, 23);
            this.FibNumTextBox.TabIndex = 1;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(113, 104);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(230, 23);
            this.OutputTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rezultatas:";
            // 
            // btnCalcFibNum
            // 
            this.btnCalcFibNum.Location = new System.Drawing.Point(44, 63);
            this.btnCalcFibNum.Name = "btnCalcFibNum";
            this.btnCalcFibNum.Size = new System.Drawing.Size(299, 23);
            this.btnCalcFibNum.TabIndex = 4;
            this.btnCalcFibNum.Text = "Rodyti";
            this.btnCalcFibNum.UseVisualStyleBackColor = true;
            this.btnCalcFibNum.Click += new System.EventHandler(this.btnCalcFibNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 157);
            this.Controls.Add(this.btnCalcFibNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.FibNumTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FibNumTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcFibNum;
    }
}
