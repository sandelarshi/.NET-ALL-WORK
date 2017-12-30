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

namespace sandel_chruch_managent_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

            display();

        }


        public void display() {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HR\Documents\cms.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "select * from familes;";
            SqlDataAdapter sda = new SqlDataAdapter("query", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;



            con.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HR\Documents\cms.mdf;Integrated Security=True;Connect Timeout=30");
            
            string query = "insert into familes (hasband,hfather,wife,wfather) VALUES ()";
            SqlDataAdapter sda = new SqlDataAdapter("query", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;



            con.Close();
        }
    }
}
