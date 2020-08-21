namespace CorporateCoders
{
    partial class ViewAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAttendance));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.rbnViewIndividual = new System.Windows.Forms.RadioButton();
            this.rbnViewAll = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHome.Location = new System.Drawing.Point(394, 34);
            this.btnHome.Margin = new System.Windows.Forms.Padding(10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(131, 57);
            this.btnHome.TabIndex = 47;
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
            this.btnLogout.Location = new System.Drawing.Point(992, 34);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 57);
            this.btnLogout.TabIndex = 43;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // rbnViewIndividual
            // 
            this.rbnViewIndividual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnViewIndividual.AutoSize = true;
            this.rbnViewIndividual.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnViewIndividual.Location = new System.Drawing.Point(543, 315);
            this.rbnViewIndividual.Name = "rbnViewIndividual";
            this.rbnViewIndividual.Size = new System.Drawing.Size(438, 36);
            this.rbnViewIndividual.TabIndex = 49;
            this.rbnViewIndividual.TabStop = true;
            this.rbnViewIndividual.Text = "VIEW ATTENDANCE BY USER";
            this.rbnViewIndividual.UseVisualStyleBackColor = true;
            this.rbnViewIndividual.CheckedChanged += new System.EventHandler(this.RbnViewIndividual_CheckedChanged);
            // 
            // rbnViewAll
            // 
            this.rbnViewAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnViewAll.AutoSize = true;
            this.rbnViewAll.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnViewAll.Location = new System.Drawing.Point(524, 416);
            this.rbnViewAll.Name = "rbnViewAll";
            this.rbnViewAll.Size = new System.Drawing.Size(476, 36);
            this.rbnViewAll.TabIndex = 50;
            this.rbnViewAll.TabStop = true;
            this.rbnViewAll.Text = "VIEW ALL USER\'S ATTENDANCE";
            this.rbnViewAll.UseVisualStyleBackColor = true;
            this.rbnViewAll.CheckedChanged += new System.EventHandler(this.RbnViewAll_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 836);
            this.panel1.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1169, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbnViewAll);
            this.Controls.Add(this.rbnViewIndividual);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLogout);
            this.Name = "ViewAttendance";
            this.Text = "View Attendance";
            this.Load += new System.EventHandler(this.ViewAttendance_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.RadioButton rbnViewIndividual;
        private System.Windows.Forms.RadioButton rbnViewAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}