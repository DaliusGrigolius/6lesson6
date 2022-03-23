using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace savarankiskas_darbas_2_uzduotis_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateSumButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            int numberFrom = Convert.ToInt32(NumberFromTextBox.Text);
            int numberTo = Convert.ToInt32(NumberToTextBox.Text);

            int sum = CalculateSum(numberFrom, numberTo);
            ResultTextBox.Text = sum.ToString();
        }

        private void CalculateSumDontShowIntermediateCalculationsButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            int numberFrom = Convert.ToInt32(NumberFromTextBox.Text);
            int numberTo = Convert.ToInt32(NumberToTextBox.Text);

            int sum = CalculateSum(numberFrom, numberTo, false);
            ResultTextBox.AppendText(sum.ToString());
        }

        private void CalculateSumShowIntermediateCalculationsButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            int numberFrom = Convert.ToInt32(NumberFromTextBox.Text);
            int numberTo = Convert.ToInt32(NumberToTextBox.Text);

            int sum = CalculateSum(numberFrom, numberTo, true);
            ResultTextBox.AppendText(sum.ToString());
        }

        private int CalculateSum(int numberFrom, int numberTo)
        {
            int sum = 0;

            for (int i = numberFrom; i <= numberTo; i++)
            {
                sum += i;
            }

            return sum;
        }

        private int CalculateSum(int numberFrom, int numberTo, bool showIntermediateCalculations)
        {
            int sum = 0;

            for (int i = numberFrom; i <= numberTo; i++)
            {
                if (showIntermediateCalculations)
                {
                    ResultTextBox.AppendText($"{sum} + {i} = {sum + i}\r\n");
                }
                sum += i;
            }

            return sum;
        }
    }
}