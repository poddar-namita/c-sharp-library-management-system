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
    public partial class NewStudent : Form
    {
        SqlConnection con = null;
        public NewStudent()
        {
            InitializeComponent();
        }

        //navigate back
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianHome home = new LibrarianHome();
            home.Show();
        }

        //Menu Click Events
        private void menu_viewBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBook book = new ViewBook();
            book.Show();
        }

        private void menu_viewStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStudent student = new ViewStudent();
            student.Show();
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Really Want to Exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menu_contact_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs contact = new ContactUs();
            contact.Show();
        }

        private void menu_about_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs about = new AboutUs();
            about.Show();
        }

        private void menu_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Logout?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                MainLogin login = new MainLogin();
                login.Show();
            }
        }
        //end of menu events

        //combo box manipulation
        private void cb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_year.SelectedItem.ToString() == "1")
            {
                cb_sem.Items.Clear();
                cb_sem.Items.Add("1");
                cb_sem.Items.Add("2");
            }
            else if (cb_year.SelectedItem.ToString() == "2")
            {
                cb_sem.Items.Clear();
                cb_sem.Text = "3";
                cb_sem.Items.Add("3");
                cb_sem.Items.Add("4");
            }
            else if (cb_year.SelectedItem.ToString() == "3")
            {
                cb_sem.Items.Clear();
                cb_sem.Text = "5";
                cb_sem.Items.Add("5");
                cb_sem.Items.Add("6");
            }
        }

        //page load
        private void NewStudent_Load(object sender, EventArgs e)
        {
            int id = Increment.studentIncrement();
            tb_studentId.Text = id.ToString();
            menu_user.Text = "";
            menu_user.Text = global.user;
            tb_name.Focus();
            con = DatabaseConnection.connectDB();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

        }

        //add student
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_enrollment.Text==""||tb_contact.Text==""||tb_name.Text=="")
            {
                MessageBox.Show("All fields are mandatory");
            }
            else
            {
                if (tb_contact.TextLength > 10 || tb_contact.TextLength < 10)
                {
                    MessageBox.Show("Contact no should be of 10 digits");
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from student where enrollment_no='" + tb_enrollment.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        MessageBox.Show("Enrollment No exist in the database.Please enter unique No!");
                    }
                    else
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("Insert into student values('" + tb_studentId.Text + "','" + tb_enrollment.Text + "','" + tb_name.Text + "','" + cb_course.Text + "','" + cb_year.Text + "','" + cb_sem.Text + "','" + tb_contact.Text + "')", con);
                            int result = cmd.ExecuteNonQuery();
                            if (result == 1)
                            {
                                MessageBox.Show("New Student Added!!");
                                tb_studentId.Text = Increment.studentIncrement().ToString();
                                tb_enrollment.Text = "";
                                cb_course.SelectedItem = "MCA";
                                cb_year.SelectedItem = "1";
                                cb_sem.SelectedItem = "1";
                                tb_contact.Text = "";
                                tb_name.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Something Went Wrong!!");
                            }  
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }                  
                }              
            }   
        }
    }
}
