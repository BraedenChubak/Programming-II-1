using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg435TicketSales
{
    public partial class GeneralForm : Form
    {
        private Form myParent;
        public GeneralForm(Form prt)
        {
            InitializeComponent();
            myParent = prt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tickets = int.Parse(textBox1.Text);
            decimal cpt = 0;
            if (radioButton1.Checked == true)
            {
                cpt = 20;
            }
            else if (radioButton2.Checked == true)
            {
                cpt = 15;
            }
            if (radioButton3.Checked == true)
            {
                cpt = 10;
            }
            decimal cost = tickets * cpt;
            decimal tax = CalcTax(cost);
            decimal total = tax + cost;
            
            label3.Text = cost.ToString();
            label4.Text = tax.ToString();
            label6.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }

        decimal decTAXRATE = 0.06m; // Sales tax rate
        private decimal CalcTax(decimal cost)
        {
            return cost * decTAXRATE;
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.myParent.Show();
        }
    }
}
