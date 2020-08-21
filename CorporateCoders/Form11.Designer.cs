namespace CorporateCoders
{
    partial class Form11
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
            this.components = new System.ComponentModel.Container();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblUId = new System.Windows.Forms.Label();
            this.txtUId = new System.Windows.Forms.TextBox();
            this.btnViewUserDeets = new System.Windows.Forms.Button();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.errorProviderUId = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSubHead = new System.Windows.Forms.Label();
            this.lblSubHeead2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUId)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnLogout.Location = new System.Drawing.Point(997, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(165, 55);
            this.btnLogout.TabIndex = 43;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // lblHead
            // 
            this.lblHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(190, 19);
            this.lblHead.MaximumSize = new System.Drawing.Size(790, 0);
            this.lblHead.MinimumSize = new System.Drawing.Size(790, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(790, 45);
            this.lblHead.TabIndex = 45;
            this.lblHead.Text = "Welcome!";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHead.Click += new System.EventHandler(this.LblHead_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHome.Location = new System.Drawing.Point(38, 14);
            this.btnHome.Margin = new System.Windows.Forms.Padding(10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(131, 55);
            this.btnHome.TabIndex = 47;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblUId
            // 
            this.lblUId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUId.AutoSize = true;
            this.lblUId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUId.ForeColor = System.Drawing.Color.White;
            this.lblUId.Location = new System.Drawing.Point(329, 129);
            this.lblUId.Name = "lblUId";
            this.lblUId.Size = new System.Drawing.Size(157, 26);
            this.lblUId.TabIndex = 48;
            this.lblUId.Text = "Enter User ID";
            this.lblUId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUId
            // 
            this.txtUId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUId.Location = new System.Drawing.Point(577, 125);
            this.txtUId.Name = "txtUId";
            this.txtUId.Size = new System.Drawing.Size(240, 30);
            this.txtUId.TabIndex = 50;
            this.txtUId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUId_Validating);
            this.txtUId.Validated += new System.EventHandler(this.TxtUId_Validated);
            // 
            // btnViewUserDeets
            // 
            this.btnViewUserDeets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewUserDeets.BackColor = System.Drawing.Color.Black;
            this.btnViewUserDeets.CausesValidation = false;
            this.btnViewUserDeets.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUserDeets.ForeColor = System.Drawing.Color.White;
            this.btnViewUserDeets.Location = new System.Drawing.Point(334, 236);
            this.btnViewUserDeets.Name = "btnViewUserDeets";
            this.btnViewUserDeets.Size = new System.Drawing.Size(483, 67);
            this.btnViewUserDeets.TabIndex = 52;
            this.btnViewUserDeets.Text = "VIEW USER ACCOUNT DETAILS";
            this.btnViewUserDeets.UseVisualStyleBackColor = false;
            this.btnViewUserDeets.Click += new System.EventHandler(this.BtnViewUserDeets_Click);
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllUsers.BackColor = System.Drawing.Color.Black;
            this.btnAllUsers.CausesValidation = false;
            this.btnAllUsers.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllUsers.ForeColor = System.Drawing.Color.White;
            this.btnAllUsers.Location = new System.Drawing.Point(352, 108);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(419, 67);
            this.btnAllUsers.TabIndex = 53;
            this.btnAllUsers.Text = "VIEW ALL THE USERS";
            this.btnAllUsers.UseVisualStyleBackColor = false;
            this.btnAllUsers.Click += new System.EventHandler(this.BtnAllUsers_Click);
            // 
            // errorProviderUId
            // 
            this.errorProviderUId.ContainerControl = this;
            // 
            // lblSubHead
            // 
            this.lblSubHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubHead.AutoSize = true;
            this.lblSubHead.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHead.ForeColor = System.Drawing.Color.White;
            this.lblSubHead.Location = new System.Drawing.Point(170, 32);
            this.lblSubHead.Name = "lblSubHead";
            this.lblSubHead.Size = new System.Drawing.Size(775, 37);
            this.lblSubHead.TabIndex = 54;
            this.lblSubHead.Text = "ENTER CREDENTIALS TO VIEW USER DETIALS";
            this.lblSubHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubHeead2
            // 
            this.lblSubHeead2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubHeead2.AutoSize = true;
            this.lblSubHeead2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeead2.ForeColor = System.Drawing.Color.White;
            this.lblSubHeead2.Location = new System.Drawing.Point(331, 29);
            this.lblSubHeead2.Name = "lblSubHeead2";
            this.lblSubHeead2.Size = new System.Drawing.Size(443, 37);
            this.lblSubHeead2.TabIndex = 55;
            this.lblSubHeead2.Text = "VIEW ALL USERS DETIALS";
            this.lblSubHeead2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblSubHead);
            this.panel1.Controls.Add(this.btnViewUserDeets);
            this.panel1.Controls.Add(this.txtUId);
            this.panel1.Controls.Add(this.lblUId);
            this.panel1.Location = new System.Drawing.Point(43, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 338);
            this.panel1.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblSubHeead2);
            this.panel2.Controls.Add(this.btnAllUsers);
            this.panel2.Location = new System.Drawing.Point(42, 577);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 210);
            this.panel2.TabIndex = 57;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1201, 868);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnHome);
            this.Name = "Form11";
            this.Text = "View User Details";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUId)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblUId;
        private System.Windows.Forms.TextBox txtUId;
        private System.Windows.Forms.Button btnViewUserDeets;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.ErrorProvider errorProviderUId;
        private System.Windows.Forms.Label lblSubHeead2;
        private System.Windows.Forms.Label lblSubHead;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}