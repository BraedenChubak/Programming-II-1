using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lang347
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = Interaction.InputBox("Enter a positive integer", "Input needed");
            int max = int.Parse(num);
            int total = 0;
            for (int lcv = 1; lcv <= max; lcv++)
            {
                total += lcv;
            }
            MessageBox.Show("The sum of numbers 1 through " + max + " equals " + total);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
