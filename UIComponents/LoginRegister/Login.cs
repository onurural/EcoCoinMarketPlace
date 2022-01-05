using EcoCoinMarketPlace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EcoCoinMarket.Models.LoginRegister
{
    public partial class Login : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Form1 home = new Form1(true);
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Desktop\EcoCoinV2.0\EcoCoinMarketPlace\Users.mdf;Integrated Security=True");
            cn.Open();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registration = new Register();
            registration.ShowDialog();
        }

        private void Unregistered_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Thread.Sleep(1000);
            Form1 home = new Form1(false);
            home.ShowDialog();
            this.Hide();

        }
    }
    }

