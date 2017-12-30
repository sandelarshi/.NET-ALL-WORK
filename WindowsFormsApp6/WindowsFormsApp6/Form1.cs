using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ans_Click(object sender, EventArgs e)
        {
            ans.Text = "rb4";
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb4.Text == ans.Text)

            {MessageBox.Show ("right");}
           
       


        }
    }
}
