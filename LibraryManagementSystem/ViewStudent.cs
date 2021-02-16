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
    public partial class ViewStudent : Form
    {
        SqlConnection con = null;
        public ViewStudent()
        {
            InitializeComponent();
        }

        //navigate back
        private void btn_back_Click(object sender, EventArgs e)
        {
            if (global.user == "admin")
            {
                this.Hide();
                AdminHome Adminhome = new AdminHome();
                Adminhome.Show();

            }
            else
            {
                this.Hide();
                LibrarianHome home = new LibrarianHome();
                home.Show();
            }  
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

        //display student function
        public void disp_student()
        {
            try
            {
                con = DatabaseConnection.connectDB();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from student", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_student.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //page load
        private void ViewStudent_Load(object sender, EventArgs e)
        {
            menu_user.Text = "";
            menu_user.Text = global.user;
            panel1.Visible = false;
            disp_student();
            con = DatabaseConnection.connectDB();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        //search student
        private void search_student(object sender, KeyEventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from student where student_name like '%" + tb_searchStudent.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_student.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //view update panel
        private void btn_update_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        //data retrieval in update panel
        private void dgv_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(dgv_student.SelectedCells[0].Value.ToString());
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from student where student_id= '" + i + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    tb_studentId.Text = dr["student_id"].ToString();
                    tb_enrollment.Text = dr["enrollment_no"].ToString();
                    tb_name.Text = dr["student_name"].ToString();
                    cb_course.Text = dr["course"].ToString();
                    cb_year.Text = dr["year"].ToString();
                    cb_sem.Text = dr["semester"].ToString();
                    tb_contact.Text = dr["contact"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_update_record_Click(object sender, EventArgs e)
        {
            if (tb_contact.TextLength > 10)
            {
                MessageBox.Show("Contact no cannot be more than 10 digits");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update student set enrollment_no='" + tb_enrollment.Text + "',student_name='" + tb_name.Text + "', course='" + cb_course.Text + "',year='" + cb_year.Text + "',semester='" + cb_sem.Text + "',contact='" + tb_contact.Text + "' where student_id= '" + tb_studentId.Text + "'", con);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Record Updated!");
                        disp_student();
                        panel1.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Record Updation failed!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            
        }

    }
}
