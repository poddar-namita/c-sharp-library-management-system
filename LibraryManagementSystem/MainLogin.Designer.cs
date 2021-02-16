namespace LibraryManagementSystem
{
    partial class MainLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_librarian = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_admin);
            this.panel1.Controls.Add(this.btn_librarian);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 144);
            this.panel1.TabIndex = 3;
            // 
            // btn_admin
            // 
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Image = global::LibraryManagementSystem.Properties.Resources.icon_admin;
            this.btn_admin.Location = new System.Drawing.Point(21, 63);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(119, 43);
            this.btn_admin.TabIndex = 0;
            this.btn_admin.Text = "Admin";
            this.btn_admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_librarian
            // 
            this.btn_librarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_librarian.Image = global::LibraryManagementSystem.Properties.Resources.icon_librarian;
            this.btn_librarian.Location = new System.Drawing.Point(146, 63);
            this.btn_librarian.Name = "btn_librarian";
            this.btn_librarian.Size = new System.Drawing.Size(119, 43);
            this.btn_librarian.TabIndex = 1;
            this.btn_librarian.Text = "Librarian";
            this.btn_librarian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_librarian.UseVisualStyleBackColor = true;
            this.btn_librarian.Click += new System.EventHandler(this.btn_librarian_Click);
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 171);
            this.Controls.Add(this.panel1);
            this.Name = "MainLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Mode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_librarian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Panel panel1;

    }
}

