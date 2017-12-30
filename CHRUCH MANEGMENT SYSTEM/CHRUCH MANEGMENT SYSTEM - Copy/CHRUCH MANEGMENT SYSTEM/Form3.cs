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
namespace CHRUCH_MANEGMENT_SYSTEM
{
    public partial class Form3 : Form
    {
        
        
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HR\Documents\cms.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "INSERT INTO familes(hasband,hfather,wife,wfather)VALUES('"+hasband.Text+"','"+hfather.Text+"','"+wife.Text+"','"+wfather.Text+ "')";
            
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("done");
            display();
        }
        public void display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HR\Documents\cms.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from familes;";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
           
         
               
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    hasband.Text = row.Cells["Id"].Value.ToString();
                    MessageBox.Show(row.Cells["Id"].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select item!");
            }


        }
    }
}
