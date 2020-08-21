namespace CorporateCoders
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdminLogin.BackColor = System.Drawing.Color.Black;
            this.btnAdminLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdminLogin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.btnAdminLogin.Location = new System.Drawing.Point(26, 52);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(241, 64);
            this.btnAdminLogin.TabIndex = 6;
            this.btnAdminLogin.Text = "ADMIN LOGIN";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.BtnAdminLogin_Click);
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserLogin.BackColor = System.Drawing.Color.Black;
            this.btnUserLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUserLogin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.btnUserLogin.Location = new System.Drawing.Point(26, 53);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(241, 64);
            this.btnUserLogin.TabIndex = 7;
            this.btnUserLogin.Text = "USER LOGIN";
            this.btnUserLogin.UseVisualStyleBackColor = false;
            this.btnUserLogin.Click += new System.EventHandler(this.BtnUserLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.pictureBoxLogo1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 754);
            this.panel1.TabIndex = 32;
            // 
            // pictureBoxLogo1
            // 
            this.pictureBoxLogo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo1.Image")));
            this.pictureBoxLogo1.Location = new System.Drawing.Point(15, 0);
            this.pictureBoxLogo1.Name = "pictureBoxLogo1";
            this.pictureBoxLogo1.Size = new System.Drawing.Size(318, 205);
            this.pictureBoxLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo1.TabIndex = 31;
            this.pictureBoxLogo1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel3.Controls.Add(this.btnAdminLogin);
            this.panel3.Location = new System.Drawing.Point(611, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 167);
            this.panel3.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel4.Controls.Add(this.btnUserLogin);
            this.panel4.Location = new System.Drawing.Point(611, 430);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 167);
            this.panel4.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1194, 752);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

