using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uzduotis_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {
            string letter = textInput.Text;
            codedTextTextBox.Text = "";
            for (int i = 0; i < letter.Length; i++)
            {
                codedTextTextBox.AppendText("#");
            }
        }
    }
}
