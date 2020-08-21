namespace CorporateCoders
{
    partial class Form5
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
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUId = new System.Windows.Forms.Label();
            this.lblUserDeets = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox1
            // 
            this.grpBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.grpBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpBox1.Controls.Add(this.btnSave);
            this.grpBox1.Controls.Add(this.cmbDept);
            this.grpBox1.Controls.Add(this.dtpDob);
            this.grpBox1.Controls.Add(this.txtPhone);
            this.grpBox1.Controls.Add(this.txtEmail);
            this.grpBox1.Controls.Add(this.txtName);
            this.grpBox1.Controls.Add(this.txtUid);
            this.grpBox1.Controls.Add(this.lblDob);
            this.grpBox1.Controls.Add(this.lblDept);
            this.grpBox1.Controls.Add(this.lblPhone);
            this.grpBox1.Controls.Add(this.lblEmail);
            this.grpBox1.Controls.Add(this.lblName);
            this.grpBox1.Controls.Add(this.lblUId);
            this.grpBox1.Controls.Add(this.lblUserDeets);
            this.grpBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox1.Location = new System.Drawing.Point(51, 105);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(1083, 725);
            this.grpBox1.TabIndex = 38;
            this.grpBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(529, 647);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 43);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "Software Development",
            "Law and Legal Rights",
            "Management",
            "Humanites and Human Resouce",
            "Public Relations",
            "Commerce",
            "Hardware",
            "Cyber Security"});
            this.cmbDept.Location = new System.Drawing.Point(480, 465);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(434, 33);
            this.cmbDept.TabIndex = 11;
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(480, 550);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(434, 34);
            this.dtpDob.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(480, 378);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(434, 34);
            this.txtPhone.TabIndex = 10;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPhone_Validating);
            this.txtPhone.Validated += new System.EventHandler(this.TxtPhone_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(480, 293);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(434, 34);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.TxtEmail_Validated);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(480, 208);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(434, 34);
            this.txtName.TabIndex = 8;
            // 
            // txtUid
            // 
            this.txtUid.BackColor = System.Drawing.SystemColors.Control;
            this.txtUid.Location = new System.Drawing.Point(480, 123);
            this.txtUid.Name = "txtUid";
            this.txtUid.ReadOnly = true;
            this.txtUid.Size = new System.Drawing.Size(434, 34);
            this.txtUid.TabIndex = 7;
            // 
            // lblDob
            // 
            this.lblDob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.ForeColor = System.Drawing.Color.White;
            this.lblDob.Location = new System.Drawing.Point(169, 551);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(232, 32);
            this.lblDob.TabIndex = 6;
            this.lblDob.Text = "DATE OF BIRTH";
            this.lblDob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDept
            // 
            this.lblDept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.ForeColor = System.Drawing.Color.White;
            this.lblDept.Location = new System.Drawing.Point(169, 462);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(210, 32);
            this.lblDept.TabIndex = 5;
            this.lblDept.Text = "DEPARTMENT";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(169, 375);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(248, 32);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "PHONE NUMBER";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(169, 290);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(144, 32);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "EMAIL ID";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(169, 205);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 32);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUId
            // 
            this.lblUId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUId.AutoSize = true;
            this.lblUId.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUId.ForeColor = System.Drawing.Color.White;
            this.lblUId.Location = new System.Drawing.Point(169, 120);
            this.lblUId.Name = "lblUId";
            this.lblUId.Size = new System.Drawing.Size(127, 32);
            this.lblUId.TabIndex = 1;
            this.lblUId.Text = "USER ID";
            this.lblUId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserDeets
            // 
            this.lblUserDeets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserDeets.AutoSize = true;
            this.lblUserDeets.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDeets.ForeColor = System.Drawing.Color.White;
            this.lblUserDeets.Location = new System.Drawing.Point(446, 38);
            this.lblUserDeets.Name = "lblUserDeets";
            this.lblUserDeets.Size = new System.Drawing.Size(311, 45);
            this.lblUserDeets.TabIndex = 0;
            this.lblUserDeets.Text = "USER DETAILS";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnLogout.Location = new System.Drawing.Point(1005, 28);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(129, 53);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // lblHead
            // 
            this.lblHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(212, 32);
            this.lblHead.MaximumSize = new System.Drawing.Size(800, 0);
            this.lblHead.MinimumSize = new System.Drawing.Size(790, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(790, 45);
            this.lblHead.TabIndex = 37;
            this.lblHead.Text = "Welcome!";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHome.Location = new System.Drawing.Point(51, 28);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(158, 53);
            this.btnHome.TabIndex = 39;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(188)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1185, 861);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnLogout);
            this.Name = "Form5";
            this.Text = "Edit User Details Form";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUserDeets;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblUId;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
    }
}