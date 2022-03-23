using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_uzduotis
{
    internal class DataReader
    {
        public string ReadStringName(TextBox nameTextBox)
        {
            return nameTextBox.Text;
        }
        public int ReadInt(TextBox numberTextBox)
        {
            bool isParseSucces = int.TryParse(numberTextBox.Text, out int number);

            if (!isParseSucces)
            {
                MessageBox.Show("Iveskite skaiciu skaiciaus langelyje.");
                return -1;
            }

            return number;
        }
    }
}
