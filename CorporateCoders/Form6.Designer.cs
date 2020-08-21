namespace CorporateCoders
{
    partial class Form6
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
            this.lblHead = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheckRequests = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblCL = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUId = new System.Windows.Forms.Label();
            this.lblUserDeets = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.grpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHome.Location = new System.Drawing.Point(53, 14);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 51);
            this.btnHome.TabIndex = 43;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // lblHead
            // 
            this.lblHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(185, 18);
            this.lblHead.MaximumSize = new System.Drawing.Size(80, 0);
            this.lblHead.MinimumSize = new System.Drawing.Size(800, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(800, 45);
            this.lblHead.TabIndex = 41;
            this.lblHead.Text = "Welcome!";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnLogout.Location = new System.Drawing.Point(997, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(139, 51);
            this.btnLogout.TabIndex = 40;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // grpBox1
            // 
            this.grpBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.grpBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpBox1.Controls.Add(this.txtTime);
            this.grpBox1.Controls.Add(this.btnCheckRequests);
            this.grpBox1.Controls.Add(this.lblNote);
            this.grpBox1.Controls.Add(this.lblCL);
            this.grpBox1.Controls.Add(this.txtReason);
            this.grpBox1.Controls.Add(this.btnSave);
            this.grpBox1.Controls.Add(this.dtpDate);
            this.grpBox1.Controls.Add(this.txtName);
            this.grpBox1.Controls.Add(this.txtUid);
            this.grpBox1.Controls.Add(this.lblDept);
            this.grpBox1.Controls.Add(this.lblDate);
            this.grpBox1.Controls.Add(this.lblTime);
            this.grpBox1.Controls.Add(this.lblName);
            this.grpBox1.Controls.Add(this.lblUId);
            this.grpBox1.Controls.Add(this.lblUserDeets);
            this.grpBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox1.Location = new System.Drawing.Point(53, 94);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(1083, 812);
            this.grpBox1.TabIndex = 44;
            this.grpBox1.TabStop = false;
            // 
            // btnCheckRequests
            // 
            this.btnCheckRequests.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckRequests.BackColor = System.Drawing.Color.White;
            this.btnCheckRequests.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckRequests.Location = new System.Drawing.Point(3, 741);
            this.btnCheckRequests.Name = "btnCheckRequests";
            this.btnCheckRequests.Size = new System.Drawing.Size(1077, 68);
            this.btnCheckRequests.TabIndex = 14;
            this.btnCheckRequests.Text = "CHECK YOUR REQUESTS HERE";
            this.btnCheckRequests.UseVisualStyleBackColor = false;
            this.btnCheckRequests.Click += new System.EventHandler(this.BtnCheckRequests_Click);
            // 
            // lblNote
            // 
            this.lblNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(42, 81);
            this.lblNote.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lblNote.MinimumSize = new System.Drawing.Size(1000, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(1000, 19);
            this.lblNote.TabIndex = 23;
            this.lblNote.Text = "COMING LATE/ ATTENDANCE REQUEST FORM";
            // 
            // lblCL
            // 
            this.lblCL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCL.AutoSize = true;
            this.lblCL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCL.ForeColor = System.Drawing.Color.White;
            this.lblCL.Location = new System.Drawing.Point(357, 700);
            this.lblCL.Name = "lblCL";
            this.lblCL.Size = new System.Drawing.Size(275, 23);
            this.lblCL.TabIndex = 22;
            this.lblCL.Text = "Number of CL requests left for ";
            this.lblCL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReason
            // 
            this.txtReason.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReason.Location = new System.Drawing.Point(450, 474);
            this.txtReason.MaxLength = 1000;
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(434, 136);
            this.txtReason.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(515, 641);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 43);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.Location = new System.Drawing.Point(450, 323);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(434, 34);
            this.dtpDate.TabIndex = 11;
            this.dtpDate.Leave += new System.EventHandler(this.DtpDate_Leave);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(450, 234);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(434, 34);
            this.txtName.TabIndex = 8;
            // 
            // txtUid
            // 
            this.txtUid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUid.BackColor = System.Drawing.SystemColors.Control;
            this.txtUid.Location = new System.Drawing.Point(450, 154);
            this.txtUid.Name = "txtUid";
            this.txtUid.ReadOnly = true;
            this.txtUid.Size = new System.Drawing.Size(434, 34);
            this.txtUid.TabIndex = 7;
            // 
            // lblDept
            // 
            this.lblDept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.ForeColor = System.Drawing.Color.White;
            this.lblDept.Location = new System.Drawing.Point(202, 479);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(92, 23);
            this.lblDept.TabIndex = 5;
            this.lblDept.Text = "REASON";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(202, 332);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(193, 23);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "DATE OF REQUEST";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(202, 411);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(183, 23);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "TIME OF ARRIVAL";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(202, 239);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUId
            // 
            this.lblUId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUId.AutoSize = true;
            this.lblUId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUId.ForeColor = System.Drawing.Color.White;
            this.lblUId.Location = new System.Drawing.Point(202, 159);
            this.lblUId.Name = "lblUId";
            this.lblUId.Size = new System.Drawing.Size(88, 23);
            this.lblUId.TabIndex = 1;
            this.lblUId.Text = "USER ID";
            this.lblUId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserDeets
            // 
            this.lblUserDeets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserDeets.AutoSize = true;
            this.lblUserDeets.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDeets.ForeColor = System.Drawing.Color.White;
            this.lblUserDeets.Location = new System.Drawing.Point(216, 21);
            this.lblUserDeets.Name = "lblUserDeets";
            this.lblUserDeets.Size = new System.Drawing.Size(705, 35);
            this.lblUserDeets.TabIndex = 0;
            this.lblUserDeets.Text = "COMING LATE/ ATTENDANCE REQUEST FORM";
            // 
            // txtTime
            // 
            this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTime.Location = new System.Drawing.Point(450, 400);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(434, 34);
            this.txtTime.TabIndex = 24;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(188)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1191, 1055);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnLogout);
            this.Name = "Form6";
            this.Text = "User CL Request Form";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUId;
        private System.Windows.Forms.Label lblUserDeets;
        private System.Windows.Forms.Button btnCheckRequests;
        private System.Windows.Forms.Label lblCL;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtTime;
    }
}