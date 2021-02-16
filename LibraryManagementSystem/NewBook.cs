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
    public partial class NewBook : Form
    {
        SqlConnection con = null;
        
        public NewBook()
        {
            InitializeComponent();
        }

        //Page Load
        private void NewBook_Load(object sender, EventArgs e)
        {
            menu_user.Text = "";
            menu_user.Text = global.user;
            tb_bookId.Text = Increment.bookIncrement().ToString();
        }
        //Navigate Back
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

       //add book
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_publisher.Text == "" || tb_price.Text== ""||tb_quantity.Text=="")
            {
                MessageBox.Show("All fields are mandatory");
            }
            else
            {
                try
                {
                    con = DatabaseConnection.connectDB();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into book values('" + tb_bookId.Text + "','" + tb_name.Text + "','" + cb_edition.Text + "','" + tb_publisher.Text + "','" + date_of_purchase.Text + "','" + tb_price.Text + "','" + tb_quantity.Text + "','" + tb_quantity.Text + "')", con);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("New Book Added!!");
                        tb_bookId.Text = Increment.bookIncrement().ToString();
                        tb_name.Text = "";
                        cb_edition.Text = "1";
                        tb_publisher.Text = "";
                        tb_price.Text = "";
                        tb_quantity.Text = "";
                        date_of_purchase.Value = DateTime.Today;
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong!!");
                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   
        }  
    }
}
