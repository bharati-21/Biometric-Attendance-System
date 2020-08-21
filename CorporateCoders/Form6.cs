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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        //To access home page and login page
        Form3 form3 = null;
        Form4 form4 = null;

        public Form6(Form4 f4, Form3 f3)
        {
            InitializeComponent();
            form4 = f4 as Form4;
            form3 = f3 as Form3;
        }


        public string id, name, psd;
        public int reqLeft = 2;
        string time = "";


        //button home page
        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            form4.Show();
        }

        //button logout
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            form4.Close();
            form3.Show();
        }

        //button to show all requests
        private void BtnCheckRequests_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(form4, form3);
            this.Close();
            f7.Show();
        }

        
        private void DtpDate_Leave(object sender, EventArgs e)
        {

            int hours, mins;
            DateTime d = dtpDate.Value;
            DateTime x = new DateTime(d.Year, d.Month, d.Day);
            // The Date for which user requests CL.

            int mon = d.Month;
            int year = d.Year;
            int date = d.Day;
            String month = "January";
            if (mon == 1)
            {
                month = "January";
            }
            else if (mon == 2)
            {
                month = "February";
            }
            else if (mon == 3)
            {
                month = "March";
            }
            else if (mon == 4)
            {
                month = "April";
            }
            else if (mon == 5)
            {
                month = "May";
            }
            else if (mon == 6)
            {
                month = "June";
            }
            else if (mon == 7)
            {
                month = "July";
            }
            else if (mon == 8)
            {
                month = "August";
            }
            else if (mon == 9)
            {
                month = "September";
            }
            else if (mon == 10)
            {
                month = "October";
            }
            else if (mon == 11)
            {
                month = "November";
            }
            else
            {
                month = "December";
            }


            /***********************************************************************************/

            try
            {
                //Select time of the user's attendance on that day
                SqlConnection con4 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                con4.Open();

                String sql = "select [VerTime] from [dbo].[Attendance] where [Id] = @id and [Month]= @month and [year] = @year and [dayOfMonth] = @date";
                SqlCommand com3 = new SqlCommand(sql, con4);
                com3.Parameters.AddWithValue("@id", id);
                com3.Parameters.AddWithValue("@month", month);
                com3.Parameters.AddWithValue("@year", year);
                com3.Parameters.AddWithValue("@date", date);
                SqlDataReader dr3 = com3.ExecuteReader();

                //In case there is an attendance record for the date, then check the time. If user time is >=12 && <15 or
                // time is >=15
                if (dr3.Read())
                {

                    time = dr3["VerTime"].ToString().Trim();
                    if (time.Equals("NA"))
                    {
                        MessageBox.Show("YOU WERE MARKED ABSENT ON THE SELECTED DAY! CANNOY REQUEST!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        this.Close();
                        form4.Show();
                    }
                    /*String[] spearator = { ":" };
                    
                    String[] timeList = time.Split(spearator, 3, StringSplitOptions.RemoveEmptyEntries);
                    hours = int.Parse(timeList[0]);
                    mins = int.Parse(timeList[1]);
                    */
                    else
                    {
                        txtTime.Text = time;
                        addTime();
                    }
                }
                //In case no attendance records found for the day then, don't let user request
                else
                {
                    MessageBox.Show("INVALID DATE!\nNo attendance record found on " + d.Day + " " + month + " " + d.Year, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    

                }
                con4.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nAN UNEXPECTED ERROR OCCURED WHILE PROCESSING YOUR REQUEST.", "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }


        }
            /*********************************************************************/

        void addTime()
        {
            DateTime d = dtpDate.Value;
            DateTime x = new DateTime(d.Year, d.Month, d.Day);
            // The Date for which user requests CL.

            int mon = d.Month;
            int year = d.Year;
            int date = d.Day;
            String month = "January";
            if (mon == 1)
            {
                month = "January";
            }
            else if (mon == 2)
            {
                month = "February";
            }
            else if (mon == 3)
            {
                month = "March";
            }
            else if (mon == 4)
            {
                month = "April";
            }
            else if (mon == 5)
            {
                month = "May";
            }
            else if (mon == 6)
            {
                month = "June";
            }
            else if (mon == 7)
            {
                month = "July";
            }
            else if (mon == 8)
            {
                month = "August";
            }
            else if (mon == 9)
            {
                month = "September";
            }
            else if (mon == 10)
            {
                month = "October";
            }
            else if (mon == 11)
            {
                month = "November";
            }
            else
            {
                month = "December";
            }
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                con.Open();

                int req=2;

                String sql = "select top 1 [requestLeft] from [reqTable] where [id] = @id  and [Month]= @month and [Year] = @year";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@month", month);
                com.Parameters.AddWithValue("@year", year);
                SqlDataReader dr = com.ExecuteReader();

               
                if (dr.Read())
                {
                    req = int.Parse(dr["requestLeft"].ToString());
                }
                //MessageBox.Show(req.ToString());

                if (req == 0)
                {
                    btnSave.Enabled = false;
                    dtpDate.Enabled = false;
                    txtReason.ReadOnly = true;
                    MessageBox.Show("You have 0 CL requests for this month. You cannot request anymore for the current month.", "Infomration", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                }
                //MessageBox.Show(req + " " + month + " " + year + name);
                lblCL.Text = "Number of CL Requests left for " + month + ": " + req;
                con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

        }


        //Form Load
        private void Form6_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            dtpDate.MaxDate = DateTime.Now;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            lblNote.Text = "NOTE : You can only request twice for any month.\nYour requst will be reviewd and you can see the status in the YOUR REQUESTS tab";
            //Save name, psd, id and print in respective labels.
            name = form4.name;
            psd = form4.psd;
            id = form4.id;
            lblHead.Text = "Welcome " + name;
            txtUid.Text = id;
            txtName.Text = name;

            

            try
            {
                //Sql connection open
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                con.Open();

                DateTime d = dtpDate.Value;
                DateTime x = new DateTime(d.Year, d.Month, d.Day);
                int date = d.Day;
                int mon = d.Month;
                int year = d.Year;

                String month = "January";
                if (mon == 1)
                {
                    month = "January";
                }
                else if (mon == 2)
                {
                    month = "February";
                }
                else if (mon == 3)
                {
                    month = "March";
                }
                else if (mon == 4)
                {
                    month = "April";
                }
                else if (mon == 5)
                {
                    month = "May";
                }
                else if (mon == 6)
                {
                    month = "June";
                }
                else if (mon == 7)
                {
                    month = "July";
                }
                else if (mon == 8)
                {
                    month = "August";
                }
                else if (mon == 9)
                {
                    month = "September";
                }
                else if (mon == 10)
                {
                    month = "October";
                }
                else if (mon == 11)
                {
                    month = "November";
                }
                else
                {
                    month = "December";
                }

                //Query to retrieve the requests Left
                String sql = "select top 1 [requestLeft] from [dbo].[reqTable] where [Name] = @name and [Id] = @id and [Month]= @month and [year] = @year";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@month", month);
                com.Parameters.AddWithValue("@year", year);
                SqlDataReader dr = com.ExecuteReader();
                //In case there is a row with Id, Name for current month and year : store it in reqLeft
                if (dr.Read())
                {
                    reqLeft = int.Parse(dr["requestLeft"].ToString());
                }
               
                lblCL.Text = lblCL.Text + " " + month +" "  + reqLeft;
                con.Close();
                dr.Close();
                com.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DateTime d = dtpDate.Value;
            DateTime x = new DateTime(d.Year, d.Month, d.Day);
            int date = d.Day;
            int mon = d.Month;
            int year = d.Year;

            String month = "January";
            if (mon == 1)
            {
                month = "January";
            }
            else if (mon == 2)
            {
                month = "February";
            }
            else if (mon == 3)
            {
                month = "March";
            }
            else if (mon == 4)
            {
                month = "April";
            }
            else if (mon == 5)
            {
                month = "May";
            }
            else if (mon == 6)
            {
                month = "June";
            }
            else if (mon == 7)
            {
                month = "July";
            }
            else if (mon == 8)
            {
                month = "August";
            }
            else if (mon == 9)
            {
                month = "September";
            }
            else if (mon == 10)
            {
                month = "October";
            }
            else if (mon == 11)
            {
                month = "November";
            }
            else
            {
                month = "December";
            }
            String[] spearator = { ":" };


            //time = 16:25:40
            //timelist = [16, 25, 40]
            //timelist[0] == hours
            //timelst[1] = mins
            // timelist[2] = sec
            String[] timeList = time.Split(spearator, 3, StringSplitOptions.RemoveEmptyEntries);
            int hours = int.Parse(timeList[0]);
            int mins = int.Parse(timeList[1]);
            if (txtReason.Text.Equals("") == true)
             {
                MessageBox.Show("Reason for late arrrival cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
             }
            else if(dtpDate.Value.Year!= DateTime.Today.Year )// dtpDate.Value.Month!=DateTime.Now.Month)
            {
                MessageBox.Show("You can only make requests for the current year", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                
                /*else
                {
                    MessageBox.Show("You can only make requests for the current month");
                }*/
            }

            else if(hours >=15)
            {
                MessageBox.Show("You can only request if your arrival time is before 15:00 hours", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

            //If user has filled all the data then proceed.
            else
            {
                //Get values for reason, minutes, hours and date of request
                String reason = txtReason.Text.Trim();
                
                try
                {
                    //Select status of the user's attendance on that day
                    SqlConnection con3 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                    con3.Open();

                    String check3 = "select [status] from [dbo].[Attendance] where [Id] = @id and [Month]= @month and [year] = @year and [dayOfMonth] = @date";
                    SqlCommand com3 = new SqlCommand(check3, con3);
                    com3.Parameters.AddWithValue("@id", id);
                    com3.Parameters.AddWithValue("@month", month);
                    com3.Parameters.AddWithValue("@year", year);
                    com3.Parameters.AddWithValue("@date", date);
                    SqlDataReader dr3 = com3.ExecuteReader();
                    //In case there is an attendance record for the day then check if absent or full day
                    if (dr3.Read())
                    {
                        //If record says absent, Don't let user give the request
                        if(dr3["status"].ToString().Trim().Equals("Absent"))
                        {
                            MessageBox.Show("You cannot request for a day you were marked ABSENT", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            con3.Close();

                        }
                        //If record says full day then why request?
                        else if(dr3["status"].ToString().Trim().Equals("Full Day"))
                        {
                            MessageBox.Show("You have already been marked Full Day for the date " + d.Day + " " + month + " " + d.Year, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            con3.Close();
                        }
                        //if record says otherwise (HALF DAY)
                        else
                        {
                            con3.Close();
                            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                            con.Open();

                            //Check if user has already requested for the particular date. If yes, then ask user to change date
                            String check = "select [dayOfMonth] from [dbo].[reqTable] where [Name] = @name and [Id] = @id and [Month]= @month and [year] = @year and [dayOfMonth] = @date";
                            SqlCommand com = new SqlCommand(check, con);
                            com.Parameters.AddWithValue("@id", id);
                            com.Parameters.AddWithValue("@name", name);
                            com.Parameters.AddWithValue("@month", month);
                            com.Parameters.AddWithValue("@year", d.Year);
                            com.Parameters.AddWithValue("@date", d.Day);
                            SqlDataReader dr = com.ExecuteReader();

                            if (dr.Read())
                            {
                                MessageBox.Show("You have already requested for the above date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                com.Dispose();
                                dr.Close();
                                con.Close();
                            }

                            //If user hasn't requested for the date, then proceed with insertion
                            else
                            {
                                con.Close();
                                SqlConnection con1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                                con1.Open();
                                //Query to insert all the values
                                String insQuery = "INSERT INTO [reqTable]([Id], [Name], [dayOfMonth], [Month], [Year], [ReqTime], [Reason], [Status], [requestLeft]) values(@id, @name, @date, @month, @year, @time, @reason, @status, @reqLeft)";
                                SqlCommand command = new SqlCommand(insQuery, con1);
                                command.Parameters.AddWithValue("@id", id);
                                command.Parameters.AddWithValue("@name", name);
                                command.Parameters.AddWithValue("@date", d.Day);
                                command.Parameters.AddWithValue("@month", month);
                                command.Parameters.AddWithValue("@year", d.Year);
                                command.Parameters.AddWithValue("@time", hours + ":" + mins);
                                command.Parameters.AddWithValue("@reason", reason);
                                command.Parameters.AddWithValue("@status", "Pending Request");
                                command.Parameters.AddWithValue("@reqLeft", (reqLeft - 1));
                                command.ExecuteNonQuery();
                                command.Dispose();
                                con1.Close();

                                SqlConnection con2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                                con2.Open();

                                //Query to update all the requests of the current month, year, name and Id.
                                String sql2 = "update [dbo].[reqTable] set [requestLeft] = @reqLeft where [Name] = @name and [Id] =@id and [Month]=@month and [year] = @year";
                                SqlCommand cmd2 = new SqlCommand(sql2, con2);
                                cmd2.Parameters.AddWithValue("@id", id);
                                cmd2.Parameters.AddWithValue("@name", name);
                                cmd2.Parameters.AddWithValue("@month", month);
                                cmd2.Parameters.AddWithValue("@year", d.Year);
                                cmd2.Parameters.AddWithValue("@reqLeft", (reqLeft - 1));
                                cmd2.ExecuteNonQuery();
                                cmd2.Dispose();
                                con2.Close();
                                Form7 f7 = new Form7(form4, form3);
                                this.Close();
                                f7.Show();
                            }
                        }
                    }
                    //In case no attendance records found for the day then, don't let user request
                    else
                    {
                        MessageBox.Show("INVALID DATE!\nNo attendance record found on " + d.Day + " " + month + " " + d.Year, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        btnSave.Enabled = false;
                        //cmbHrs.Enabled = false;
                        //cmbMins.Enabled = false;
                        dtpDate.Enabled = false;
                        txtReason.ReadOnly = true;

                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UNFORTUNATELY STOPPED!\nAN UNEXPECTED ERROR OCCURED WHILE PROCESSING YOUR REQUEST.\n" + ex, "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }

            }
                

        }
        
    }
}
