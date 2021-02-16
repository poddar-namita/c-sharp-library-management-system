namespace LibraryManagementSystem
{
    partial class ViewStudent
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
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_enrollment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_sem = new System.Windows.Forms.ComboBox();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.cb_course = new System.Windows.Forms.ComboBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_studentId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update_record = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.tb_searchStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Image = global::LibraryManagementSystem.Properties.Resources.icon_back;
            this.btn_back.Location = new System.Drawing.Point(761, 40);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(46, 30);
            this.btn_back.TabIndex = 14;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_enrollment);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_contact);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cb_sem);
            this.panel1.Controls.Add(this.cb_year);
            this.panel1.Controls.Add(this.cb_course);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.tb_studentId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_update_record);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(16, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 224);
            this.panel1.TabIndex = 13;
            // 
            // tb_enrollment
            // 
            this.tb_enrollment.Enabled = false;
            this.tb_enrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_enrollment.Location = new System.Drawing.Point(167, 90);
            this.tb_enrollment.Name = "tb_enrollment";
            this.tb_enrollment.ReadOnly = true;
            this.tb_enrollment.Size = new System.Drawing.Size(182, 27);
            this.tb_enrollment.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Enrollment No";
            // 
            // tb_contact
            // 
            this.tb_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contact.Location = new System.Drawing.Point(583, 124);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(181, 27);
            this.tb_contact.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Contact";
            // 
            // cb_sem
            // 
            this.cb_sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sem.FormattingEnabled = true;
            this.cb_sem.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_sem.Location = new System.Drawing.Point(583, 80);
            this.cb_sem.Name = "cb_sem";
            this.cb_sem.Size = new System.Drawing.Size(181, 28);
            this.cb_sem.TabIndex = 42;
            this.cb_sem.Text = "1";
            // 
            // cb_year
            // 
            this.cb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_year.Location = new System.Drawing.Point(582, 37);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(182, 28);
            this.cb_year.TabIndex = 41;
            this.cb_year.Text = "1";
            // 
            // cb_course
            // 
            this.cb_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_course.FormattingEnabled = true;
            this.cb_course.Items.AddRange(new object[] {
            "MCA",
            "M.Tech",
            "MSC",
            "MBA"});
            this.cb_course.Location = new System.Drawing.Point(167, 178);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(182, 28);
            this.cb_course.TabIndex = 40;
            this.cb_course.Text = "MCA";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(167, 132);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(182, 27);
            this.tb_name.TabIndex = 39;
            // 
            // tb_studentId
            // 
            this.tb_studentId.Enabled = false;
            this.tb_studentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_studentId.Location = new System.Drawing.Point(167, 47);
            this.tb_studentId.Name = "tb_studentId";
            this.tb_studentId.ReadOnly = true;
            this.tb_studentId.Size = new System.Drawing.Size(182, 27);
            this.tb_studentId.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Student ID";
            // 
            // btn_update_record
            // 
            this.btn_update_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_record.Location = new System.Drawing.Point(673, 169);
            this.btn_update_record.Name = "btn_update_record";
            this.btn_update_record.Size = new System.Drawing.Size(91, 30);
            this.btn_update_record.TabIndex = 32;
            this.btn_update_record.Text = "Update";
            this.btn_update_record.UseVisualStyleBackColor = true;
            this.btn_update_record.Click += new System.EventHandler(this.btn_update_record_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Update Record";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(611, 40);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(137, 30);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Update record?";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_student
            // 
            this.dgv_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Location = new System.Drawing.Point(16, 83);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.RowTemplate.Height = 24;
            this.dgv_student.Size = new System.Drawing.Size(791, 211);
            this.dgv_student.TabIndex = 11;
            this.dgv_student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_student_CellClick);
            // 
            // tb_searchStudent
            // 
            this.tb_searchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchStudent.Location = new System.Drawing.Point(146, 43);
            this.tb_searchStudent.Name = "tb_searchStudent";
            this.tb_searchStudent.Size = new System.Drawing.Size(171, 27);
            this.tb_searchStudent.TabIndex = 10;
            this.tb_searchStudent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_student);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Student";
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
            this.menuStrip1.Size = new System.Drawing.Size(819, 31);
            this.menuStrip1.TabIndex = 8;
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
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 551);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dgv_student);
            this.Controls.Add(this.tb_searchStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ViewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_update_record;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.TextBox tb_searchStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_viewBook;
        private System.Windows.Forms.ToolStripMenuItem menu_viewStudent;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_contact;
        private System.Windows.Forms.ToolStripMenuItem menu_about;
        private System.Windows.Forms.ToolStripMenuItem menu_user;
        private System.Windows.Forms.ToolStripMenuItem menu_logout;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_sem;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.ComboBox cb_course;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_studentId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_enrollment;
        private System.Windows.Forms.Label label8;
    }
}