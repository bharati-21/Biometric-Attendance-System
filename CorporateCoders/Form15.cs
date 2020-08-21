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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        IndividualUserAttendance f = null;
        Form4 f4 = null;
        public string name, id;
        public Form15(IndividualUserAttendance ff)
        {
            InitializeComponent();
            f = ff as IndividualUserAttendance;
            name = f.name;
            id = f.id;
        }

        public Form15(Form4 ff)
        {
            InitializeComponent();
            f4 = ff as Form4;
            name = f4.name;
            id = f4.id;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;



            // TODO: This line of code loads data into the 'Database1DataSet3.Attendance' table. You can move, or remove it, as needed.
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                con.Open();
                String cmd = "select *from [Attendance] where Id=@id and Name = @name";
                SqlDataAdapter sa = new SqlDataAdapter(cmd, con);

                sa.SelectCommand = new SqlCommand(cmd, con);
                sa.SelectCommand.Parameters.AddWithValue("@name", name);
                sa.SelectCommand.Parameters.AddWithValue("@id", id);
                sa.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();

                sa.Fill(ds, "Attendance");
                DataTable dt = ds.Tables["Attendance"];


                reportViewer1.LocalReport.ReportPath = @"C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\AttendanceReport.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));

                this.reportViewer1.RefreshReport();
                con.Close();
            }

         
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                con.Open();
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                con2.Open();
                SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                con3.Open();

                //String sql1 = "SELECT count(distinct([DayOfMonth])) FROM[Attendance] GROUP BY  MONTH, YEAR";
                String sql1 = "select sum(total) as total from (select count(distinct(DayOfMonth)) as total FROM [Attendance]  where  CAST(cast(Attendance.[DayOfMonth] as varchar) + Attendance.[Month] +  cast(Attendance.[Year] as varchar) AS date) >= (select cast(enrollDate as date) from [User] where id = @id)  Group by month, year ) T1 ";

//String sql2 = "SELECT count(distinct([DayOfMonth])) as totalAtt FROM[Attendance] where[ID] = @id and STATUS = 'Full Day' OR STATUS = 'Half Day' GROUP BY  MONTH, YEAR";
//String sql2 = "SELECT count(distinct([DayOfMonth])) as totalAtt FROM[Attendance] where[ID] = @id and STATUS = 'Full Day' GROUP BY  MONTH, YEAR";
String sql2 = "select sum (total) as fullday from (SELECT count(distinct([DayOfMonth])) as total FROM [Attendance] where[ID] = @id and STATUS = 'Full Day' GROUP BY  [Month], [Year]) T1";
                String sql3 = "select sum (total) as halfday from (SELECT count(distinct([DayOfMonth])) as total FROM [Attendance] where[ID] = @id and STATUS = 'Half Day' GROUP BY  [Month], [Year]) T1";
                //String sql3 = "SELECT count(distinct([DayOfMonth])) as totalAtt FROM[Attendance] where[ID] = @id and STATUS = 'Half Day' GROUP BY  MONTH, YEAR";

                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlCommand cmd2 = new SqlCommand(sql2, con2);
                SqlCommand cmd3 = new SqlCommand(sql3, con3);

                cmd1.Parameters.AddWithValue("@id", id);
                cmd2.Parameters.AddWithValue("@id", id);
                cmd3.Parameters.AddWithValue("@id", id);

                SqlDataReader dr1 = cmd1.ExecuteReader();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                SqlDataReader dr3 = cmd3.ExecuteReader();

                if (dr1.HasRows)
                {
                    if(dr2.HasRows)
                    {
                        double total = 0, fullday = 0; 
                        double halfDay = 0;
                        while(dr1.Read())
                        {
                            if(dr1["total"]!= DBNull.Value)
                            total = int.Parse(dr1["total"].ToString());
                        }
                        while (dr2.Read())
                        {
                            if(dr2["fullday"]!= DBNull.Value)
                                fullday = int.Parse(dr2["fullday"].ToString());
                        }


                        //MessageBox.Show(total + " " + fullday);

                        if (dr3.HasRows)
                        {
                            while (dr3.Read())
                            {
                                if (dr3[0]!= DBNull.Value)
                                    halfDay = int.Parse(dr3["halfday"].ToString());
                                
                            }
                        }
                        //MessageBox.Show(halfDay + "'");
                            


                        double myTotal = fullday + (halfDay * 0.5);
                        //MessageBox.Show("My total = " + myTotal);

                        double percentage = (myTotal / total) * 100;
                        label1.Text = "Attendance Percentage : " + String.Format("{0:0.##}", percentage) + "%";
                        label2.Text = "Total No. of Working Days = " + total + "\nNo. Of Days Attended = " + myTotal + "\nNo. of Days Absent = " + (total - myTotal);


                    }
                    else
                    {
                        MessageBox.Show("No Present Records!");
                    }
                }
                else
                {
                    MessageBox.Show("No Attendance Record found for User ID: " + id);
                }

                dr1.Close();
                dr2.Close();
                    
        
                con.Close();
                con2.Close();
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Unfortunately Stopped! Something Happened." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }


        }
    }
}
