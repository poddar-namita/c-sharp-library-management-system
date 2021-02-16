namespace LibraryManagementSystem
{
    partial class LibrarianLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_forgot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_forgot);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.btn_signup);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 237);
            this.panel1.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Image = global::LibraryManagementSystem.Properties.Resources.icon_back;
            this.btn_back.Location = new System.Drawing.Point(338, 182);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(45, 34);
            this.btn_back.TabIndex = 11;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(122, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Librarian Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_forgot
            // 
            this.btn_forgot.Image = global::LibraryManagementSystem.Properties.Resources.icon_forgotPassword;
            this.btn_forgot.Location = new System.Drawing.Point(153, 182);
            this.btn_forgot.Name = "btn_forgot";
            this.btn_forgot.Size = new System.Drawing.Size(179, 34);
            this.btn_forgot.TabIndex = 10;
            this.btn_forgot.Text = "Forgot Password";
            this.btn_forgot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_forgot.UseVisualStyleBackColor = true;
            this.btn_forgot.Click += new System.EventHandler(this.btn_forgot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(14, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trouble Login?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.icon_password;
            this.pictureBox2.Location = new System.Drawing.Point(353, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 27);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.icon_username;
            this.pictureBox1.Location = new System.Drawing.Point(353, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(111, 84);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(226, 27);
            this.tb_password.TabIndex = 6;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(111, 52);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(226, 27);
            this.tb_username.TabIndex = 5;
            // 
            // btn_signup
            // 
            this.btn_signup.Image = global::LibraryManagementSystem.Properties.Resources.icon_signIn;
            this.btn_signup.Location = new System.Drawing.Point(227, 127);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(110, 37);
            this.btn_signup.TabIndex = 4;
            this.btn_signup.Text = "SignUp";
            this.btn_signup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_login
            // 
            this.btn_login.Image = global::LibraryManagementSystem.Properties.Resources.icon_login;
            this.btn_login.Location = new System.Drawing.Point(111, 127);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(110, 37);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // LibrarianLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 257);
            this.Controls.Add(this.panel1);
            this.Name = "LibrarianLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_forgot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
    }
}