namespace uzduotis_3
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
            this.textLabel = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.codedTextTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(40, 44);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(128, 15);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Iveskite bet koki teksta:";
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(174, 41);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(100, 23);
            this.textInput.TabIndex = 1;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            // 
            // codedTextTextBox
            // 
            this.codedTextTextBox.Location = new System.Drawing.Point(174, 103);
            this.codedTextTextBox.Multiline = true;
            this.codedTextTextBox.Name = "codedTextTextBox";
            this.codedTextTextBox.Size = new System.Drawing.Size(100, 24);
            this.codedTextTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uzkoduotas tekstas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codedTextTextBox);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.textLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox codedTextTextBox;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
