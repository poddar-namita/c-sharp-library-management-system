namespace LibraryManagementSystem
{
    partial class DeleteLibrarian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_viewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_viewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_contact = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_user = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.tb_secQues = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_userid = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_librarian = new System.Windows.Forms.DataGridView();
            this.tb_searchLibrarian = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_librarian)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.menu_user});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 31);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_viewBook,
            this.menu_viewStudent,
            this.menu_exit});
            this.homeToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.icon_home;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(82, 27);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // menu_viewBook
            // 
            this.menu_viewBook.Image = global::LibraryManagementSystem.Properties.Resources.icon_viewBook;
            this.menu_viewBook.Name = "menu_viewBook";
            this.menu_viewBook.Size = new System.Drawing.Size(181, 26);
            this.menu_viewBook.Text = "View Books";
            this.menu_viewBook.Click += new System.EventHandler(this.menu_viewBook_Click);
            // 
            // menu_viewStudent
            // 
            this.menu_viewStudent.Image = global::LibraryManagementSystem.Properties.Resources.icon_viewStudent;
            this.menu_viewStudent.Name = "menu_viewStudent";
            this.menu_viewStudent.Size = new System.Drawing.Size(181, 26);
            this.menu_viewStudent.Text = "View Students";
            this.menu_viewStudent.Click += new System.EventHandler(this.menu_viewStudent_Click);
            // 
            // menu_exit
            // 
            this.menu_exit.Image = global::LibraryManagementSystem.Properties.Resources.icon_exit;
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(181, 26);
            this.menu_exit.Text = "Exit";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_contact,
            this.menu_about});
            this.helpToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.icon_help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(73, 27);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menu_contact
            // 
            this.menu_contact.Image = global::LibraryManagementSystem.Properties.Resources.icon_contactUs;
            this.menu_contact.Name = "menu_contact";
            this.menu_contact.Size = new System.Drawing.Size(181, 26);
            this.menu_contact.Text = "Contact Us";
            this.menu_contact.Click += new System.EventHandler(this.menu_contact_Click);
            // 
            // menu_about
            // 
            this.menu_about.Image = global::LibraryManagementSystem.Properties.Resources.icon_aboutUs;
            this.menu_about.Name = "menu_about";
            this.menu_about.Size = new System.Drawing.Size(181, 26);
            this.menu_about.Text = "About Us";
            this.menu_about.Click += new System.EventHandler(this.menu_about_Click);
            // 
            // menu_user
            // 
            this.menu_user.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu_user.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_logout});
            this.menu_user.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_user.Image = global::LibraryManagementSystem.Properties.Resources.icon_user;
            this.menu_user.Name = "menu_user";
            this.menu_user.Size = new System.Drawing.Size(75, 27);
            this.menu_user.Text = "user";
            // 
            // menu_logout
            // 
            this.menu_logout.Image = global::LibraryManagementSystem.Properties.Resources.icon_logout;
            this.menu_logout.Name = "menu_logout";
            this.menu_logout.Size = new System.Drawing.Size(181, 28);
            this.menu_logout.Text = "Logout";
            this.menu_logout.Click += new System.EventHandler(this.menu_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(296, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Delete Librarian";
            // 
            // btn_back
            // 
            this.btn_back.Image = global::LibraryManagementSystem.Properties.Resources.icon_back;
            this.btn_back.Location = new System.Drawing.Point(661, 79);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(56, 33);
            this.btn_back.TabIndex = 18;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_answer);
            this.panel1.Controls.Add(this.tb_secQues);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.tb_userid);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(8, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 202);
            this.panel1.TabIndex = 17;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = global::LibraryManagementSystem.Properties.Resources.icon_reject;
            this.btn_delete.Location = new System.Drawing.Point(583, 151);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(106, 37);
            this.btn_delete.TabIndex = 62;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Answer";
            // 
            // tb_answer
            // 
            this.tb_answer.Enabled = false;
            this.tb_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_answer.Location = new System.Drawing.Point(518, 107);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.PasswordChar = '*';
            this.tb_answer.Size = new System.Drawing.Size(171, 27);
            this.tb_answer.TabIndex = 59;
            // 
            // tb_secQues
            // 
            this.tb_secQues.Enabled = false;
            this.tb_secQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_secQues.Location = new System.Drawing.Point(518, 61);
            this.tb_secQues.Name = "tb_secQues";
            this.tb_secQues.PasswordChar = '*';
            this.tb_secQues.Size = new System.Drawing.Size(171, 27);
            this.tb_secQues.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Security Question";
            // 
            // tb_username
            // 
            this.tb_username.Enabled = false;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(139, 108);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(171, 27);
            this.tb_username.TabIndex = 56;
            // 
            // tb_password
            // 
            this.tb_password.Enabled = false;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(518, 21);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(171, 27);
            this.tb_password.TabIndex = 55;
            // 
            // tb_userid
            // 
            this.tb_userid.Enabled = false;
            this.tb_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userid.Location = new System.Drawing.Point(139, 18);
            this.tb_userid.Name = "tb_userid";
            this.tb_userid.Size = new System.Drawing.Size(171, 27);
            this.tb_userid.TabIndex = 54;
            // 
            // tb_name
            // 
            this.tb_name.Enabled = false;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(139, 61);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(171, 27);
            this.tb_name.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "User Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Name";
            // 
            // dgv_librarian
            // 
            this.dgv_librarian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_librarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_librarian.Location = new System.Drawing.Point(8, 131);
            this.dgv_librarian.Name = "dgv_librarian";
            this.dgv_librarian.RowTemplate.Height = 24;
            this.dgv_librarian.Size = new System.Drawing.Size(709, 207);
            this.dgv_librarian.TabIndex = 16;
            this.dgv_librarian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_librarian_CellClick);
            // 
            // tb_searchLibrarian
            // 
            this.tb_searchLibrarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchLibrarian.Location = new System.Drawing.Point(161, 85);
            this.tb_searchLibrarian.Name = "tb_searchLibrarian";
            this.tb_searchLibrarian.Size = new System.Drawing.Size(171, 27);
            this.tb_searchLibrarian.TabIndex = 21;
            this.tb_searchLibrarian.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_searchLibrarian_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Search Librarian";
            // 
            // DeleteLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 569);
            this.Controls.Add(this.tb_searchLibrarian);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_librarian);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DeleteLibrarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Librarian";
            this.Load += new System.EventHandler(this.DeleteLibrarian_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_librarian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_contact;
        private System.Windows.Forms.ToolStripMenuItem menu_about;
        private System.Windows.Forms.ToolStripMenuItem menu_user;
        private System.Windows.Forms.ToolStripMenuItem menu_logout;
        private System.Windows.Forms.ToolStripMenuItem menu_viewBook;
        private System.Windows.Forms.ToolStripMenuItem menu_viewStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.TextBox tb_secQues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_userid;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_librarian;
        private System.Windows.Forms.TextBox tb_searchLibrarian;
        private System.Windows.Forms.Label label6;
    }
}