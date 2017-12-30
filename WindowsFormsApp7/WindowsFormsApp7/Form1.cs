using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult s = colorDialog1.ShowDialog();
            if (s == DialogResult.OK) {
                t1.BackColor = colorDialog1.Color;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult fc = colorDialog1.ShowDialog();
            if (fc==DialogResult.OK)
            {
                t1.ForeColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult ft = fontDialog1.ShowDialog();
            if (ft==DialogResult.OK)
            {
                t1.Font = fontDialog1.Font;
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult s = colorDialog1.ShowDialog();
            if (s == DialogResult.OK)
            {
                t1.BackColor = colorDialog1.Color;
            }
        }
    }
}
