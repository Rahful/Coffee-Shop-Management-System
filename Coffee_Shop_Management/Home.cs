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
using System.Configuration;


namespace Coffee_Shop_Management
{
    public partial class Home : Form
    {

        private string username = "";
        public Home()
        {
            InitializeComponent();
        }
        public Home(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            this.Close();
        }




        private void AdminB_Click(object sender, EventArgs e)
        {
            Seller b = new Seller();
            b.Show();
            this.Close();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            CoffeeList d = new CoffeeList();
            d.Show();

            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
