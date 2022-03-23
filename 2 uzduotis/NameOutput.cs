using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_uzduotis
{
    internal class NameOutput
    {
        public void WriteName(string name, int number, TextBox outputTextBox)
        {
            outputTextBox.Text = "";
            for (int i = 0; i < number; i++)
            {
                outputTextBox.Text += $"{name}\r\n";
            }
        }
    }
}
