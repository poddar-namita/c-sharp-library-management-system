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
using System.IO;

namespace LibraryManagementSystem
{
    public partial class DataAnalysis : Form
    {
        SqlConnection con = null;
        public DataAnalysis()
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

        private void DataAnalysis_Load(object sender, EventArgs e)
        {
            menu_user.Text = global.user;
            con = DatabaseConnection.connectDB();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select distinct enrollment_no from issue_book", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    int enroll = Convert.ToInt32(dr["enrollment_no"].ToString());
                    SqlDataAdapter da1 = new SqlDataAdapter("Select distinct book_name from issue_book where enrollment_no='" + enroll + "'", con);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        textBox1.Text = textBox1.Text +" " + dr1["book_name"].ToString();
                    }
                    textBox1.Text = textBox1.Text+Environment.NewLine;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\";
            sfd.RestoreDirectory = true;
            sfd.Filter = "Text|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream filestream = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(filestream);
                sw.Write(textBox1.Text);
                sw.Close();
                filestream.Close();
            }
        }

        private void btn_association_Click(object sender, EventArgs e)
        {
            this.Hide();
            AprioriForm apriori = new AprioriForm();
            apriori.Show();
        }
        
    }
}
