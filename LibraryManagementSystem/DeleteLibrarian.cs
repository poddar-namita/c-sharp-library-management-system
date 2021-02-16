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
    public partial class DeleteLibrarian : Form
    {
        SqlConnection con = null;
        public DeleteLibrarian()
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

        public void dgv_load()
        {
            SqlDataAdapter da = new SqlDataAdapter("select user_id,name,username from librarian", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_librarian.DataSource = dt;
        }

        //page load
        private void DeleteLibrarian_Load(object sender, EventArgs e)
        {
            menu_user.Text = "";
            menu_user.Text = global.user;
            panel1.Visible = false;
            con = DatabaseConnection.connectDB();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dgv_load();
        }

        private void tb_searchLibrarian_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select user_id,name,username from librarian where name like '%" + tb_searchLibrarian.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_librarian.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgv_librarian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            int i;
            i = Convert.ToInt32(dgv_librarian.SelectedCells[0].Value.ToString());
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from librarian where user_id= '" + i + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    tb_userid.Text = dr["user_id"].ToString();
                    tb_name.Text = dr["name"].ToString();
                    tb_username.Text = dr["username"].ToString();
                    tb_password.Text = dr["password"].ToString();
                    tb_secQues.Text = dr["sec_question"].ToString();
                    tb_answer.Text = dr["answer"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void delete()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Delete from librarian where user_id='" + tb_userid.Text + "'", con);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("User Account Deleted!");
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
                panel1.Visible = false;
                dgv_load();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                delete();
            }
        }
        


    }
}
