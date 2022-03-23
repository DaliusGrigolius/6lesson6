using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForKmiCalc_Click(object sender, EventArgs e)
        {
            DataReader reader = new DataReader();
            KmiCalculator calculator = new KmiCalculator();
            Conclusionist conclusionist = new Conclusionist();

            decimal height = reader.ReadWeight(inputForHeight);
            decimal bodyMass = reader.ReadHeight(inputForWeight);
            decimal kmi = calculator.CalculateKmi(height, bodyMass);
            inputForKmi.Text = kmi.ToString();
            conclusionist.GetConclusion(kmi, inputForConclusion);
        }
    }
}