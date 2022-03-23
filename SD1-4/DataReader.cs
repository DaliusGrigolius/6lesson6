using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD1_4
{
    internal class DataReader
    {
        public decimal ReadHeight(TextBox inputForHeight)
        {
            bool isParseSucces = decimal.TryParse(inputForHeight.Text, out decimal number);
            if (!isParseSucces)
            {
                MessageBox.Show("Iveskite ugi metrais, pvz.: 1.75 ar 1.8");
                return -1;
            }
            return number;
        }

        public decimal ReadWeight(TextBox inputForWeight)
        {
            bool isParseSucces = decimal.TryParse(inputForWeight.Text, out decimal number);
            if (!isParseSucces)
            {
                MessageBox.Show("Iveskite svori kilogramais, pvz.: 60 ar 62.55");
                return -1;
            }
            return number;
        }
    }
}
