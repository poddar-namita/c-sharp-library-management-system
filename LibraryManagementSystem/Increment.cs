using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    class Increment
    {
        public static SqlConnection con = null;

        public static int signUpIncrement()
        {
            int id = 1;
            con = DatabaseConnection.connectDB();
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select isnull(max(cast(approval_id as int)),0)+1 from admin_approval", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                id = Convert.ToInt32(dt.Rows[0][0].ToString()); 
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Application.Exit();
                return 0;
            }
        }

        public static int rejectionIncrement()
        {
            int id = 1;
            con = DatabaseConnection.connectDB();
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select isnull(max(cast(rejection_id as int)),0)+1 from rejected_accounts", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Application.Exit();
                return 0;
            }
        }

        public static int approvalIncrement()
        {
            int id = 1;
            con = DatabaseConnection.connectDB();
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select isnull(max(cast(user_id as int)),0)+1 from librarian", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Application.Exit();
                return 0;
            }
        }

        public static int bookIncrement()
        {
            int id = 1;
            con = DatabaseConnection.connectDB();
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select isnull(max(cast(book_id as int)),0)+1 from book", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Application.Exit();
                return 0;
            }
        }

        public static int studentIncrement()
        {
            int id = 1;
            con = DatabaseConnection.connectDB();
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select isnull(max(cast(student_id as int)),0)+1 from student", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Application.Exit();
                return 0;
            }
        }

        public static int issueBookIncrement()
        {
            int id = 1;
            con = DatabaseConnection.connectDB();
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select isnull(max(cast(issue_id as int)),0)+1 from issue_book", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Application.Exit();
                return 0;
            }
        }

        public static int returnBookIncrement()
        {
            int id = 1;
            con = DatabaseConnection.connectDB();
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select isnull(max(cast(return_id as int)),0)+1 from return_book", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Application.Exit();
                return 0;
            }
        }
    }
}
//if (dt.Rows.Count != 0)
//{
//    id = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
//}
//SqlCommand cmd = new SqlCommand("select max(user_id) from librarian", con);
//SqlDataReader dr = cmd.ExecuteReader();
//dr.Read();
//if(dr[0]!=null)
//{
//    id = int.Parse(dr[0].ToString()) + 1;
//}