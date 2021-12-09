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
    public partial class CoffeeList : Form
    {
        int count = 0;
        public CoffeeList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 i = new Form1();
            i.Show();

            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Home o = new Home();
            o.Show();

            this.Hide();
        }

        private void btnCoffee1_Click(object sender, EventArgs e)
        {
            count = count + 180;
            label4.Text = count.ToString();
            label5.Text = count.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = count + 200;
            label4.Text = count.ToString();
            label5.Text = count.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            count = count + 350;
            label4.Text = count.ToString();
            label5.Text = count.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            count = count + 280;
            label4.Text = count.ToString();
            label5.Text = count.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            count = count + 380;
            label4.Text = count.ToString();
            label5.Text = count.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            String total = label4.Text;
            MessageBox.Show(total, " Your-Bill");

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);

            con.Open();

            string newcon = "insert into orderss(Totalprice,Amount)VALUES('" + label1.Text + "','" + label4.Text + "')";
            SqlCommand cmd = new SqlCommand(newcon, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Place Successful");

            label4.Text = "00";
            label5.Text = "00";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label4.Text = "00";
            label5.Text = "00";

        }

        
       
    }
}
