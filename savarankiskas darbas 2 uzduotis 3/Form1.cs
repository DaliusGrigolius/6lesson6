using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace savarankiskas_darbas_2_uzduotis_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            int power = Convert.ToInt32(textBox2.Text);

            double result = Math.Pow(number, power);
            textBox3.Text = result.ToString();
        }
    }
}
