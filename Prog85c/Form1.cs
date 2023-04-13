using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog85c
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
            int start = int.Parse(textBox1.Text);
            start -= 165;

            double month = Math.Round(Math.Floor((double)start / 100.0));
            double day = Math.Round((double)start % 100);
            label3.Text = month.ToString() + "/" + day.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
