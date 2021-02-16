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
    public partial class ForgotPassword : Form
    {
        SqlConnection con = null;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        //navigate Back
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianLogin Librarian = new LibrarianLogin();
            Librarian.Show();
        }

        //search user
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                MessageBox.Show("Please enter username!");
            }
            else
            {
                try
                {
                    con = DatabaseConnection.connectDB();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from librarian where username='" + tb_username.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        tb_name.Text = dt.Rows[0]["name"].ToString();
                        tb_secQues.Text = dt.Rows[0]["sec_question"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        //retrive password
        private void btn_retrive_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == ""||tb_secQues.Text=="")
            {
                MessageBox.Show("Please enter username first and click the search button!");
            }
            else if (tb_ans.Text == "")
            {
                MessageBox.Show("Please enter your answer!");
            }
            else
            {
                try
                {
                    con = DatabaseConnection.connectDB();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from librarian where username='" + tb_username.Text + "' and answer='" + tb_ans.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        tb_password.Text = dt.Rows[0]["Password"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect answer!");
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
