using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TestAppGIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                throw new Exception("Name cannot be blank");
            if (textBox1.Text.Any<char>(x => Char.IsNumber(x) == true))
                throw new Exception("Name cannot contain a number!");

            MessageBox.Show(String.Format("Hello {0}!", textBox1.Text));
        }
    }
}
