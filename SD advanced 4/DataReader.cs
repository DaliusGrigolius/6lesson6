using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_advanced_4
{
    internal class DataReader
    {
        public int GetNumber(TextBox numberTextBox)
        {
            int num;

            bool parseSucces = int.TryParse(numberTextBox.Text, out num);
            if (!parseSucces)
            {
                MessageBox.Show("Įveskite natūrinį teigiamą skaičių nuo 1, pvz.: 1, 10, 100");
            }

            if(num <= 0)
            {
                MessageBox.Show("Įveskite natūrinį teigiamą skaičių nuo 1, pvz.: 1, 10, 100");
                numberTextBox.Text = "";
            }

            return num;
        }
    }
}
