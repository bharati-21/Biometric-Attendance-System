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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                con.Open();

                SqlCommand command = new SqlCommand("select *from [User]", con);
                SqlDataAdapter adapter = new SqlDataAdapter("select *from [User]", con);
                this.reportViewer1.RefreshReport();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "User");
                DataTable dt = ds.Tables["User"];
                reportViewer1.LocalReport.ReportPath = @"C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\ViewAllUsers.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nAN UNEXPECTED ERROR OCCURED WHILE LOADING YOUR DATA.", "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();            
        }
    }
}
