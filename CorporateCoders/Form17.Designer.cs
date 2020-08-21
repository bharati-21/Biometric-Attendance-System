namespace CorporateCoders
{
    partial class Form17
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
            this.lblUserDeets = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUId = new System.Windows.Forms.Label();
            this.txturrReqStatus = new System.Windows.Forms.TextBox();
            this.lblCurr = new System.Windows.Forms.Label();
            this.txtCurrAttStatus = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.cmbChangeReqStatus = new System.Windows.Forms.ComboBox();
            this.lblChngAtt = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtChngAtt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUserDeets
            // 
            this.lblUserDeets.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserDeets.AutoSize = true;
            this.lblUserDeets.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDeets.Location = new System.Drawing.Point(278, 15);
            this.lblUserDeets.Name = "lblUserDeets";
            this.lblUserDeets.Size = new System.Drawing.Size(645, 43);
            this.lblUserDeets.TabIndex = 0;
            this.lblUserDeets.Text = "UPDATE COMING LATE REQUEST";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(196, 534);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(284, 23);
            this.lblStatus.TabIndex = 59;
            this.lblStatus.Text = "CURRENT REQUEST STATUS";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(571, 294);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(434, 30);
            this.txtDate.TabIndex = 56;
            // 
            // txtArrival
            // 
            this.txtArrival.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArrival.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtArrival.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrival.Location = new System.Drawing.Point(571, 222);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.ReadOnly = true;
            this.txtArrival.Size = new System.Drawing.Size(434, 30);
            this.txtArrival.TabIndex = 55;
            // 
            // txtReason
            // 
            this.txtReason.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReason.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtReason.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(571, 359);
            this.txtReason.MaxLength = 5000;
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ReadOnly = true;
            this.txtReason.Size = new System.Drawing.Size(434, 136);
            this.txtReason.TabIndex = 57;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(200, 819);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 60);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(571, 154);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(434, 30);
            this.txtName.TabIndex = 54;
            // 
            // txtUid
            // 
            this.txtUid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUid.Location = new System.Drawing.Point(571, 91);
            this.txtUid.Name = "txtUid";
            this.txtUid.ReadOnly = true;
            this.txtUid.Size = new System.Drawing.Size(434, 30);
            this.txtUid.TabIndex = 53;
            // 
            // lblDept
            // 
            this.lblDept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(196, 364);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(92, 23);
            this.lblDept.TabIndex = 52;
            this.lblDept.Text = "REASON";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(196, 299);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(193, 23);
            this.lblDate.TabIndex = 51;
            this.lblDate.Text = "DATE OF REQUEST";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(196, 227);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(183, 23);
            this.lblTime.TabIndex = 50;
            this.lblTime.Text = "TIME OF ARRIVAL";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(196, 159);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 23);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUId
            // 
            this.lblUId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUId.AutoSize = true;
            this.lblUId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUId.Location = new System.Drawing.Point(196, 96);
            this.lblUId.Name = "lblUId";
            this.lblUId.Size = new System.Drawing.Size(88, 23);
            this.lblUId.TabIndex = 48;
            this.lblUId.Text = "USER ID";
            this.lblUId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txturrReqStatus
            // 
            this.txturrReqStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txturrReqStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txturrReqStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturrReqStatus.Location = new System.Drawing.Point(571, 532);
            this.txturrReqStatus.Name = "txturrReqStatus";
            this.txturrReqStatus.ReadOnly = true;
            this.txturrReqStatus.Size = new System.Drawing.Size(434, 30);
            this.txturrReqStatus.TabIndex = 58;
            // 
            // lblCurr
            // 
            this.lblCurr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurr.AutoSize = true;
            this.lblCurr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurr.Location = new System.Drawing.Point(196, 606);
            this.lblCurr.Name = "lblCurr";
            this.lblCurr.Size = new System.Drawing.Size(324, 23);
            this.lblCurr.TabIndex = 61;
            this.lblCurr.Text = "CURRENT ATTENDANCE STATUS";
            this.lblCurr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrAttStatus
            // 
            this.txtCurrAttStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrAttStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCurrAttStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrAttStatus.Location = new System.Drawing.Point(571, 599);
            this.txtCurrAttStatus.Name = "txtCurrAttStatus";
            this.txtCurrAttStatus.ReadOnly = true;
            this.txtCurrAttStatus.Size = new System.Drawing.Size(434, 30);
            this.txtCurrAttStatus.TabIndex = 59;
            // 
            // lblChange
            // 
            this.lblChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(196, 672);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(308, 23);
            this.lblChange.TabIndex = 63;
            this.lblChange.Text = "CHANGE REQUEST STATUS TO";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbChangeReqStatus
            // 
            this.cmbChangeReqStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbChangeReqStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChangeReqStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChangeReqStatus.FormattingEnabled = true;
            this.cmbChangeReqStatus.Location = new System.Drawing.Point(571, 669);
            this.cmbChangeReqStatus.Name = "cmbChangeReqStatus";
            this.cmbChangeReqStatus.Size = new System.Drawing.Size(434, 31);
            this.cmbChangeReqStatus.TabIndex = 60;
            this.cmbChangeReqStatus.SelectedIndexChanged += new System.EventHandler(this.CmbChangeReqStatus_SelectedIndexChanged);
            // 
            // lblChngAtt
            // 
            this.lblChngAtt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChngAtt.AutoSize = true;
            this.lblChngAtt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChngAtt.Location = new System.Drawing.Point(196, 741);
            this.lblChngAtt.Name = "lblChngAtt";
            this.lblChngAtt.Size = new System.Drawing.Size(314, 23);
            this.lblChngAtt.TabIndex = 65;
            this.lblChngAtt.Text = "CHANGE ATTENDANCE STATUS";
            this.lblChngAtt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(824, 819);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 60);
            this.btnCancel.TabIndex = 63;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtChngAtt
            // 
            this.txtChngAtt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChngAtt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtChngAtt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChngAtt.Location = new System.Drawing.Point(571, 739);
            this.txtChngAtt.Name = "txtChngAtt";
            this.txtChngAtt.ReadOnly = true;
            this.txtChngAtt.Size = new System.Drawing.Size(434, 30);
            this.txtChngAtt.TabIndex = 61;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1200, 912);
            this.Controls.Add(this.txtChngAtt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblChngAtt);
            this.Controls.Add(this.cmbChangeReqStatus);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtCurrAttStatus);
            this.Controls.Add(this.lblCurr);
            this.Controls.Add(this.txturrReqStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUId);
            this.Controls.Add(this.lblUserDeets);
            this.Name = "Form17";
            this.Text = "Coming Late Request Form";
            this.Load += new System.EventHandler(this.Form17_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserDeets;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUId;
        private System.Windows.Forms.TextBox txturrReqStatus;
        private System.Windows.Forms.Label lblCurr;
        private System.Windows.Forms.TextBox txtCurrAttStatus;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.ComboBox cmbChangeReqStatus;
        private System.Windows.Forms.Label lblChngAtt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtChngAtt;
    }
}