using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lang122d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                listBox1.Items.Clear();
                for(int lcv = -12; lcv <= 16; lcv++)
                {
                    int y = (int)Math.Pow(lcv, 6) - (int)Math.Pow(3 * lcv, 5) - (int)Math.Pow(93 * lcv, 4) + (int)Math.Pow(87 * lcv, 3) + (int)Math.Pow(1596 * lcv, 2) - (1380 * lcv) - 2800;
                    listBox1.Items.Add(lcv + "\t\t" + y);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
