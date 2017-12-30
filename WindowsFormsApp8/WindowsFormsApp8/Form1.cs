using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult fc = colorDialog1.ShowDialog();
            if (fc== DialogResult.OK) {

                rt1.ForeColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult fs = fontDialog1.ShowDialog();

            if(fs== DialogResult.OK) {
                rt1.Font = fontDialog1.Font;
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult bc = colorDialog1.ShowDialog();
            if (bc == DialogResult.OK)
            {

                rt1.BackColor = colorDialog1.Color;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fc = colorDialog1.ShowDialog();
            if (fc == DialogResult.OK)
            {

                rt1.ForeColor = colorDialog1.Color;
            }
        }
    }
}
