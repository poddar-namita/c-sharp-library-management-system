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
    public partial class ApproveLibrarian : Form
    {
        SqlConnection con = null;
        public ApproveLibrarian()
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

        public void load_dgv()
        {
            SqlDataAdapter da = new SqlDataAdapter("select approval_id,name,username from admin_approval",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_pendingApproval.DataSource = dt;
        }

        //page load
        private void ApproveLibrarian_Load(object sender, EventArgs e)
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
            load_dgv();
        }

        //select user details
        private void dgv_pendingApproval_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            int i;
            i = Convert.ToInt32(dgv_pendingApproval.SelectedCells[0].Value.ToString());
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from admin_approval where approval_id= '" + i + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    tb_approvalid.Text = dr["approval_id"].ToString();
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

        //delete from issue table
        private void delete()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Delete from admin_approval where approval_id='" + tb_approvalid.Text + "'", con);
                int result = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //insert into librarian table
        private void approveAccount()
        {
            int id = Increment.approvalIncrement();
            try
            {
                //insert in librarian table
                SqlCommand cmd = new SqlCommand("Insert into librarian values('" + id + "','" + tb_name.Text + "','" + tb_username.Text + "','" + tb_password.Text + "','" + tb_secQues.Text + "','" + tb_answer.Text + "')", con);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    delete();
                    MessageBox.Show("Account Approved!");
                    tb_approvalid.Text = "";
                    tb_name.Text = "";
                    tb_username.Text = "";
                    tb_password.Text = "";
                    tb_secQues.Text = "";
                    tb_answer.Text = "";
                    panel1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Something Went Wrong!");
                }
                panel1.Visible = false;
                load_dgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //insert into rejection table
        private void rejectAccount()
        {
            int id = Increment.rejectionIncrement();
            try
            {
                //insert in librarian table
                SqlCommand cmd = new SqlCommand("Insert into rejected_accounts values('" + id + "','" + tb_name.Text + "','" + tb_username.Text + "','" + tb_password.Text + "','" + tb_secQues.Text + "','" + tb_answer.Text + "')", con);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    delete();
                    MessageBox.Show("Account Rejected!");
                    tb_approvalid.Text = "";
                    tb_name.Text = "";
                    tb_username.Text = "";
                    tb_password.Text = "";
                    tb_secQues.Text = "";
                    tb_answer.Text = "";
                    panel1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Something Went Wrong!");
                }
                panel1.Visible = false;
                load_dgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //approve account
        private void btn_approve_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Approve Account", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                approveAccount();
            }
        }

        //reject account
        private void btn_reject_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Reject Account", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                rejectAccount();
            }
        }

        
    }
}
