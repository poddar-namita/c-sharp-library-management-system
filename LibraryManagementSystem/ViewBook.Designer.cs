namespace LibraryManagementSystem
{
    partial class ViewBook
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
            this.tb_searchBook = new System.Windows.Forms.TextBox();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update_record = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.date_of_purchase = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_edition = new System.Windows.Forms.ComboBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_publisher = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_bookId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(812, 31);
            this.menuStrip1.TabIndex = 1;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Book";
            // 
            // tb_searchBook
            // 
            this.tb_searchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchBook.Location = new System.Drawing.Point(124, 35);
            this.tb_searchBook.Name = "tb_searchBook";
            this.tb_searchBook.Size = new System.Drawing.Size(171, 27);
            this.tb_searchBook.TabIndex = 3;
            this.tb_searchBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_book);
            // 
            // dgv_books
            // 
            this.dgv_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(16, 75);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.RowTemplate.Height = 24;
            this.dgv_books.Size = new System.Drawing.Size(784, 211);
            this.dgv_books.TabIndex = 4;
            this.dgv_books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellClick);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(603, 37);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(137, 30);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update record?";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_update_record);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.date_of_purchase);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_quantity);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cb_edition);
            this.panel1.Controls.Add(this.tb_price);
            this.panel1.Controls.Add(this.tb_publisher);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.tb_bookId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 224);
            this.panel1.TabIndex = 6;
            // 
            // btn_update_record
            // 
            this.btn_update_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_record.Location = new System.Drawing.Point(657, 167);
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
            // date_of_purchase
            // 
            this.date_of_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_of_purchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_of_purchase.Location = new System.Drawing.Point(577, 35);
            this.date_of_purchase.Name = "date_of_purchase";
            this.date_of_purchase.Size = new System.Drawing.Size(171, 27);
            this.date_of_purchase.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(422, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Date of Purchase";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantity.Location = new System.Drawing.Point(577, 119);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(171, 27);
            this.tb_quantity.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Quantity";
            // 
            // cb_edition
            // 
            this.cb_edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_edition.FormattingEnabled = true;
            this.cb_edition.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_edition.Location = new System.Drawing.Point(169, 124);
            this.cb_edition.Name = "cb_edition";
            this.cb_edition.Size = new System.Drawing.Size(171, 28);
            this.cb_edition.TabIndex = 26;
            this.cb_edition.Text = "1";
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(577, 78);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(171, 27);
            this.tb_price.TabIndex = 25;
            // 
            // tb_publisher
            // 
            this.tb_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_publisher.Location = new System.Drawing.Point(169, 169);
            this.tb_publisher.Name = "tb_publisher";
            this.tb_publisher.Size = new System.Drawing.Size(171, 27);
            this.tb_publisher.TabIndex = 24;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(169, 78);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(171, 27);
            this.tb_name.TabIndex = 23;
            // 
            // tb_bookId
            // 
            this.tb_bookId.Enabled = false;
            this.tb_bookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bookId.Location = new System.Drawing.Point(169, 35);
            this.tb_bookId.Name = "tb_bookId";
            this.tb_bookId.ReadOnly = true;
            this.tb_bookId.Size = new System.Drawing.Size(171, 27);
            this.tb_bookId.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Edition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Book ID";
            // 
            // btn_back
            // 
            this.btn_back.Image = global::LibraryManagementSystem.Properties.Resources.icon_back;
            this.btn_back.Location = new System.Drawing.Point(753, 37);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(46, 30);
            this.btn_back.TabIndex = 7;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 544);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.tb_searchBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Details";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_searchBook;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_update_record;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_of_purchase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_edition;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_publisher;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_bookId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
    }
}