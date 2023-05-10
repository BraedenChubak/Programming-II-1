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

namespace Pg514SalesData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int days = int.Parse(Interaction.InputBox("Enter the number of days you have sales"));
            int total = 0;
            int avg = 0;
            int max = 0;
            int min = 2147483647;
            int current = 0;
            for (int lcv = 1; lcv <= days; lcv++)
            {
                current = int.Parse(Interaction.InputBox("Enter the sales you got on day " + lcv));
                total += current;
                if (current > max)
                    max = current;
                if (current < min)
                    min = current;
            }
            avg = total / days;
            label8.Text = total.ToString();
            label7.Text = avg.ToString();
            label6.Text = max.ToString();
            label5.Text = min.ToString();
        }
    }
}
