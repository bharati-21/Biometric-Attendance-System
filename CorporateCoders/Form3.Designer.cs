namespace CorporateCoders
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUId = new System.Windows.Forms.TextBox();
            this.lblUId = new System.Windows.Forms.Label();
            this.errorProviderUId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPsd = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPsd)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogin.Location = new System.Drawing.Point(670, 619);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 45);
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Maroon;
            this.txtPassword.Location = new System.Drawing.Point(818, 497);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(214, 39);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
            this.txtPassword.Validated += new System.EventHandler(this.TxtPassword_Validated);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Maroon;
            this.txtName.Location = new System.Drawing.Point(818, 412);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 39);
            this.txtName.TabIndex = 22;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.TxtName_Validated);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Maroon;
            this.lblPassword.Location = new System.Drawing.Point(515, 500);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(130, 32);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Maroon;
            this.lblName.Location = new System.Drawing.Point(515, 415);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 32);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name";
            // 
            // txtUId
            // 
            this.txtUId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUId.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUId.ForeColor = System.Drawing.Color.Maroon;
            this.txtUId.Location = new System.Drawing.Point(818, 327);
            this.txtUId.Name = "txtUId";
            this.txtUId.Size = new System.Drawing.Size(214, 39);
            this.txtUId.TabIndex = 21;
            this.txtUId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUId_Validating);
            this.txtUId.Validated += new System.EventHandler(this.TxtUId_Validated);
            // 
            // lblUId
            // 
            this.lblUId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUId.AutoSize = true;
            this.lblUId.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUId.ForeColor = System.Drawing.Color.Maroon;
            this.lblUId.Location = new System.Drawing.Point(515, 330);
            this.lblUId.Name = "lblUId";
            this.lblUId.Size = new System.Drawing.Size(106, 32);
            this.lblUId.TabIndex = 25;
            this.lblUId.Text = "User ID";
            // 
            // errorProviderUId
            // 
            this.errorProviderUId.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderPsd
            // 
            this.errorProviderPsd.ContainerControl = this;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Font = new System.Drawing.Font("Times New Roman", 34F, System.Drawing.FontStyle.Bold);
            this.lblUserLogin.ForeColor = System.Drawing.Color.Maroon;
            this.lblUserLogin.Location = new System.Drawing.Point(572, 168);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(383, 65);
            this.lblUserLogin.TabIndex = 31;
            this.lblUserLogin.Text = "USER LOGIN";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Forgot Password?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 836);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(188)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1201, 832);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserLogin);
            this.Controls.Add(this.txtUId);
            this.Controls.Add(this.lblUId);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Name = "Form3";
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.VisibleChanged += new System.EventHandler(this.Form3_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPsd)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUId;
        private System.Windows.Forms.Label lblUId;
        private System.Windows.Forms.ErrorProvider errorProviderUId;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderPsd;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}