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
    public partial class Statistics : Form
    {
        SqlConnection con = null;

        public Statistics()
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

        //page load
        private void Statistics_Load(object sender, EventArgs e)
        {
            menu_user.Text = "";
            menu_user.Text = global.user;
            try
            {
                con = DatabaseConnection.connectDB();
                con.Open();
                //Issue Details
                SqlDataAdapter da1 = new SqlDataAdapter("Select * from issue_book", con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dgv_issue.DataSource = dt1;
                //Return Details
                SqlDataAdapter da2 = new SqlDataAdapter("Select * from return_book", con);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dgv_return.DataSource = dt2;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
