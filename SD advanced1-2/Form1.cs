using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_advanced1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcFibNum_Click(object sender, EventArgs e)
        {
            Fibonacci fibo = new Fibonacci();
            int number = Convert.ToInt32(FibNumTextBox.Text);
            long result = fibo.Fib(number);
            OutputTextBox.Text = result.ToString();  
        }
    }
}
