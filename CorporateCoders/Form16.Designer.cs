namespace CorporateCoders
{
    partial class Form16
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
            this.Database1DataSet4 = new CorporateCoders.Database1DataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblHead = new System.Windows.Forms.Label();
            this.AttendanceTableAdapter = new CorporateCoders.Database1DataSet4TableAdapters.AttendanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // AttendanceBindingSource
            // 
            this.AttendanceBindingSource.DataMember = "Attendance";
            this.AttendanceBindingSource.DataSource = this.Database1DataSet4;
            // 
            // Database1DataSet4
            // 
            this.Database1DataSet4.DataSetName = "Database1DataSet4";
            this.Database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportViewer1.DocumentMapWidth = 98;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AttendanceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CorporateCoders.AttendanceReportAll.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 141);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1130, 568);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
            // 
            // lblHead
            // 
            this.lblHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Location = new System.Drawing.Point(375, 43);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(390, 37);
            this.lblHead.TabIndex = 1;
            this.lblHead.Text = "ATTENDANCE REPORT";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttendanceTableAdapter
            // 
            this.AttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1154, 749);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form16";
            this.Text = "All Users Attendance Report";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblHead;
        private Database1DataSet4 Database1DataSet4;
        private System.Windows.Forms.BindingSource AttendanceBindingSource;
        private Database1DataSet4TableAdapters.AttendanceTableAdapter AttendanceTableAdapter;
    }
}