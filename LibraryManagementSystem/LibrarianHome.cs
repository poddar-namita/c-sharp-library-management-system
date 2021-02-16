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
    public partial class LibrarianHome : Form
    {
        public LibrarianHome()
        {
            InitializeComponent();
        }

        //Page Load
        private void LibrarianHome_Load(object sender, EventArgs e)
        {
            menu_user.Text = "";
            menu_user.Text = global.user;
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

        //Operations
        //new book
        private void btn_newBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewBook newBook = new NewBook();
            newBook.Show();
        }

        //statistics
        private void btn_statistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics stat = new Statistics();
            stat.Show();
        }

        //new student
        private void btn_newStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewStudent student = new NewStudent();
            student.Show();
        }

        //issue book
        private void btn_issue_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBook issue = new IssueBook();
            //testIssueBook issue = new testIssueBook();
            issue.Show();
        }

        //return book
        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBook returnbook =new ReturnBook();
            //testReturn returnbook = new testReturn();
            returnbook.Show();
        }

        //about us
        private void btn_about_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs about = new AboutUs();
            about.Show();
        }   
    }
}
