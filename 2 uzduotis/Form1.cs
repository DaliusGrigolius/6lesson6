using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_uzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DataReader reader = new DataReader();
            NameOutput output = new NameOutput();

            string name = reader.ReadStringName(NameTextBox);
            int number = reader.ReadInt(NumberTextBox);

            output.WriteName(name, number, OutputTextBox);
        }
    }
}
