namespace LibraryManagementSystem
{
    partial class DataAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataAnalysis));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_association = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 300);
            this.textBox1.TabIndex = 7;
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(552, 80);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(119, 29);
            this.btn_load.TabIndex = 8;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(552, 136);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(119, 29);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Get details of book a particular student issues to get the association of books.";
            // 
            // btn_association
            // 
            this.btn_association.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_association.Location = new System.Drawing.Point(552, 194);
            this.btn_association.Name = "btn_association";
            this.btn_association.Size = new System.Drawing.Size(119, 59);
            this.btn_association.TabIndex = 11;
            this.btn_association.Text = "Get Associations";
            this.btn_association.UseVisualStyleBackColor = true;
            this.btn_association.Click += new System.EventHandler(this.btn_association_Click);
            // 
            // btn_back
            // 
            this.btn_back.Image = global::LibraryManagementSystem.Properties.Resources.icon_back;
            this.btn_back.Location = new System.Drawing.Point(615, 347);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(56, 33);
            this.btn_back.TabIndex = 19;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(689, 31);
            this.menuStrip1.TabIndex = 20;
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
            this.menu_logout.Image = ((System.Drawing.Image)(resources.GetObject("menu_logout.Image")));
            this.menu_logout.Name = "menu_logout";
            this.menu_logout.Size = new System.Drawing.Size(181, 28);
            this.menu_logout.Text = "Logout";
            this.menu_logout.Click += new System.EventHandler(this.menu_logout_Click);
            // 
            // DataAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 393);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_association);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.textBox1);
            this.Name = "DataAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Analysis";
            this.Load += new System.EventHandler(this.DataAnalysis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_association;
        private System.Windows.Forms.Button btn_back;
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
    }
}