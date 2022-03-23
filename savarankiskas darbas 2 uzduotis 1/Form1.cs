using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace savarankiskas_darbas_2_uzduotis_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextTextBox_TextChanged(object sender, EventArgs e)
        {
            int numberOfSpaces = 0;
            string currentText = TextTextBox.Text;

            for (int i = 0; i < currentText.Length; i++)
            {
                if (currentText[i] == ' ')
                {
                    numberOfSpaces++;
                }
            }
            SpacesTextBox.Text = numberOfSpaces.ToString();
            //SpaceCountTextBox.Text = $"{numberOfSpaces}";
        }
    }
}
