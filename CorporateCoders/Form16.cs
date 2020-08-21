using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorporateCoders
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            try
            {
                // TODO: This line of code loads data into the 'Database1DataSet3.Attendance' table. You can move, or remove it, as needed.
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("select *from [Attendance]", con);
                adapter.SelectCommand = new SqlCommand("select *from [Attendance]", con);
                adapter.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Attendance");
                DataTable dt = ds.Tables["Attendance"];

                reportViewer1.LocalReport.ReportPath = @"C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\AttendanceReportAll.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));

                this.reportViewer1.RefreshReport();
                // TODO: This line of code loads data into the 'Database1DataSet3.Attendance' table. You can move, or remove it, as needed.
            }
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }


        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
