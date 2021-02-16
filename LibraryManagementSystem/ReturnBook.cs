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
    public partial class ReturnBook : Form
    {
        SqlConnection con = null;
        String date;
        public ReturnBook()
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

        //load gridview
        public void dgv_fill()
        {
            try
            {
                con = DatabaseConnection.connectDB();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from issue_book", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_issuebook.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //page load
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            menu_user.Text = "";
            menu_user.Text = global.user;
            date_return.Value = DateTime.Today;
            panel1.Visible = false;
            con = DatabaseConnection.connectDB();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dgv_fill();
        }

        //search enrollment no
        private void tb_searchenroll_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from issue_book where enrollment_no like '%" + tb_searchenroll.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_issuebook.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //select issue details
        private void dgv_issuebook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            int i;
            i = Convert.ToInt32(dgv_issuebook.SelectedCells[0].Value.ToString());
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from issue_book where issue_id= '" + i + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    tb_enrollment.Text = dr["enrollment_no"].ToString();
                    tb_studentName.Text = dr["student_name"].ToString();
                    tb_studentId.Text = dr["student_id"].ToString();
                    tb_course.Text = dr["course"].ToString();
                    tb_year.Text = dr["year"].ToString();
                    tb_sem.Text = dr["semester"].ToString();
                    tb_contact.Text = dr["contact"].ToString();
                    tb_bookId.Text = dr["book_id"].ToString();
                    tb_bookName.Text = dr["book_name"].ToString();
                    tb_edition.Text = dr["edition"].ToString();
                    tb_publisher.Text = dr["publisher"].ToString();
                    tb_issueId.Text = dr["issue_id"].ToString();
                    tb_dateOfIssue.Text = dr["date_of_issue"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //delete from issue table
        private void delete()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Delete from issue_book where issue_id='"+tb_issueId.Text+"'", con);
                int result = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //insert into return table
        private void returnBook()
        {
            int id = Increment.returnBookIncrement();
            if (Convert.ToDateTime(date_return.Text) < DateTime.Today || Convert.ToDateTime(date_return.Text) > DateTime.Today)
            {
                MessageBox.Show("You can not return book on previous or future dates!! Please select today's date!!");
            }
            else
            {
                try
                {
                    //insert in return table
                    date = date_return.Text;
                    SqlCommand cmd = new SqlCommand("Insert into return_book values('" + id + "','" + tb_bookId.Text + "','" + tb_bookName.Text + "','" + tb_edition.Text + "','" + tb_publisher.Text+ "','" + tb_studentId.Text + "','" + tb_enrollment.Text + "','" + tb_studentName.Text + "','" + tb_course.Text + "','" + tb_year.Text + "','" + tb_sem.Text + "','" + tb_contact.Text + "','" + tb_dateOfIssue.Text + "','" + date + "')", con);
                    int result = cmd.ExecuteNonQuery();
                    //increase quantity
                    SqlCommand cmd1 = new SqlCommand("update book set available_qty=available_qty+1 where book_id='" + tb_bookId.Text + "'", con);
                    cmd1.ExecuteNonQuery();
                    if (result == 1)
                    {
                        delete();
                        MessageBox.Show("Book Returned!");
                        tb_bookName.Text = "";
                        tb_bookId.Text = "";
                        tb_edition.Text = "";
                        tb_publisher.Text = "";
                        tb_enrollment.Text = "";
                        tb_studentName.Text = "";
                        tb_studentId.Text = "";
                        tb_course.Text = "";
                        tb_year.Text = "";
                        tb_sem.Text = "";
                        tb_contact.Text = "";
                        tb_issueId.Text = "";
                        tb_dateOfIssue.Text = "";
                        
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong!");
                    }
                    panel1.Visible = false;
                    dgv_fill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }    
            }   
        }

        //return book
        private void btn_return_Click(object sender, EventArgs e)
        {
            returnBook();
        }   
    }
}
