using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_advanced_1_palindromas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckPalindrome_Click(object sender, EventArgs e)
        {
            Palindromizer palindromizer = new Palindromizer();

            string str = textTextBox.Text;
            bool result = palindromizer.IsPalindrome(str);

            outputTextBox.Text = result.ToString();
        }
    }
}
