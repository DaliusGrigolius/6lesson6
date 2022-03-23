using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_advanced_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcFactorialNumSum_Click(object sender, EventArgs e)
        {
            DataReader reader = new DataReader();
            Calculator calc = new Calculator();

            int number = reader.GetNumber(numberTextBox);

            if(number <= 0)
            {
                OutputTextBox.Text = "";
            }
            else
            {
                long result = calc.CalcFactorial(number);
                OutputTextBox.Text = result.ToString();
            }

        }
    }
}
