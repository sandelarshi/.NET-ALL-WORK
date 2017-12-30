using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExamManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        int Score = 0;
        int Total = 0;
        int Obtained = 0;
        int per=0;
        int qno = 0;
        string ans;
        string sans;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HR\source\repos\ExamManagementSystem\ExamManagementSystem\exame.mdf;Integrated Security=True;Connect Timeout=30");
        void ccheck()
        {
            Total += Score;
            if (ans.ToString() == sans.ToString())
            {
                Obtained += Score;
                label3.Text = Total.ToString();
                label6.Text = Obtained.ToString();
                MessageBox.Show(Total.ToString());
            }
            else
            {
                MessageBox.Show(Total.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Hide();
            button1.Hide();
           
            SqlDataAdapter sda = new SqlDataAdapter("Select * From adit2017", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label1.Text = "Q" + dt.Rows[qno][0].ToString()+" "+dt.Rows[qno][1]+"?";
            r1.Text = dt.Rows[qno][2].ToString();
            r2.Text = dt.Rows[qno][3].ToString();
            r3.Text = dt.Rows[qno][4].ToString();
            r4.Text = dt.Rows[qno][5].ToString();
            Score = Convert.ToInt32(dt.Rows[qno][6]);
            ans = dt.Rows[qno][7].ToString();
            label2.Text = Score.ToString();
            label3.Text = Total.ToString();
            label4.Text = ans;



        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text== "Finish!")
            {
                
                groupBox1.Hide();
                groupBox2.Show();
                button2.Hide();
                button1.Show();
                return;
            }

            if (r1.Checked == true)
            {
                sans = r1.Text;
                ccheck();
            }
            else if (r2.Checked == true)
            {
                sans = r2.Text;
                ccheck();
            }
            else if (r3.Checked == true)
            {
                sans = r3.Text;
                ccheck();
            }
            else if (r4.Checked == true)
            {
                sans = r4.Text;
                ccheck();
            }

            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from adit2017", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            if (Convert.ToInt32(qno) < Convert.ToInt32(dt1.Rows[0][0])-1)
            {
                qno++;
                
            }
            else {
                button2.Text = "Finish!";
            }

            SqlDataAdapter sda = new SqlDataAdapter("Select * From adit2017", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label1.Text = "Q" + dt.Rows[qno][0].ToString() + " " + dt.Rows[qno][1] + "?";
            r1.Text = dt.Rows[qno][2].ToString();
            r2.Text = dt.Rows[qno][3].ToString();
            r3.Text = dt.Rows[qno][4].ToString();
            r4.Text = dt.Rows[qno][5].ToString();
            Score = Convert.ToInt32(dt.Rows[qno][6]);
            ans = dt.Rows[qno][7].ToString();
            label2.Text = Score.ToString();
            label3.Text = Total.ToString();
            label4.Text = ans;

            



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            per = Obtained / Total * 100;
            label11.Text = per.ToString();
            if (per >= 80)
            {
                label9.Text = "A one";
            }
            else if (per >= 70)
            {
                label9.Text = "A";
            }
            else if (per >= 60)
            {
                label9.Text = "B";
            }
            else if (per >= 50)
            {
                label9.Text = "C";
            }
            else
            {
                label9.Text = "Fail";
            }
        }
    }
}
