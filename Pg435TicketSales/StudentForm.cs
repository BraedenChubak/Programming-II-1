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
    public partial class StudentForm : Form
    {
        private Form myParent;
        public StudentForm(Form prt)
        {
            InitializeComponent();
            this.myParent = prt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tickets = int.Parse(textBox1.Text);
            decimal cpt = 7;
            decimal cost = tickets * cpt;
            decimal tax = CalcTax(cost);
            decimal total = tax + cost;

            label3.Text = cost.ToString();
            label4.Text = tax.ToString();
            label6.Text = total.ToString();

        }

        decimal decTAXRATE = 0.06m; // Sales tax rate
        private decimal CalcTax (decimal cost)
        {
            return cost * decTAXRATE;
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.myParent.Show();
        }
    }
}
