using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AboutMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "Braeden Chubak";
            label5.Text = "Chess Club";
            label4.Text = "Have no fear of perfection, you'll never reach it.\n- Salvador Dali";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label5.Text = "";
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
