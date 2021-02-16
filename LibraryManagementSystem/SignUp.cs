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
    public partial class SignUp : Form
    {
        SqlConnection con = null;
        public SignUp()
        {
            InitializeComponent();
        }

        //Navigate Back
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianLogin Librarian = new LibrarianLogin();
            Librarian.Show();
        }
        
        //create librarian account
        private void btn_create_Click(object sender, EventArgs e)
        {

            if (tb_name.Text == "" || tb_username.Text == "" || tb_password.Text == "" || tb_ans.Text == "")
            {
                MessageBox.Show("All fields are mandatory");
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from librarian where username='" + tb_username.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlDataAdapter da1 = new SqlDataAdapter("select * from admin_approval where username='" + tb_username.Text + "'", con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("Username already taken! Select another username!");
                }
                else if(dt1.Rows.Count != 0)
                {
                    MessageBox.Show("Username already taken! Select another username!");
                }
                else
                {
                    try
                    {
                        int id = Increment.signUpIncrement();
                        SqlCommand cmd = new SqlCommand("Insert into admin_approval values('" + id + "','" + tb_name.Text + "','" + tb_username.Text + "','" + tb_password.Text + "','" + cb_question.Text + "','" + tb_ans.Text + "')", con);
                        int result = cmd.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("Account is being processed!! Account will be activated after approval!");
                            this.Hide();
                            LibrarianLogin login = new LibrarianLogin();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Account Creation Failed!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }  
            }    
        }

        //page load
        private void SignUp_Load(object sender, EventArgs e)
        {
            con = DatabaseConnection.connectDB();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
    }
}
