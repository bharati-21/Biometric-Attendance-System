namespace CorporateCoders
{
    partial class Form12
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
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPsd = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUserDeets = new System.Windows.Forms.Label();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPsd = new System.Windows.Forms.TextBox();
            this.lblPsd = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            this.grpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderPsd
            // 
            this.errorProviderPsd.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // lblUserDeets
            // 
            this.lblUserDeets.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserDeets.AutoSize = true;
            this.lblUserDeets.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDeets.ForeColor = System.Drawing.Color.Maroon;
            this.lblUserDeets.Location = new System.Drawing.Point(236, 33);
            this.lblUserDeets.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblUserDeets.MinimumSize = new System.Drawing.Size(700, 0);
            this.lblUserDeets.Name = "lblUserDeets";
            this.lblUserDeets.Size = new System.Drawing.Size(700, 55);
            this.lblUserDeets.TabIndex = 19;
            this.lblUserDeets.Text = "USER DETAILS";
            this.lblUserDeets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBox1
            // 
            this.grpBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpBox1.Controls.Add(this.btnSave);
            this.grpBox1.Controls.Add(this.txtPsd);
            this.grpBox1.Controls.Add(this.lblPsd);
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
            this.grpBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox1.Location = new System.Drawing.Point(46, 143);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(1083, 700);
            this.grpBox1.TabIndex = 46;
            this.grpBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(461, 622);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 57);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtPsd
            // 
            this.txtPsd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPsd.Location = new System.Drawing.Point(524, 216);
            this.txtPsd.Name = "txtPsd";
            this.txtPsd.PasswordChar = '*';
            this.txtPsd.Size = new System.Drawing.Size(434, 34);
            this.txtPsd.TabIndex = 9;
            this.txtPsd.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPsd_Validating);
            this.txtPsd.Validated += new System.EventHandler(this.TxtPsd_Validated);
            // 
            // lblPsd
            // 
            this.lblPsd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPsd.AutoSize = true;
            this.lblPsd.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsd.ForeColor = System.Drawing.Color.Maroon;
            this.lblPsd.Location = new System.Drawing.Point(149, 218);
            this.lblPsd.Name = "lblPsd";
            this.lblPsd.Size = new System.Drawing.Size(173, 32);
            this.lblPsd.TabIndex = 17;
            this.lblPsd.Text = "PASSWORD";
            this.lblPsd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDept
            // 
            this.cmbDept.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.cmbDept.Location = new System.Drawing.Point(524, 458);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(434, 33);
            this.cmbDept.TabIndex = 12;
            // 
            // dtpDob
            // 
            this.dtpDob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDob.Location = new System.Drawing.Point(524, 543);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(434, 34);
            this.dtpDob.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(524, 377);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(434, 34);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPhone_Validating);
            this.txtPhone.Validated += new System.EventHandler(this.TxtPhone_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(524, 297);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(434, 34);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.TxtEmail_Validated);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(524, 136);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(434, 34);
            this.txtName.TabIndex = 8;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.TxtName_Validated);
            // 
            // txtUid
            // 
            this.txtUid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUid.BackColor = System.Drawing.SystemColors.Control;
            this.txtUid.Location = new System.Drawing.Point(524, 51);
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
            this.lblDob.ForeColor = System.Drawing.Color.Maroon;
            this.lblDob.Location = new System.Drawing.Point(149, 545);
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
            this.lblDept.ForeColor = System.Drawing.Color.Maroon;
            this.lblDept.Location = new System.Drawing.Point(149, 459);
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
            this.lblPhone.ForeColor = System.Drawing.Color.Maroon;
            this.lblPhone.Location = new System.Drawing.Point(149, 379);
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
            this.lblEmail.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmail.Location = new System.Drawing.Point(149, 299);
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
            this.lblName.ForeColor = System.Drawing.Color.Maroon;
            this.lblName.Location = new System.Drawing.Point(149, 138);
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
            this.lblUId.ForeColor = System.Drawing.Color.Maroon;
            this.lblUId.Location = new System.Drawing.Point(149, 53);
            this.lblUId.Name = "lblUId";
            this.lblUId.Size = new System.Drawing.Size(127, 32);
            this.lblUId.TabIndex = 1;
            this.lblUId.Text = "USER ID";
            this.lblUId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1172, 1055);
            this.Controls.Add(this.lblUserDeets);
            this.Controls.Add(this.grpBox1);
            this.Name = "Form12";
            this.Text = "Individual User Details";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderPsd;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Label lblUserDeets;
        private System.Windows.Forms.TextBox txtPsd;
        private System.Windows.Forms.Label lblPsd;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUId;
        private System.Windows.Forms.Button btnSave;
    }
}