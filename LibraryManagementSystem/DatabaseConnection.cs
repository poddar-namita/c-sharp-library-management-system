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
    class DatabaseConnection
    {
        public static SqlConnection con = null;
        public static SqlConnection connectDB()
        {
            try
            {
                con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=LibrarayManagementSystem;Integrated Security=True;Pooling=False");
                return con;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
    }
}
