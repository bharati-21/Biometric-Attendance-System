using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorporateCoders
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.Run(new Form1());

            updateAttendance();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            

            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());//Time when "Absent" records needs to be inserted*/
            

        }

        static void updateAttendance()
        {
            var DailyTime = "09:52:00";
            var timeParts = DailyTime.Split(new char[1] { ':' });

            var thread = new Thread(() =>
            {
                while (true)
                {
                    var dateNow = DateTime.Now;

                    var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day,
                    int.Parse(timeParts[0]), int.Parse(timeParts[1]), int.Parse(timeParts[2]));
                    TimeSpan ts;
                    if (date > dateNow)
                        ts = date - dateNow;
                    else
                    {
                        date = date.AddDays(1);
                        ts = date - dateNow;
                    }

                    //waits certan time and run the code
                    Task.Delay(ts).Wait();
                    SomeMethod();

                }
            });
            thread.Start();
             
        }

        static void SomeMethod()
        {
            Console.WriteLine("Helloo");
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");

                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\TaskSchedulerDemo\TaskSchedulerDemo\Database1.mdf;Integrated Security=True");
                con.Open();
                String query = "select Id, Name from [User]";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        String currId = dr["Id"].ToString().Trim();
                        String currName = dr["Name"].ToString().Trim();
                        Console.Write(currId + " " + currName + " ");
                        bool inserted = insertIntoAttendance(currId, currName);

                        if (inserted == true)
                        {
                            Console.WriteLine("Inserted");
                            // MessageBox.Show("inserted " + currId + "  " +  currName);
                        }
                        else
                        {
                            Console.WriteLine("Not Inserted");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("No User records found");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message);
            }

        }
        static bool insertIntoAttendance(String currId, String currName)
        {
            SqlConnection con2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");

            //SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\TaskSchedulerDemo\TaskSchedulerDemo\Database1.mdf;Integrated Security=True");
            con2.Open();
            String query = "select Id from [Attendance] where DayOfMonth=@date and Month = @month and Year = @year";
            SqlCommand cmd = new SqlCommand(query, con2);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.Day);
            cmd.Parameters.AddWithValue("@month", DateAndTime.MonthName(DateTime.Now.Month));
            
            cmd.Parameters.AddWithValue("@year", DateTime.Now.Year);
            SqlDataReader dr = cmd.ExecuteReader();
            bool found = false;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr["Id"].ToString().Trim().Equals(currId) == true)
                    {

                        found = true;
                        break;
                    }
                }

            }

            if (found == true)
            {
                con2.Close();
                dr.Close();
                return false;

            }
            con2.Close();
            dr.Close();

            SqlConnection con3 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");

//            SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\TaskSchedulerDemo\TaskSchedulerDemo\Database1.mdf;Integrated Security=True");
            con3.Open();
            String query2 = "insert into [Attendance] (Id, Name, DayOfMonth, Month, Year, VerTime, Status) values(@id, @name, @date, @month, @year, @time, @status)";
            SqlCommand cmd2 = new SqlCommand(query2, con3);
            cmd2.Parameters.AddWithValue("@id", currId);
            cmd2.Parameters.AddWithValue("@name", currName);

            
             cmd2.Parameters.AddWithValue("@date", DateTime.Now.Day);
             cmd2.Parameters.AddWithValue("@month", DateAndTime.MonthName(DateTime.Now.Month));
             

           
            cmd2.Parameters.AddWithValue("@year", DateTime.Now.Year);
            cmd2.Parameters.AddWithValue("@time", "NA");
            cmd2.Parameters.AddWithValue("@status", "Absent");
            if (cmd2.ExecuteNonQuery() > 0)
            {
                con2.Close();
                return true;

            }
            con2.Close();
            return false;
        }
    }
}
