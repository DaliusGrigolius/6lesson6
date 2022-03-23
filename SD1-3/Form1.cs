using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcNumSum_Click(object sender, EventArgs e)
        {
            DataReader reader = new DataReader();
            Calculator calc = new Calculator();

            long number = reader.ReadData(NumberTextBox);
            long result = calc.GetNumSum(number);

            OutputTextBox.Text = result.ToString();
        }
    }
}
