using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD1_3
{
    internal class DataReader
    {
        public int ReadData(TextBox NumberTextBox)
        {
            int num;

            bool parseSuccess = int.TryParse(NumberTextBox.Text, out num);
            if (!parseSuccess)
            {
                MessageBox.Show("Įveskite sveikąjį teigiamą skaičių, pvz.: 5, 11, 100");
            }

            return num;
        }
    }
}
