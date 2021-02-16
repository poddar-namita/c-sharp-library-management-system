namespace LibraryManagementSystem
{
    partial class ReturnBook
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
            this.date_return = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_issuebook = new System.Windows.Forms.DataGridView();
            this.tb_searchenroll = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_enrollment = new System.Windows.Forms.TextBox();
            this.tb_sem = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.tb_course = new System.Windows.Forms.TextBox();
            this.tb_studentName = new System.Windows.Forms.TextBox();
            this.tb_studentId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dateOfIssue = new System.Windows.Forms.TextBox();
            this.tb_issueId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_edition = new System.Windows.Forms.TextBox();
            this.tb_publisher = new System.Windows.Forms.TextBox();
            this.tb_bookName = new System.Windows.Forms.TextBox();
            this.tb_bookId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_issuebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(933, 31);
            this.menuStrip1.TabIndex = 5;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(404, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Return Book";
            // 
            // date_return
            // 
            this.date_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_return.Location = new System.Drawing.Point(444, 375);
            this.date_return.Name = "date_return";
            this.date_return.Size = new System.Drawing.Size(130, 27);
            this.date_return.TabIndex = 10;
            this.date_return.Value = new System.DateTime(2020, 4, 25, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(289, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Date of Return";
            // 
            // dgv_issuebook
            // 
            this.dgv_issuebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_issuebook.Location = new System.Drawing.Point(23, 157);
            this.dgv_issuebook.Name = "dgv_issuebook";
            this.dgv_issuebook.RowTemplate.Height = 24;
            this.dgv_issuebook.Size = new System.Drawing.Size(883, 189);
            this.dgv_issuebook.TabIndex = 13;
            this.dgv_issuebook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_issuebook_CellClick);
            // 
            // tb_searchenroll
            // 
            this.tb_searchenroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchenroll.Location = new System.Drawing.Point(140, 112);
            this.tb_searchenroll.Name = "tb_searchenroll";
            this.tb_searchenroll.Size = new System.Drawing.Size(171, 27);
            this.tb_searchenroll.TabIndex = 15;
            this.tb_searchenroll.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_searchenroll_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Enrollment No";
            // 
            // btn_back
            // 
            this.btn_back.Image = global::LibraryManagementSystem.Properties.Resources.icon_back;
            this.btn_back.Location = new System.Drawing.Point(847, 112);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(56, 33);
            this.btn_back.TabIndex = 12;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Image = global::LibraryManagementSystem.Properties.Resources.icon_return;
            this.btn_return.Location = new System.Drawing.Point(469, 424);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(105, 33);
            this.btn_return.TabIndex = 11;
            this.btn_return.Text = "Return";
            this.btn_return.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.icon_issueBook;
            this.pictureBox1.Location = new System.Drawing.Point(326, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.date_return);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btn_return);
            this.panel1.Location = new System.Drawing.Point(23, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 469);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_contact);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tb_enrollment);
            this.panel2.Controls.Add(this.tb_sem);
            this.panel2.Controls.Add(this.tb_year);
            this.panel2.Controls.Add(this.tb_course);
            this.panel2.Controls.Add(this.tb_studentName);
            this.panel2.Controls.Add(this.tb_studentId);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tb_dateOfIssue);
            this.panel2.Controls.Add(this.tb_issueId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_edition);
            this.panel2.Controls.Add(this.tb_publisher);
            this.panel2.Controls.Add(this.tb_bookName);
            this.panel2.Controls.Add(this.tb_bookId);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(15, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 349);
            this.panel2.TabIndex = 20;
            // 
            // tb_contact
            // 
            this.tb_contact.Enabled = false;
            this.tb_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contact.Location = new System.Drawing.Point(151, 288);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(171, 27);
            this.tb_contact.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 291);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 61;
            this.label16.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Enrollment No";
            // 
            // tb_enrollment
            // 
            this.tb_enrollment.Enabled = false;
            this.tb_enrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_enrollment.Location = new System.Drawing.Point(151, 22);
            this.tb_enrollment.Name = "tb_enrollment";
            this.tb_enrollment.Size = new System.Drawing.Size(171, 27);
            this.tb_enrollment.TabIndex = 59;
            // 
            // tb_sem
            // 
            this.tb_sem.Enabled = false;
            this.tb_sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sem.Location = new System.Drawing.Point(151, 238);
            this.tb_sem.Name = "tb_sem";
            this.tb_sem.Size = new System.Drawing.Size(171, 27);
            this.tb_sem.TabIndex = 55;
            // 
            // tb_year
            // 
            this.tb_year.Enabled = false;
            this.tb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_year.Location = new System.Drawing.Point(151, 194);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(171, 27);
            this.tb_year.TabIndex = 57;
            // 
            // tb_course
            // 
            this.tb_course.Enabled = false;
            this.tb_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_course.Location = new System.Drawing.Point(151, 150);
            this.tb_course.Name = "tb_course";
            this.tb_course.Size = new System.Drawing.Size(171, 27);
            this.tb_course.TabIndex = 58;
            // 
            // tb_studentName
            // 
            this.tb_studentName.Enabled = false;
            this.tb_studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_studentName.Location = new System.Drawing.Point(151, 60);
            this.tb_studentName.Name = "tb_studentName";
            this.tb_studentName.Size = new System.Drawing.Size(171, 27);
            this.tb_studentName.TabIndex = 56;
            // 
            // tb_studentId
            // 
            this.tb_studentId.Enabled = false;
            this.tb_studentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_studentId.Location = new System.Drawing.Point(151, 107);
            this.tb_studentId.Name = "tb_studentId";
            this.tb_studentId.Size = new System.Drawing.Size(171, 27);
            this.tb_studentId.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Semester";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Course";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "Student Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Date of Issue";
            // 
            // tb_dateOfIssue
            // 
            this.tb_dateOfIssue.Enabled = false;
            this.tb_dateOfIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dateOfIssue.Location = new System.Drawing.Point(632, 242);
            this.tb_dateOfIssue.Name = "tb_dateOfIssue";
            this.tb_dateOfIssue.Size = new System.Drawing.Size(171, 27);
            this.tb_dateOfIssue.TabIndex = 47;
            // 
            // tb_issueId
            // 
            this.tb_issueId.Enabled = false;
            this.tb_issueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_issueId.Location = new System.Drawing.Point(632, 196);
            this.tb_issueId.Name = "tb_issueId";
            this.tb_issueId.Size = new System.Drawing.Size(171, 27);
            this.tb_issueId.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Issue Id";
            // 
            // tb_edition
            // 
            this.tb_edition.Enabled = false;
            this.tb_edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_edition.Location = new System.Drawing.Point(632, 112);
            this.tb_edition.Name = "tb_edition";
            this.tb_edition.Size = new System.Drawing.Size(171, 27);
            this.tb_edition.TabIndex = 43;
            // 
            // tb_publisher
            // 
            this.tb_publisher.Enabled = false;
            this.tb_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_publisher.Location = new System.Drawing.Point(632, 156);
            this.tb_publisher.Name = "tb_publisher";
            this.tb_publisher.Size = new System.Drawing.Size(171, 27);
            this.tb_publisher.TabIndex = 41;
            // 
            // tb_bookName
            // 
            this.tb_bookName.Enabled = false;
            this.tb_bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bookName.Location = new System.Drawing.Point(632, 22);
            this.tb_bookName.Name = "tb_bookName";
            this.tb_bookName.Size = new System.Drawing.Size(171, 27);
            this.tb_bookName.TabIndex = 40;
            // 
            // tb_bookId
            // 
            this.tb_bookId.Enabled = false;
            this.tb_bookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bookId.Location = new System.Drawing.Point(632, 65);
            this.tb_bookId.Name = "tb_bookId";
            this.tb_bookId.Size = new System.Drawing.Size(171, 27);
            this.tb_bookId.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Edition";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(508, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Book Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(508, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Book ID";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 843);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_searchenroll);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgv_issuebook);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_issuebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.DateTimePicker date_return;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem menu_user;
        private System.Windows.Forms.ToolStripMenuItem menu_logout;
        private System.Windows.Forms.ToolStripMenuItem menu_viewBook;
        private System.Windows.Forms.ToolStripMenuItem menu_viewStudent;
        private System.Windows.Forms.DataGridView dgv_issuebook;
        private System.Windows.Forms.TextBox tb_searchenroll;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_enrollment;
        private System.Windows.Forms.TextBox tb_sem;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.TextBox tb_course;
        private System.Windows.Forms.TextBox tb_studentName;
        private System.Windows.Forms.TextBox tb_studentId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dateOfIssue;
        private System.Windows.Forms.TextBox tb_issueId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_edition;
        private System.Windows.Forms.TextBox tb_publisher;
        private System.Windows.Forms.TextBox tb_bookName;
        private System.Windows.Forms.TextBox tb_bookId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}