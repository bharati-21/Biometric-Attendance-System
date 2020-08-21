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
    public partial class Form9 : Form
    {
        
        public Form9()
        {
            InitializeComponent();
        }


        private void Form9_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            this.reqTableTableAdapter.Fill(this.database1DataSet.reqTable);
            // TODO: This line of code loads data into the 'database1DataSet1.reqTable' table. You can move, or remove it, as needed.
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                con.Open();
                String check = "select *from [dbo].[reqTable]";
                SqlDataAdapter sa = new SqlDataAdapter();
                sa.SelectCommand = new SqlCommand(check, con);

                //sa.SelectCommand.Parameters.AddWithValue("@year", DateTime.Now.Year);
                //sa.SelectCommand.Parameters.AddWithValue("@month", Microsoft.VisualBasic.DateAndTime.MonthName(DateTime.Now.Month));
                sa.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                sa.Fill(ds, "reqTable");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "reqTable";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

        }
    }
}
