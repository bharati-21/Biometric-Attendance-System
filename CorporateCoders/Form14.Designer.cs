﻿namespace CorporateCoders
{
    partial class Form14
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestLeftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new CorporateCoders.Database1DataSet();
            this.lblHead = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reqTableTableAdapter = new CorporateCoders.Database1DataSetTableAdapters.reqTableTableAdapter();
            this.btnViewAllRequests = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dayOfMonthDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.reqTimeDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.requestLeftDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reqTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dayOfMonthDataGridViewTextBoxColumn
            // 
            this.dayOfMonthDataGridViewTextBoxColumn.DataPropertyName = "dayOfMonth";
            this.dayOfMonthDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dayOfMonthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayOfMonthDataGridViewTextBoxColumn.Name = "dayOfMonthDataGridViewTextBoxColumn";
            this.dayOfMonthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayOfMonthDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqTimeDataGridViewTextBoxColumn
            // 
            this.reqTimeDataGridViewTextBoxColumn.DataPropertyName = "ReqTime";
            this.reqTimeDataGridViewTextBoxColumn.HeaderText = "Arrival Time";
            this.reqTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reqTimeDataGridViewTextBoxColumn.Name = "reqTimeDataGridViewTextBoxColumn";
            this.reqTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.reqTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // requestLeftDataGridViewTextBoxColumn
            // 
            this.requestLeftDataGridViewTextBoxColumn.DataPropertyName = "requestLeft";
            this.requestLeftDataGridViewTextBoxColumn.HeaderText = "CL Requests Left";
            this.requestLeftDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestLeftDataGridViewTextBoxColumn.Name = "requestLeftDataGridViewTextBoxColumn";
            this.requestLeftDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestLeftDataGridViewTextBoxColumn.Width = 125;
            // 
            // reqTableBindingSource
            // 
            this.reqTableBindingSource.DataMember = "reqTable";
            this.reqTableBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblHead
            // 
            this.lblHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(312, 56);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(618, 37);
            this.lblHead.TabIndex = 1;
            this.lblHead.Text = "SELECT ROW TO APPROVE REQUEST";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(489, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "APPROVE REQUEST";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // reqTableTableAdapter
            // 
            this.reqTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnViewAllRequests
            // 
            this.btnViewAllRequests.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewAllRequests.BackColor = System.Drawing.Color.Black;
            this.btnViewAllRequests.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllRequests.ForeColor = System.Drawing.Color.White;
            this.btnViewAllRequests.Location = new System.Drawing.Point(489, 665);
            this.btnViewAllRequests.Name = "btnViewAllRequests";
            this.btnViewAllRequests.Size = new System.Drawing.Size(290, 67);
            this.btnViewAllRequests.TabIndex = 3;
            this.btnViewAllRequests.Text = "VIEW ALL REQUESTS";
            this.btnViewAllRequests.UseVisualStyleBackColor = false;
            this.btnViewAllRequests.Click += new System.EventHandler(this.BtnViewAllRequests_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1269, 744);
            this.Controls.Add(this.btnViewAllRequests);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form14";
            this.Text = "Approve CL Requests";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource reqTableBindingSource;
        private Database1DataSetTableAdapters.reqTableTableAdapter reqTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayOfMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestLeftDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnViewAllRequests;
    }
}