using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
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
        private void AdminHome_Load(object sender, EventArgs e)
        {
            menu_user.Text = "";
            menu_user.Text = global.user;
        }

        //operations
        private void btn_viewLibrarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewLibrarian view = new ViewLibrarian();
            view.Show();
        }

        private void btn_deleteLibrarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteLibrarian delete = new DeleteLibrarian();
            delete.Show();
        }

        private void btn_approveLibrarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApproveLibrarian approve = new ApproveLibrarian();
            approve.Show();
        }

        private void btn_rejected_Click(object sender, EventArgs e)
        {
            this.Hide();
            RejectedLibrarian reject = new RejectedLibrarian();
            reject.Show();
        }

        private void btn_dataAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataAnalysis da = new DataAnalysis();
            da.Show();
        }
    }
}
