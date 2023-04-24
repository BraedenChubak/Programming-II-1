using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg535CatchMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You got me!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            string[] strCaption = { "Click here", "Try Harder!", "Try again", "Not even close!", "I'm over here!", "Where are you?" };
            Random rand = new Random();

            int intIndex = rand.Next(strCaption.Length);
            button1.Text = strCaption[intIndex];
            button1.Left = rand.Next(500 - button1.Width - 10);
            button1.Top = rand.Next(500 - button1.Height - 100);
        }
    }
}
