using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog88a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int sum = num1 + num2;
            int diff = num1 - num2;
            int prod = num1 * num2;
            double average = (double)sum / 2.0;
            int abs = Math.Abs(diff);
            // Math.Max and Math.Min
            int max = 0;
            int min = 0;

            if (num1 >= num2)
            {
                max = num1;
                min = num2;
            }
            if (num1 <= num2)
            {
                max = num2;
                min = num1;
            }

            lblSum.Text = sum.ToString();
            lblDiff.Text = diff.ToString();
            lblProd.Text = prod.ToString();
            lblAvg.Text = average.ToString();
            lblAbs.Text = abs.ToString();
            lblMin.Text = min.ToString();
            lblMax.Text = max.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblSum.Text = "";
            lblDiff.Text = "";
            lblProd.Text = "";
            lblAvg.Text = "";
            lblAbs.Text = "";
            lblMin.Text = "";
            lblMax.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lblSum_Click(object sender, EventArgs e)
        {

        }

        private void lblDiff_Click(object sender, EventArgs e)
        {

        }

        private void lblProd_Click(object sender, EventArgs e)
        {

        }

        private void lblAvg_Click(object sender, EventArgs e)
        {

        }

        private void lblAbs_Click(object sender, EventArgs e)
        {

        }

        private void lblMin_Click(object sender, EventArgs e)
        {

        }
    }
}
