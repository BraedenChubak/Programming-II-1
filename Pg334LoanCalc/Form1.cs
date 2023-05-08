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

namespace Pg334LoanCalc
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cost = double.Parse(textBox1.Text);
            double down = double.Parse(textBox2.Text);
            int months = int.Parse(textBox3.Text);
            double loan = cost - down;
            double interest = 0;
            if (radioButton1.Checked)
            {
                interest = 0.089;
            }
            else if (radioButton2.Checked)
            {
                interest = 0.095;
            }
            double total_loan = loan * Math.Pow(1 + interest, months);
            double payment = Math.Round(total_loan / months, 2);
            double interestcost = Math.Round(total_loan - loan, 2);
            double ppm = Math.Round(loan / months, 2);
            double ipm = Math.Round(interestcost / months, 2);

            listBox1.Items.Clear();
            listBox1.Items.Add("Per Month:");
            listBox1.Items.Add("Payment: " + payment.ToString());
            listBox1.Items.Add("Interest: " + ipm.ToString());
            listBox1.Items.Add("Principal: " + ppm.ToString());

        }
    }
}
