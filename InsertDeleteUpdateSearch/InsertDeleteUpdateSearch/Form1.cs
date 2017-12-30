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

namespace InsertDeleteUpdateSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HR\Documents\seed.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "INSERT INTO STUDENTS(name,course,fee) VALUES('"+txtName.Text+"','"+txtCourse.Text+"',"+txtFee.Text+")";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            sda.SelectCommand.ExecuteNonQuery();            
            con.Close();
            MessageBox.Show("Insert Successfully!");
            display();
        }


        public void display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HR\Documents\seed.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from students;";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

    }
}
