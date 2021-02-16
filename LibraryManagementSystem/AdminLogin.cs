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

namespace LibraryManagementSystem
{
    public partial class AdminLogin : Form
    {
        SqlConnection con = null;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "" || tb_password.Text == "")
            {
                MessageBox.Show("Username and Password cannot be empty!");
            }
            else
            {
                try
                {
                    con = DatabaseConnection.connectDB();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from admin where admin_name ='" + tb_username.Text + "'  and admin_password ='" + tb_password.Text + "' ", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        global.user = dt.Rows[0]["admin_name"].ToString();
                        this.Hide();
                        AdminHome home = new AdminHome();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLogin login = new MainLogin();
            login.Show();
        }
    }
}
