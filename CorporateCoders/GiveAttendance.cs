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
    public partial class GiveAttendance : Form
    {
        public GiveAttendance()
        {
            InitializeComponent();
            serialPort1.BaudRate = 9600;

            serialPort1.PortName = "COM3";
            serialPort1.Open();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("2");
        }

        private void GiveAttendance_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            DateTime t = DateTime.Now;
            string sqlFormattedDate = t.ToString("yyyy-MM-dd HH:mm:ss.fff");
            String msg = serialPort1.ReadLine();
            
            int id = -1;

            if (msg.Contains("Verified"))
            {
                int day = t.Day;
                String month = Microsoft.VisualBasic.DateAndTime.MonthName(t.Month);
                int year = t.Year;
                String name = "";
                String hours = t.Hour.ToString();
                String min = t.Minute.ToString();
                String sec = t.Second.ToString();

                int i = int.Parse(msg.Substring(14)) + 100;
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                    con.Open();
                    String sql = "select name from [User] where id = @id";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", i);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        name = r["name"].ToString();
                    }
                    cmd.Dispose();
                    r.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }

                String att = EnterAttendance(i, name, day, month, year, hours, min, sec);
                if(att.Contains("NA"))
                {
                    MessageBox.Show("YOUR ATTENDANCE HAS ALREADY BEEN MARKED FOR THE DAY\nSTATUS " + att.Substring(2), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                { 
                    MessageBox.Show("YOUR ATTENDANCE HAS BEEN MARKED FOR THE DAY\nSTATUS " + att, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }

            }
            else if(msg.Contains("not found"))
            {
                MessageBox.Show("Sorry, Finger print could not be processed. Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private String  EnterAttendance(int id, String name, int day, String month, int year, String hours, String min, String sec)
        {
            String status="";
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                con.Open();
                String sql = "select [Status] from [Attendance] where Id = @id and DayOfMonth = @date and Month = @month and Year = @year";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", day);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    String st = r["Status"].ToString().Trim();
                    cmd.Dispose();
                    r.Close();
                    con.Close();
                    return "NA" + st;

                }
                cmd.Dispose();
                r.Close();
                con.Close();

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                conn.Open();
                sql = "insert into [Attendance] (Id, Name, DayOfMonth, Month, Year, VerTime, Status) values (@id, @name, @date, @month, @year, @time, @status)";
                SqlCommand command = new SqlCommand(sql, conn);
                status = "P";
                if (int.Parse(hours) >= 15)
                {
                    status = "Absent";
                }
                else if (int.Parse(hours) >= 12 && int.Parse(hours) < 15)
                {
                    status = "Half Day";
                }
                else
                {
                    status = "Full Day";
                }
                String time = hours + ":" + min + ":" + sec;
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@date", day);
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@status", status);
                int x = command.ExecuteNonQuery();
                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            return status;
        }
    }
}
