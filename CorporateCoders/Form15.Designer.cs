namespace CorporateCoders
{
    partial class Form15
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet3 = new CorporateCoders.Database1DataSet3();
            this.lblHead = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AttendanceTableAdapter = new CorporateCoders.Database1DataSet3TableAdapters.AttendanceTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // AttendanceBindingSource
            // 
            this.AttendanceBindingSource.DataMember = "Attendance";
            this.AttendanceBindingSource.DataSource = this.Database1DataSet3;
            // 
            // Database1DataSet3
            // 
            this.Database1DataSet3.DataSetName = "Database1DataSet3";
            this.Database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblHead
            // 
            this.lblHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Location = new System.Drawing.Point(376, 29);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(390, 37);
            this.lblHead.TabIndex = 1;
            this.lblHead.Text = "ATTENDANCE REPORT";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportViewer1.AutoScroll = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AttendanceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CorporateCoders.AttendanceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(52, 120);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1053, 498);
            this.reportViewer1.TabIndex = 0;
            // 
            // AttendanceTableAdapter
            // 
            this.AttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(401, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(401, 741);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1157, 936);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form15";
            this.Text = "Attendance Report";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHead;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AttendanceBindingSource;
        private Database1DataSet3 Database1DataSet3;
        private Database1DataSet3TableAdapters.AttendanceTableAdapter AttendanceTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}