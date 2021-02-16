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
    public partial class IssueBook : Form
    {
        SqlConnection con = null;
        String date;
        int qty;
        public IssueBook()
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

        //load combo box
        public void loadCombo()
        {
            //set combobox values
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select distinct book_name from book", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cb_bookName.Items.Add(dr["book_name"].ToString());
                    cb_bookName.Text = dt.Rows[0]["book_name"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //page load
        private void IssueBook_Load(object sender, EventArgs e)
        {
            menu_user.Text = "";
            menu_user.Text = global.user;
            date_issue.Value = DateTime.Today;
            //database connection 
            con = DatabaseConnection.connectDB();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            loadCombo();
        }

        //load combo box 2
        private void cb_bookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string book = cb_bookName.SelectedItem.ToString();
            cb_edition.Items.Clear();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select distinct edition from book where book_name='" + book + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cb_edition.Items.Add(dr["edition"].ToString());
                    cb_edition.Text = dt.Rows[0]["edition"].ToString();
                }
                //comboBox1.Text = dt.Rows[0]["book_name"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //load combo box 3
        private void cb_edition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string book = cb_bookName.SelectedItem.ToString();
            int edition = Convert.ToInt32(cb_edition.SelectedItem.ToString());
            cb_publisher.Items.Clear();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select distinct publisher from book where book_name='" + book + "' and edition='" + edition + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cb_publisher.Items.Add(dr["publisher"].ToString());
                    cb_publisher.Text = dt.Rows[0]["publisher"].ToString();
                }
                //comboBox1.Text = dt.Rows[0]["book_name"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //search book
        private void btn_searchBook_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from book where book_name='" + cb_bookName.Text + "' and edition='" + cb_edition.Text + "' and publisher='" + cb_publisher.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    tb_bookId.Text = dt.Rows[0]["book_id"].ToString();
                    qty = Convert.ToInt32(dt.Rows[0]["available_qty"].ToString());
                }
                else
                {
                    MessageBox.Show("Invalid details!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //search student
        private void btn_searchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from student where enrollment_no='" + tb_enrollment.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    tb_studentName.Text = dt.Rows[0]["student_name"].ToString();
                    tb_studentId.Text = dt.Rows[0]["student_id"].ToString();
                    tb_course.Text = dt.Rows[0]["course"].ToString();
                    tb_year.Text = dt.Rows[0]["year"].ToString();
                    tb_sem.Text = dt.Rows[0]["semester"].ToString();
                    tb_contact.Text = dt.Rows[0]["contact"].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Enrollment ID!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //issue book
        private void btn_issue_Click(object sender, EventArgs e)
        {
            if (tb_studentName.Text == "")
            {
                MessageBox.Show("Please select student name");
            }
            else
            {
                if (Convert.ToDateTime(date_issue.Text) < DateTime.Today || Convert.ToDateTime(date_issue.Text) > DateTime.Today)
                {
                    MessageBox.Show("You can not issue book on previous or future dates!! Please select today's date!!");
                }
                else
                {
                    if (qty == 0)
                    {
                        MessageBox.Show("Books out of stock!");
                    }
                    else
                    {
                        try
                        {
                            //insert in issue book table
                            date = date_issue.Text;
                            int id = Increment.issueBookIncrement();
                            SqlCommand cmd = new SqlCommand("Insert into issue_book values('" + id + "','" + tb_bookId.Text + "','" + cb_bookName.Text + "','" + cb_edition.Text + "','" + cb_publisher.Text + "','" + tb_studentId.Text + "','" + tb_enrollment.Text + "','" + tb_studentName.Text + "','" + tb_course.Text + "','" + tb_year.Text + "','" + tb_sem.Text + "','" + tb_contact.Text + "','" + date + "')", con);
                            int result = cmd.ExecuteNonQuery();
                            //decrease quantity
                            SqlCommand cmd1 = new SqlCommand("update book set available_qty=available_qty-1 where book_id='" + tb_bookId.Text + "'", con);
                            cmd1.ExecuteNonQuery();

                            if (result == 1)
                            {
                                MessageBox.Show("Book Issued!");
                                cb_bookName.Items.Clear();
                                loadCombo();
                                tb_bookId.Text = "";
                                tb_enrollment.Text = "";
                                tb_studentName.Text = "";
                                tb_studentId.Text = "";
                                tb_course.Text = "";
                                tb_year.Text = "";
                                tb_sem.Text = "";
                                tb_contact.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Something Went Wrong!");
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

        //auto complete enrollment no
        private void tb_enrollment_Enter(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select enrollment_no from student", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dt.Rows)
                {
                    collection.Add(dr["enrollment_no"].ToString());
                }
                
                tb_enrollment.AutoCompleteCustomSource = collection;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
 
    }
}
