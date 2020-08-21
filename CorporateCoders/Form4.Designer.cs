namespace CorporateCoders
{
    partial class Form4
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
            this.lblHead = new System.Windows.Forms.Label();
            this.lblUserMenu = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.rbnMyAcct = new System.Windows.Forms.RadioButton();
            this.rbnCheckAttendance = new System.Windows.Forms.RadioButton();
            this.rbnCL = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(172, 33);
            this.lblHead.MaximumSize = new System.Drawing.Size(800, 0);
            this.lblHead.MinimumSize = new System.Drawing.Size(800, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(800, 45);
            this.lblHead.TabIndex = 34;
            this.lblHead.Text = "Welcome!";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserMenu
            // 
            this.lblUserMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserMenu.AutoSize = true;
            this.lblUserMenu.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMenu.ForeColor = System.Drawing.Color.Black;
            this.lblUserMenu.Location = new System.Drawing.Point(279, 45);
            this.lblUserMenu.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblUserMenu.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblUserMenu.Name = "lblUserMenu";
            this.lblUserMenu.Size = new System.Drawing.Size(500, 49);
            this.lblUserMenu.TabIndex = 37;
            this.lblUserMenu.Text = "USER MENU";
            this.lblUserMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUid.Location = new System.Drawing.Point(37, 100);
            this.lblUid.Margin = new System.Windows.Forms.Padding(10);
            this.lblUid.MaximumSize = new System.Drawing.Size(304, 0);
            this.lblUid.MinimumSize = new System.Drawing.Size(304, 0);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(304, 32);
            this.lblUid.TabIndex = 0;
            this.lblUid.Text = "USER ID :";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnLogout.Location = new System.Drawing.Point(975, 31);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 49);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHome.Location = new System.Drawing.Point(43, 31);
            this.btnHome.Margin = new System.Windows.Forms.Padding(10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(131, 49);
            this.btnHome.TabIndex = 36;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // rbnMyAcct
            // 
            this.rbnMyAcct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnMyAcct.AutoSize = true;
            this.rbnMyAcct.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMyAcct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.rbnMyAcct.Location = new System.Drawing.Point(410, 153);
            this.rbnMyAcct.Name = "rbnMyAcct";
            this.rbnMyAcct.Size = new System.Drawing.Size(227, 36);
            this.rbnMyAcct.TabIndex = 2;
            this.rbnMyAcct.Text = "MY ACCOUNT";
            this.rbnMyAcct.UseVisualStyleBackColor = true;
            this.rbnMyAcct.CheckedChanged += new System.EventHandler(this.RbnMyAcct_CheckedChanged);
            // 
            // rbnCheckAttendance
            // 
            this.rbnCheckAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnCheckAttendance.AutoSize = true;
            this.rbnCheckAttendance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnCheckAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.rbnCheckAttendance.Location = new System.Drawing.Point(361, 231);
            this.rbnCheckAttendance.Name = "rbnCheckAttendance";
            this.rbnCheckAttendance.Size = new System.Drawing.Size(337, 36);
            this.rbnCheckAttendance.TabIndex = 38;
            this.rbnCheckAttendance.Text = "CHECK ATTENDANCE";
            this.rbnCheckAttendance.UseVisualStyleBackColor = true;
            this.rbnCheckAttendance.CheckedChanged += new System.EventHandler(this.RbnCheckAttendance_CheckedChanged);
            // 
            // rbnCL
            // 
            this.rbnCL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnCL.AutoSize = true;
            this.rbnCL.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnCL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.rbnCL.Location = new System.Drawing.Point(378, 306);
            this.rbnCL.Name = "rbnCL";
            this.rbnCL.Size = new System.Drawing.Size(282, 36);
            this.rbnCL.TabIndex = 3;
            this.rbnCL.Text = "REQUEST FOR CL";
            this.rbnCL.UseVisualStyleBackColor = true;
            this.rbnCL.CheckedChanged += new System.EventHandler(this.RbnCL_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbnCL);
            this.panel1.Controls.Add(this.lblUserMenu);
            this.panel1.Controls.Add(this.rbnCheckAttendance);
            this.panel1.Controls.Add(this.rbnMyAcct);
            this.panel1.Location = new System.Drawing.Point(43, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 416);
            this.panel1.TabIndex = 39;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(188)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1148, 754);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.btnLogout);
            this.Name = "Form4";
            this.Text = "User Menu";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblUserMenu;
        private System.Windows.Forms.RadioButton rbnMyAcct;
        private System.Windows.Forms.RadioButton rbnCheckAttendance;
        private System.Windows.Forms.RadioButton rbnCL;
        private System.Windows.Forms.Panel panel1;
    }
}