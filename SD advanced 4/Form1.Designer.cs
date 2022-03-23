namespace SD_advanced_4
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.btnCalcFactorialNumSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Įveskite natūrinį skaičių:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rezultatas:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(176, 42);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(164, 23);
            this.numberTextBox.TabIndex = 2;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(176, 126);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(164, 23);
            this.OutputTextBox.TabIndex = 3;
            // 
            // btnCalcFactorialNumSum
            // 
            this.btnCalcFactorialNumSum.Location = new System.Drawing.Point(38, 71);
            this.btnCalcFactorialNumSum.Name = "btnCalcFactorialNumSum";
            this.btnCalcFactorialNumSum.Size = new System.Drawing.Size(302, 23);
            this.btnCalcFactorialNumSum.TabIndex = 4;
            this.btnCalcFactorialNumSum.Text = "Skaičiuoti natūrinių skaičių sandaugą";
            this.btnCalcFactorialNumSum.UseVisualStyleBackColor = true;
            this.btnCalcFactorialNumSum.Click += new System.EventHandler(this.btnCalcFactorialNumSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 213);
            this.Controls.Add(this.btnCalcFactorialNumSum);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.numberTextBox);
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
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button btnCalcFactorialNumSum;
    }
}
