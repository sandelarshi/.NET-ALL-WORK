using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
        int Sec= 0;
        private void t1_Tick(object sender, EventArgs e)
        {
            Sec++;
            if ( Sec >9)
            { Sec=0;
                

                
              
            }
            sec.Text = Sec.ToString();







        }
        int Min = 0;
        private void t2_Tick(object sender, EventArgs e)
        {
            Min++;
            if (Min > 9) {
                Min = 0;
            }
            min.Text = Min.ToString();
        }
        int Hou = 0;
        private void t3_Tick(object sender, EventArgs e)
        {
            Hou++;
            if (Hou > 9) { Hou = 0; }


            hou.Text = Hou.ToString();

        }

        private void b1_Click(object sender, EventArgs e)


        {
            
            t1.Stop();
            t2.Stop();
            t3.Stop();

            if (Sec == Min && Sec == Hou)
            {
                MessageBox.Show("You Are Win");
            }
            else { MessageBox.Show("You Are los");
                t1.Start();
                t2.Start();
                t3.Start(); }
        }
    }
}
