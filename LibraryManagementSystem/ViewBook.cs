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
    public partial class ViewBook : Form
    {
        SqlConnection con = null;
        public ViewBook()
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

        //display book function
        public void disp_books()
        {
            try
            {
                con = DatabaseConnection.connectDB();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from book", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_books.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //page load
        private void ViewBook_Load(object sender, EventArgs e)
        {
            menu_user.Text = "";
            menu_user.Text = global.user;
            panel1.Visible = false;
            disp_books();
        }

        //search book
        private void search_book(object sender, KeyEventArgs e)
        {
            try
            {
                con = DatabaseConnection.connectDB();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from book where book_name like '%"+tb_searchBook.Text+"%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_books.DataSource = dt;

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
        private void dgv_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(dgv_books.SelectedCells[0].Value.ToString());
            try
            {
                con = DatabaseConnection.connectDB();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from book where book_id= '" + i + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    tb_bookId.Text = dr["book_id"].ToString();
                    tb_name.Text = dr["book_name"].ToString();
                    cb_edition.Text = dr["edition"].ToString();
                    tb_publisher.Text = dr["publisher"].ToString();
                    date_of_purchase.Value = Convert.ToDateTime(dr["date_of_purchase"].ToString());
                    tb_price.Text = dr["price"].ToString();
                    tb_quantity.Text = dr["quantity"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //update record
        private void btn_update_record_Click(object sender, EventArgs e)
        {
            try
            {
                int difference,quantity,available;
                con = DatabaseConnection.connectDB();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from book where book_id= '" + tb_bookId.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                quantity = int.Parse(dt.Rows[0][6].ToString());
                available = int.Parse(dt.Rows[0][7].ToString());
                difference = quantity - available;
                int newavailable = Convert.ToInt32(int.Parse(tb_quantity.Text)-difference);
                //update
                SqlCommand cmd = new SqlCommand("update book set book_name='" + tb_name.Text + "', edition='" + cb_edition.Text + "',publisher='" + tb_publisher.Text + "',date_of_purchase='" + date_of_purchase.Text + "',price='" + tb_price.Text + "',quantity='" + tb_quantity.Text + "',available_qty='"+newavailable+"' where book_id= '" + tb_bookId.Text + "'", con);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Updated!");
                    disp_books();
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
