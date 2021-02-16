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
    public partial class RejectedLibrarian : Form
    {
        SqlConnection con = null;
        public RejectedLibrarian()
        {
            InitializeComponent();
        }

        //navigate back
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome home = new AdminHome();
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

        private void RejectedLibrarian_Load(object sender, EventArgs e)
        {
            menu_user.Text = "";
            menu_user.Text = global.user;
            con = DatabaseConnection.connectDB();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select rejection_id,name,username from rejected_accounts", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_librarian.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void tb_searchLibrarian_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select rejection_id,name,username from rejected_accounts where name like '%" + tb_searchLibrarian.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_librarian.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
       
    }
}
