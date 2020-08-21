namespace CorporateCoders
{
    partial class Form10
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewAdmin = new System.Windows.Forms.RadioButton();
            this.rbnDeleteAdmin = new System.Windows.Forms.RadioButton();
            this.rbnUpdateAttendance = new System.Windows.Forms.RadioButton();
            this.rbnNewAdmin = new System.Windows.Forms.RadioButton();
            this.rbnAddUser = new System.Windows.Forms.RadioButton();
            this.rbnDeleteUser = new System.Windows.Forms.RadioButton();
            this.rbnViewAttendance = new System.Windows.Forms.RadioButton();
            this.rbnViewRequests = new System.Windows.Forms.RadioButton();
            this.rbnVerify = new System.Windows.Forms.RadioButton();
            this.rbnUserAccount = new System.Windows.Forms.RadioButton();
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHome.Location = new System.Drawing.Point(36, 14);
            this.btnHome.Margin = new System.Windows.Forms.Padding(10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(131, 62);
            this.btnHome.TabIndex = 42;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnLogout.Location = new System.Drawing.Point(1029, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 62);
            this.btnLogout.TabIndex = 38;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnViewAdmin);
            this.panel1.Controls.Add(this.rbnDeleteAdmin);
            this.panel1.Controls.Add(this.rbnUpdateAttendance);
            this.panel1.Controls.Add(this.rbnNewAdmin);
            this.panel1.Controls.Add(this.rbnAddUser);
            this.panel1.Controls.Add(this.rbnDeleteUser);
            this.panel1.Controls.Add(this.rbnViewAttendance);
            this.panel1.Controls.Add(this.rbnViewRequests);
            this.panel1.Controls.Add(this.rbnVerify);
            this.panel1.Controls.Add(this.rbnUserAccount);
            this.panel1.Location = new System.Drawing.Point(12, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 668);
            this.panel1.TabIndex = 52;
            // 
            // btnViewAdmin
            // 
            this.btnViewAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewAdmin.AutoSize = true;
            this.btnViewAdmin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAdmin.ForeColor = System.Drawing.Color.White;
            this.btnViewAdmin.Location = new System.Drawing.Point(155, 172);
            this.btnViewAdmin.Name = "btnViewAdmin";
            this.btnViewAdmin.Size = new System.Drawing.Size(358, 36);
            this.btnViewAdmin.TabIndex = 61;
            this.btnViewAdmin.TabStop = true;
            this.btnViewAdmin.Text = "VIEW ADMIN ACCOUNT";
            this.btnViewAdmin.UseVisualStyleBackColor = true;
            this.btnViewAdmin.CheckedChanged += new System.EventHandler(this.BtnViewAdmin_CheckedChanged);
            // 
            // rbnDeleteAdmin
            // 
            this.rbnDeleteAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnDeleteAdmin.AutoSize = true;
            this.rbnDeleteAdmin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnDeleteAdmin.ForeColor = System.Drawing.Color.White;
            this.rbnDeleteAdmin.Location = new System.Drawing.Point(136, 299);
            this.rbnDeleteAdmin.Name = "rbnDeleteAdmin";
            this.rbnDeleteAdmin.Size = new System.Drawing.Size(396, 36);
            this.rbnDeleteAdmin.TabIndex = 60;
            this.rbnDeleteAdmin.TabStop = true;
            this.rbnDeleteAdmin.Text = "DELETE ADMIN ACCOUNT";
            this.rbnDeleteAdmin.UseVisualStyleBackColor = true;
            this.rbnDeleteAdmin.CheckedChanged += new System.EventHandler(this.RbnDeleteAdmin_CheckedChanged_1);
            // 
            // rbnUpdateAttendance
            // 
            this.rbnUpdateAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnUpdateAttendance.AutoSize = true;
            this.rbnUpdateAttendance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnUpdateAttendance.ForeColor = System.Drawing.Color.White;
            this.rbnUpdateAttendance.Location = new System.Drawing.Point(685, 553);
            this.rbnUpdateAttendance.Name = "rbnUpdateAttendance";
            this.rbnUpdateAttendance.Size = new System.Drawing.Size(346, 36);
            this.rbnUpdateAttendance.TabIndex = 59;
            this.rbnUpdateAttendance.TabStop = true;
            this.rbnUpdateAttendance.Text = "UPDATE ATTENDANCE";
            this.rbnUpdateAttendance.UseVisualStyleBackColor = true;
            this.rbnUpdateAttendance.CheckedChanged += new System.EventHandler(this.RbnUpdateAttendance_CheckedChanged);
            // 
            // rbnNewAdmin
            // 
            this.rbnNewAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnNewAdmin.AutoSize = true;
            this.rbnNewAdmin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnNewAdmin.ForeColor = System.Drawing.Color.White;
            this.rbnNewAdmin.Location = new System.Drawing.Point(199, 45);
            this.rbnNewAdmin.Name = "rbnNewAdmin";
            this.rbnNewAdmin.Size = new System.Drawing.Size(270, 36);
            this.rbnNewAdmin.TabIndex = 58;
            this.rbnNewAdmin.TabStop = true;
            this.rbnNewAdmin.Text = "ADD NEW ADMIN";
            this.rbnNewAdmin.UseVisualStyleBackColor = true;
            this.rbnNewAdmin.CheckedChanged += new System.EventHandler(this.RbnNewAdmin_CheckedChanged);
            // 
            // rbnAddUser
            // 
            this.rbnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnAddUser.AutoSize = true;
            this.rbnAddUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnAddUser.ForeColor = System.Drawing.Color.White;
            this.rbnAddUser.Location = new System.Drawing.Point(209, 426);
            this.rbnAddUser.Name = "rbnAddUser";
            this.rbnAddUser.Size = new System.Drawing.Size(251, 36);
            this.rbnAddUser.TabIndex = 57;
            this.rbnAddUser.TabStop = true;
            this.rbnAddUser.Text = "ADD NEW USER";
            this.rbnAddUser.UseVisualStyleBackColor = true;
            this.rbnAddUser.CheckedChanged += new System.EventHandler(this.RbnAddUser_CheckedChanged);
            // 
            // rbnDeleteUser
            // 
            this.rbnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnDeleteUser.AutoSize = true;
            this.rbnDeleteUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.rbnDeleteUser.Location = new System.Drawing.Point(670, 45);
            this.rbnDeleteUser.Name = "rbnDeleteUser";
            this.rbnDeleteUser.Size = new System.Drawing.Size(377, 36);
            this.rbnDeleteUser.TabIndex = 56;
            this.rbnDeleteUser.TabStop = true;
            this.rbnDeleteUser.Text = "DELETE USER ACCOUNT";
            this.rbnDeleteUser.UseVisualStyleBackColor = true;
            this.rbnDeleteUser.CheckedChanged += new System.EventHandler(this.RbnDeleteUser_CheckedChanged);
            // 
            // rbnViewAttendance
            // 
            this.rbnViewAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnViewAttendance.AutoSize = true;
            this.rbnViewAttendance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnViewAttendance.ForeColor = System.Drawing.Color.White;
            this.rbnViewAttendance.Location = new System.Drawing.Point(704, 426);
            this.rbnViewAttendance.Name = "rbnViewAttendance";
            this.rbnViewAttendance.Size = new System.Drawing.Size(309, 36);
            this.rbnViewAttendance.TabIndex = 55;
            this.rbnViewAttendance.TabStop = true;
            this.rbnViewAttendance.Text = "VIEW ATTENDANCE";
            this.rbnViewAttendance.UseVisualStyleBackColor = true;
            this.rbnViewAttendance.CheckedChanged += new System.EventHandler(this.RbnViewAttendance_CheckedChanged);
            // 
            // rbnViewRequests
            // 
            this.rbnViewRequests.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnViewRequests.AutoSize = true;
            this.rbnViewRequests.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnViewRequests.ForeColor = System.Drawing.Color.White;
            this.rbnViewRequests.Location = new System.Drawing.Point(702, 299);
            this.rbnViewRequests.Name = "rbnViewRequests";
            this.rbnViewRequests.Size = new System.Drawing.Size(313, 36);
            this.rbnViewRequests.TabIndex = 54;
            this.rbnViewRequests.TabStop = true;
            this.rbnViewRequests.Text = "VIEW CL REQUESTS";
            this.rbnViewRequests.UseVisualStyleBackColor = true;
            this.rbnViewRequests.CheckedChanged += new System.EventHandler(this.RbnViewRequests_CheckedChanged);
            // 
            // rbnVerify
            // 
            this.rbnVerify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnVerify.AutoSize = true;
            this.rbnVerify.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnVerify.ForeColor = System.Drawing.Color.White;
            this.rbnVerify.Location = new System.Drawing.Point(786, 172);
            this.rbnVerify.Name = "rbnVerify";
            this.rbnVerify.Size = new System.Drawing.Size(144, 36);
            this.rbnVerify.TabIndex = 53;
            this.rbnVerify.TabStop = true;
            this.rbnVerify.Text = "VERIFY";
            this.rbnVerify.UseVisualStyleBackColor = true;
            this.rbnVerify.CheckedChanged += new System.EventHandler(this.RbnVerify_CheckedChanged);
            // 
            // rbnUserAccount
            // 
            this.rbnUserAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnUserAccount.AutoSize = true;
            this.rbnUserAccount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnUserAccount.ForeColor = System.Drawing.Color.White;
            this.rbnUserAccount.Location = new System.Drawing.Point(157, 553);
            this.rbnUserAccount.Name = "rbnUserAccount";
            this.rbnUserAccount.Size = new System.Drawing.Size(355, 36);
            this.rbnUserAccount.TabIndex = 52;
            this.rbnUserAccount.TabStop = true;
            this.rbnUserAccount.Text = "VIEW USER ACCOUNTS";
            this.rbnUserAccount.UseVisualStyleBackColor = true;
            this.rbnUserAccount.CheckedChanged += new System.EventHandler(this.RbnUserAccount_CheckedChanged);
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.ForeColor = System.Drawing.Color.Maroon;
            this.lblAdminMenu.Location = new System.Drawing.Point(348, 22);
            this.lblAdminMenu.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblAdminMenu.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(500, 49);
            this.lblAdminMenu.TabIndex = 37;
            this.lblAdminMenu.Text = "ADMIN MENU";
            this.lblAdminMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1197, 868);
            this.Controls.Add(this.lblAdminMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLogout);
            this.Name = "Form10";
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnUpdateAttendance;
        private System.Windows.Forms.RadioButton rbnNewAdmin;
        private System.Windows.Forms.RadioButton rbnAddUser;
        private System.Windows.Forms.RadioButton rbnDeleteUser;
        private System.Windows.Forms.RadioButton rbnViewAttendance;
        private System.Windows.Forms.RadioButton rbnViewRequests;
        private System.Windows.Forms.RadioButton rbnVerify;
        private System.Windows.Forms.RadioButton rbnUserAccount;
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.RadioButton rbnDeleteAdmin;
        private System.Windows.Forms.RadioButton btnViewAdmin;
    }
}