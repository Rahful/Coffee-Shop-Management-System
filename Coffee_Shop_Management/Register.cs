using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_Management
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            this.Close();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if(fastnametxt.Text.Equals(string.Empty) || lastnametxt.Text.Equals(string.Empty)|| usernametxt.Text.Equals(string.Empty) || passwordtxt.Text.Equals(string.Empty) || confirmtxt.Text.Equals(string.Empty))
                {

                MessageBox.Show("Field cannot be empty");


            }

            else
            {
                if(passwordtxt.Text != confirmtxt.Text)
                {
                    MessageBox.Show("Password & Confirm Password Must Match");
                }
                else
                {
                    if(GenderCombo.SelectedItem==null)
                    {
                        MessageBox.Show("Please Select Gender");

                    }
                    else if(dateTimePicker1.Value.Date==DateTime.Now.Date)
                    {
                        MessageBox.Show("Please Select a valid of Birth");
                    }
                    else if(mobiletxt.Text.Equals(string.Empty))
                    {
                        MessageBox.Show("Please Insert Movile Number");
                    }
                    else if (jobcatagorycombo.SelectedItem==null)
                    {
                        MessageBox.Show("Please Select JobCategory");
                    }
                    else if(bloodgroupcombo.SelectedItem==null)
                    {
                        MessageBox.Show("Please Select Blood Group");
                    }
                    else if (checkBox1.Checked==false)
                    {
                        MessageBox.Show("Plaese Select The Agreement");
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);

                        con.Open();

                        string newcon = "insert into CSMSB(fastname,lastname,username,password,confirmpass,dateofbirth,gender,mobilenumber,jobcatagory,bloodgroup) VALUES('"+fastnametxt.Text+"','"+lastnametxt.Text+"','"+usernametxt.Text+"','"+passwordtxt.Text+"','"+confirmtxt.Text+"','"+dateTimePicker1.Text+"','"+GenderCombo.Text+"','"+mobiletxt.Text+"','"+jobcatagorycombo.Text+"','"+bloodgroupcombo.Text+"')";


                        SqlCommand cmd = new SqlCommand(newcon, con);

                        cmd.ExecuteNonQuery();



                        MessageBox.Show("Registration Successful");

                    }
                }
            }
        }
    }
}
