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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        Form14 f14 = null;
        public Form17(Form14 f)
        {
            f14 = f as Form14;
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form17_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            txtChngAtt.Visible = false;
            cmbChangeReqStatus.Items.Add("Deny Request");
            cmbChangeReqStatus.Items.Add("Approve Request");
            txtChngAtt.Text = "Full Day";
            lblChngAtt.Visible = false;
            txtName.Text = f14.nameReq;
            txtUid.Text = f14.id;
            txtDate.Text = f14.date + " " + f14.month + " " + f14.year;
            txtArrival.Text = f14.time;
            txtReason.Text = f14.reason;
            txtCurrAttStatus.Text= f14.statusAtt.Trim();
            txturrReqStatus.Text = f14.status;
            /*if(f14.statusAtt=="")
            {
                txtCurrAttStatus.Text = "Invalid Date " + txtDate.Text + " No attendance record found! This request will be deleted and you will get back another request!";
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                    con.Open();
                    String sql = "delete from [dbo].[reqTable] where [Id] = @id and [Month]= @month and [Year] = @year and [DayOfMonth] = @date";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.Parameters.AddWithValue("@id", f14.id);
                    com.Parameters.AddWithValue("@month", Microsoft.VisualBasic.DateAndTime.MonthName(DateTime.Now.Month));
                    com.Parameters.AddWithValue("@year", DateTime.Now.Year);
                    com.Parameters.AddWithValue("@date", f14.date);
                    com.ExecuteNonQuery();
                    con.Close();


                    SqlConnection con2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                    con2.Open();
                    //Query to retrieve the requests Left
                    String sql2 = "update [dbo].[reqTable] set [requestLeft] = @req where [Id] = @id and [Month]= @month and [Year] = @year";
                    SqlCommand com2 = new SqlCommand(sql2, con2);
                    com2.Parameters.AddWithValue("@id", f14.id);
                    com2.Parameters.AddWithValue("@month", Microsoft.VisualBasic.DateAndTime.MonthName(DateTime.Now.Month));
                    com2.Parameters.AddWithValue("@year", DateTime.Now.Year);
                    com2.Parameters.AddWithValue("@req", (int.Parse(f14.reqLeft)+1));
                    com2.ExecuteNonQuery();
                    con2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "\nUNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN");
                }
                
                cmbChangeReqStatus.Visible = false;
                cmbChangeAttStatus.Visible = false;
                lblChngAtt.Visible = false;
                lblChange.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                this.Close();
            }
            else if(f14.statusAtt.Trim().Equals("Absent"))
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                    con.Open();

                    String sql = "update [dbo].[reqTable] set [Status] = @status where [Id] = @id and [Month]= @month and [Year] = @year and [DayOfMonth] = @date";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.Parameters.AddWithValue("@id", f14.id);
                    com.Parameters.AddWithValue("@month", Microsoft.VisualBasic.DateAndTime.MonthName(DateTime.Now.Month));
                    com.Parameters.AddWithValue("@year", DateTime.Now.Year);
                    com.Parameters.AddWithValue("@date", f14.date);
                    com.Parameters.AddWithValue("@status", "Denied");
                    com.ExecuteNonQuery();
                    con.Close();
                    f14.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "\nUNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN");
                }
                MessageBox.Show("Your request's arrival time and attendance verified time don't match.\nYou arrived at " + f14.attTime + " (after 14:00 Hours)\nHence this request will be denied");
            }*/

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbChangeReqStatus.SelectedItem == null)
            {
                MessageBox.Show("You have not selected the new Request status", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
           
            else
            {
                try
                {
                    if (cmbChangeReqStatus.SelectedItem.ToString().Trim().Equals("Deny Request"))
                    {
                        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                        con.Open();

                        String sql = "update [dbo].[reqtable] set [Status] = @status where [Id] = @id and [Month]= @month and [Year] = @year and [DayOfMonth] = @date";
                        SqlCommand com = new SqlCommand(sql, con);
                        com.Parameters.AddWithValue("@id", f14.id);
                        com.Parameters.AddWithValue("@month", Microsoft.VisualBasic.DateAndTime.MonthName(DateTime.Now.Month));
                        com.Parameters.AddWithValue("@year", DateTime.Now.Year);
                        com.Parameters.AddWithValue("@date", f14.date);
                        com.Parameters.AddWithValue("@status", "Denied");
                        com.ExecuteNonQuery();
                        con.Close();
                        f14.Close();
                        Form14 form14 = new Form14();
                        form14.Show();
                        this.Close();
                        MessageBox.Show("SAVED SUCCESSFULLY", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                    else if (cmbChangeReqStatus.SelectedItem.Equals("Approve Request"))
                    {
                        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                        con.Open();

                        //Query to retrieve the requests Left
                        String sql = "update [dbo].[reqTable] set [Status] = @status where [Id] = @id and [Month]= @month and [Year] = @year and [DayOfMonth] = @date";
                        SqlCommand com = new SqlCommand(sql, con);
                        com.Parameters.AddWithValue("@id", f14.id);
                        com.Parameters.AddWithValue("@month", Microsoft.VisualBasic.DateAndTime.MonthName(DateTime.Now.Month));
                        com.Parameters.AddWithValue("@year", DateTime.Now.Year);
                        com.Parameters.AddWithValue("@date", f14.date);
                        com.Parameters.AddWithValue("@status", "Approved");
                        com.ExecuteNonQuery();
                        con.Close();


                        SqlConnection con2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                        con2.Open();

                        //Query to retrieve the requests Left
                        String sql2 = "update [dbo].[Attendance] set [Status] = @status where [Id] = @id and [Month]= @month and [Year] = @year and [DayOfMonth] = @date";
                        SqlCommand com2 = new SqlCommand(sql2, con2);
                        com2.Parameters.AddWithValue("@id", f14.id);
                        com2.Parameters.AddWithValue("@month", Microsoft.VisualBasic.DateAndTime.MonthName(DateTime.Now.Month));
                        com2.Parameters.AddWithValue("@year", DateTime.Now.Year);
                        com2.Parameters.AddWithValue("@date", f14.date);

                        com2.Parameters.AddWithValue("@status", "Full Day");
                        com2.ExecuteNonQuery();
                        con2.Close();
                        this.Close();
                        f14.Close();
                        Form14 form14 = new Form14();
                        form14.Show();
                        MessageBox.Show("SAVED SUCCESSFULLY", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "\nUNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    this.Close();
                    f14.Show();
                }
            }
        }

        private void CmbChangeReqStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbChangeReqStatus.SelectedItem.ToString().Trim().Equals("Approve Request"))
            {
                MessageBox.Show("If you approve the request then the attendance status will change to FULL DAY");
                DialogResult res = MessageBox.Show("Are you sure you want to approve the request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
               if(res == DialogResult.Yes)
                {
                    txtChngAtt.Visible = true;
                    lblChngAtt.Visible = true;
                }
               else
                {
                    txtChngAtt.Visible = false;
                    lblChngAtt.Visible = false;
                }
            }
            else if(cmbChangeReqStatus.SelectedItem.ToString().Trim().Equals("Deny Request"))
            {
                MessageBox.Show("If this request is denied the attendance status will not change and will remain " + txtCurrAttStatus.Text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                txtChngAtt.Visible = false;
                lblChngAtt.Visible = false;
            }
           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            f14.Show();
            f14.Refresh();
        }
    }
}
