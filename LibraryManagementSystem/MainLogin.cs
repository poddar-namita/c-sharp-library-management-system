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
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void btn_librarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianLogin Librarian = new LibrarianLogin();
            Librarian.Show();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin login = new AdminLogin();
            login.Show();
        }
    }
}
