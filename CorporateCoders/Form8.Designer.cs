namespace CorporateCoders
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.btnChoose = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUId = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblHead = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrStatus = new System.Windows.Forms.TextBox();
            this.cmbChange = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUId)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChoose.BackColor = System.Drawing.Color.Black;
            this.btnChoose.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(50)))));
            this.btnChoose.Location = new System.Drawing.Point(650, 465);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(188, 61);
            this.btnChoose.TabIndex = 59;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Maroon;
            this.txtName.Location = new System.Drawing.Point(828, 310);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 30);
            this.txtName.TabIndex = 58;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.TxtName_Validated);
            // 
            // txtUid
            // 
            this.txtUid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUid.ForeColor = System.Drawing.Color.Maroon;
            this.txtUid.Location = new System.Drawing.Point(828, 242);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(214, 30);
            this.txtUid.TabIndex = 57;
            this.txtUid.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUid_Validating);
            this.txtUid.Validated += new System.EventHandler(this.TxtUid_Validated);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Maroon;
            this.lblName.Location = new System.Drawing.Point(458, 312);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 26);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "NAME";
            // 
            // lblUid
            // 
            this.lblUid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUid.ForeColor = System.Drawing.Color.Maroon;
            this.lblUid.Location = new System.Drawing.Point(458, 244);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(107, 26);
            this.lblUid.TabIndex = 55;
            this.lblUid.Text = "USER ID";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderUId
            // 
            this.errorProviderUId.ContainerControl = this;
            // 
            // lblHead
            // 
            this.lblHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.Maroon;
            this.lblHead.Location = new System.Drawing.Point(434, 158);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(630, 37);
            this.lblHead.TabIndex = 63;
            this.lblHead.Text = "Enter user credentials to change attendance";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(17)))));
            this.btnHome.Location = new System.Drawing.Point(389, 14);
            this.btnHome.Margin = new System.Windows.Forms.Padding(10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(131, 56);
            this.btnHome.TabIndex = 62;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(17)))));
            this.btnLogout.Location = new System.Drawing.Point(1007, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 56);
            this.btnLogout.TabIndex = 61;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Location = new System.Drawing.Point(458, 381);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(184, 26);
            this.lblDate.TabIndex = 64;
            this.lblDate.Text = "CHOOSE DATE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(828, 378);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 4, 19, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 30);
            this.dateTimePicker1.TabIndex = 65;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 19, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(458, 675);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 66;
            this.label1.Text = "CURRENT STATUS";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(458, 762);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 26);
            this.label2.TabIndex = 67;
            this.label2.Text = "CHANGE STATUS TO";
            this.label2.Visible = false;
            // 
            // txtCurrStatus
            // 
            this.txtCurrStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrStatus.ForeColor = System.Drawing.Color.Maroon;
            this.txtCurrStatus.Location = new System.Drawing.Point(828, 675);
            this.txtCurrStatus.Name = "txtCurrStatus";
            this.txtCurrStatus.ReadOnly = true;
            this.txtCurrStatus.Size = new System.Drawing.Size(214, 30);
            this.txtCurrStatus.TabIndex = 68;
            this.txtCurrStatus.Visible = false;
            // 
            // cmbChange
            // 
            this.cmbChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChange.FormattingEnabled = true;
            this.cmbChange.Location = new System.Drawing.Point(828, 766);
            this.cmbChange.Name = "cmbChange";
            this.cmbChange.Size = new System.Drawing.Size(214, 24);
            this.cmbChange.TabIndex = 69;
            this.cmbChange.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(50)))));
            this.btnUpdate.Location = new System.Drawing.Point(650, 865);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 61);
            this.btnUpdate.TabIndex = 70;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 1000);
            this.panel1.TabIndex = 71;
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
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(137)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1170, 990);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbChange);
            this.Controls.Add(this.txtCurrStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Name = "Form8";
            this.Text = "Update Attendance";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUId)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ErrorProvider errorProviderUId;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbChange;
        private System.Windows.Forms.TextBox txtCurrStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}