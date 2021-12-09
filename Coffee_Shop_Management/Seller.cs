using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Coffee_Shop_Management
{
    public partial class Seller : Form
    {
        private string delete_usr = "";
        public Seller()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Home o = new Home();
            o.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LOadseller_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);

            con.Open();

            string newcon = "select Id from CSMSB where id='" + textBox1.Text + "'and fastname ='" + textBox2.Text + "'";


            SqlDataAdapter adp = new SqlDataAdapter(newcon, con);
            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {




                SqlCommand cmd = new SqlCommand("Select * from CSMSB", con);
                DataTable dp = new DataTable();



                SqlDataReader sdr = cmd.ExecuteReader();
                dp.Load(sdr);
                con.Close();

                dataGridView1.DataSource = dp;

                MessageBox.Show("Record Successful");





            }
            else
            {
                MessageBox.Show("Invalid");

            } 


        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            string query = String.Format("DELETE FROM CSMSB where username='{0}'", delete_usr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Delete Successful");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            delete_usr = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
        }

        private void refreshb_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);

            con.Open();

            string newcon = "select Id from CSMSB where id='" + textBox1.Text + "'and fastname ='" + textBox2.Text + "'";


            SqlDataAdapter adp = new SqlDataAdapter(newcon, con);
            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {




                SqlCommand cmd = new SqlCommand("Select * from CSMSB", con);
                DataTable dp = new DataTable();



                SqlDataReader sdr = cmd.ExecuteReader();
                dp.Load(sdr);
                con.Close();

                dataGridView1.DataSource = dp;






            }
            else
            {
                

            }
        }
    }
}
