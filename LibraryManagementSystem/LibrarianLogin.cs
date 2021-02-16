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
    public partial class LibrarianLogin : Form
    {
        SqlConnection con = null;
        public LibrarianLogin()
        {
            InitializeComponent();
        }

        //SignUp
        private void btn_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp();
            signup.Show();
        }

        //Navigate back
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLogin mainlogin = new MainLogin();
            mainlogin.Show();
        }

        //Forgot Password
        private void btn_forgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotpassword = new ForgotPassword();
            forgotpassword.Show();
        }

        //Login
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
                    //librarian data
                    SqlDataAdapter da = new SqlDataAdapter("select * from librarian where username ='" + tb_username.Text + "'  and password ='" + tb_password.Text + "' ", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //approval data
                    SqlDataAdapter da1 = new SqlDataAdapter("select * from admin_approval where username ='" + tb_username.Text + "'  and password ='" + tb_password.Text + "' ", con);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    //rejected data
                    SqlDataAdapter da2 = new SqlDataAdapter("select * from rejected_accounts where username ='" + tb_username.Text + "'  and password ='" + tb_password.Text + "' ", con);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);

                    if (dt.Rows.Count != 0)
                    {
                        global.user = dt.Rows[0]["name"].ToString();
                        this.Hide();
                        LibrarianHome home = new LibrarianHome();
                        home.Show();
                    }
                    else if (dt1.Rows.Count != 0)
                    {
                        MessageBox.Show("Account is not yet approved by the admin!");
                    }
                    else if (dt2.Rows.Count != 0)
                    {
                        MessageBox.Show("Your Account approval request has been rejected!");
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
    }
}
