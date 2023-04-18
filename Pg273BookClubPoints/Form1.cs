using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg273BookClubPoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int books = int.Parse(textBox1.Text);
            string points = "0";
            if (books == 1)
            {
                points = "5";
            }
            if (books == 2)
            {
                points = "15";
            }
            if (books == 3)
            {
                points = "30";
            }
            if (books >= 4)
            {
                points = "60";
            }
            label2.Text = "You have earned " + points + " points!";
        }
    }
}
