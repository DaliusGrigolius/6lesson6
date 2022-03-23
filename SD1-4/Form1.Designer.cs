namespace SD1_4
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
            this.labelForHeight = new System.Windows.Forms.Label();
            this.labelForWeight = new System.Windows.Forms.Label();
            this.labelForKMI = new System.Windows.Forms.Label();
            this.labelForConclusion = new System.Windows.Forms.Label();
            this.inputForHeight = new System.Windows.Forms.TextBox();
            this.inputForWeight = new System.Windows.Forms.TextBox();
            this.inputForKmi = new System.Windows.Forms.TextBox();
            this.inputForConclusion = new System.Windows.Forms.TextBox();
            this.btnForKmiCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForHeight
            // 
            this.labelForHeight.AutoSize = true;
            this.labelForHeight.Location = new System.Drawing.Point(17, 29);
            this.labelForHeight.Name = "labelForHeight";
            this.labelForHeight.Size = new System.Drawing.Size(49, 15);
            this.labelForHeight.TabIndex = 0;
            this.labelForHeight.Text = "Ugis(m)";
            // 
            // labelForWeight
            // 
            this.labelForWeight.AutoSize = true;
            this.labelForWeight.Location = new System.Drawing.Point(17, 58);
            this.labelForWeight.Name = "labelForWeight";
            this.labelForWeight.Size = new System.Drawing.Size(59, 15);
            this.labelForWeight.TabIndex = 1;
            this.labelForWeight.Text = "Svoris(kg)";
            // 
            // labelForKMI
            // 
            this.labelForKMI.AutoSize = true;
            this.labelForKMI.Location = new System.Drawing.Point(210, 30);
            this.labelForKMI.Name = "labelForKMI";
            this.labelForKMI.Size = new System.Drawing.Size(28, 15);
            this.labelForKMI.TabIndex = 2;
            this.labelForKMI.Text = "KMI";
            // 
            // labelForConclusion
            // 
            this.labelForConclusion.AutoSize = true;
            this.labelForConclusion.Location = new System.Drawing.Point(210, 58);
            this.labelForConclusion.Name = "labelForConclusion";
            this.labelForConclusion.Size = new System.Drawing.Size(46, 15);
            this.labelForConclusion.TabIndex = 3;
            this.labelForConclusion.Text = "Isvados";
            // 
            // inputForHeight
            // 
            this.inputForHeight.Location = new System.Drawing.Point(82, 26);
            this.inputForHeight.Name = "inputForHeight";
            this.inputForHeight.Size = new System.Drawing.Size(100, 23);
            this.inputForHeight.TabIndex = 4;
            // 
            // inputForWeight
            // 
            this.inputForWeight.Location = new System.Drawing.Point(82, 55);
            this.inputForWeight.Name = "inputForWeight";
            this.inputForWeight.Size = new System.Drawing.Size(100, 23);
            this.inputForWeight.TabIndex = 5;
            // 
            // inputForKmi
            // 
            this.inputForKmi.Location = new System.Drawing.Point(260, 26);
            this.inputForKmi.Name = "inputForKmi";
            this.inputForKmi.ReadOnly = true;
            this.inputForKmi.Size = new System.Drawing.Size(100, 23);
            this.inputForKmi.TabIndex = 6;
            // 
            // inputForConclusion
            // 
            this.inputForConclusion.Location = new System.Drawing.Point(260, 55);
            this.inputForConclusion.Multiline = true;
            this.inputForConclusion.Name = "inputForConclusion";
            this.inputForConclusion.ReadOnly = true;
            this.inputForConclusion.Size = new System.Drawing.Size(263, 82);
            this.inputForConclusion.TabIndex = 7;
            // 
            // btnForKmiCalc
            // 
            this.btnForKmiCalc.Location = new System.Drawing.Point(82, 84);
            this.btnForKmiCalc.Name = "btnForKmiCalc";
            this.btnForKmiCalc.Size = new System.Drawing.Size(100, 23);
            this.btnForKmiCalc.TabIndex = 8;
            this.btnForKmiCalc.Text = "Skaiciuoti";
            this.btnForKmiCalc.UseVisualStyleBackColor = true;
            this.btnForKmiCalc.Click += new System.EventHandler(this.btnForKmiCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 164);
            this.Controls.Add(this.btnForKmiCalc);
            this.Controls.Add(this.inputForConclusion);
            this.Controls.Add(this.inputForKmi);
            this.Controls.Add(this.inputForWeight);
            this.Controls.Add(this.inputForHeight);
            this.Controls.Add(this.labelForConclusion);
            this.Controls.Add(this.labelForKMI);
            this.Controls.Add(this.labelForWeight);
            this.Controls.Add(this.labelForHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForHeight;
        private System.Windows.Forms.Label labelForWeight;
        private System.Windows.Forms.Label labelForKMI;
        private System.Windows.Forms.Label labelForConclusion;
        private System.Windows.Forms.TextBox inputForHeight;
        private System.Windows.Forms.TextBox inputForWeight;
        private System.Windows.Forms.TextBox inputForKmi;
        private System.Windows.Forms.TextBox inputForConclusion;
        private System.Windows.Forms.Button btnForKmiCalc;
    }
}
