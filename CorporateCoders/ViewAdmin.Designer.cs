namespace CorporateCoders
{
    partial class ViewAdmin
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPsd = new System.Windows.Forms.TextBox();
            this.lblPsd = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdminDetails = new System.Windows.Forms.Label();
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPsd = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPsd)).BeginInit();
            this.grpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(430, 290);
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
            this.txtPsd.Location = new System.Drawing.Point(512, 175);
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
            this.lblPsd.Location = new System.Drawing.Point(137, 177);
            this.lblPsd.Name = "lblPsd";
            this.lblPsd.Size = new System.Drawing.Size(173, 32);
            this.lblPsd.TabIndex = 17;
            this.lblPsd.Text = "PASSWORD";
            this.lblPsd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(512, 63);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(434, 34);
            this.txtName.TabIndex = 8;
            this.txtName.Validated += new System.EventHandler(this.TxtName_Validated);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Maroon;
            this.lblName.Location = new System.Drawing.Point(137, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 32);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminDetails
            // 
            this.lblAdminDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdminDetails.AutoSize = true;
            this.lblAdminDetails.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDetails.ForeColor = System.Drawing.Color.Maroon;
            this.lblAdminDetails.Location = new System.Drawing.Point(241, 25);
            this.lblAdminDetails.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblAdminDetails.MinimumSize = new System.Drawing.Size(700, 0);
            this.lblAdminDetails.Name = "lblAdminDetails";
            this.lblAdminDetails.Size = new System.Drawing.Size(700, 55);
            this.lblAdminDetails.TabIndex = 47;
            this.lblAdminDetails.Text = "ADMIN DETAILS";
            this.lblAdminDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderPsd
            // 
            this.errorProviderPsd.ContainerControl = this;
            // 
            // grpBox1
            // 
            this.grpBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpBox1.Controls.Add(this.btnSave);
            this.grpBox1.Controls.Add(this.txtPsd);
            this.grpBox1.Controls.Add(this.lblPsd);
            this.grpBox1.Controls.Add(this.txtName);
            this.grpBox1.Controls.Add(this.lblName);
            this.grpBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox1.Location = new System.Drawing.Point(51, 233);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(1083, 394);
            this.grpBox1.TabIndex = 48;
            this.grpBox1.TabStop = false;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // ViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1185, 861);
            this.Controls.Add(this.lblAdminDetails);
            this.Controls.Add(this.grpBox1);
            this.Name = "ViewAdmin";
            this.Text = "ViewAdmin";
            this.Load += new System.EventHandler(this.ViewAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPsd)).EndInit();
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPsd;
        private System.Windows.Forms.Label lblPsd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdminDetails;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderPsd;
        private System.Windows.Forms.ErrorProvider errorProviderName;
    }
}