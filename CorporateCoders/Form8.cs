using Microsoft.VisualBasic;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        Form10 f10 = null;
        Form2 f2 = null;
        public Form8(Form10 form10, Form2 form2)
        {
            f10 = form10 as Form10;
            f2 = form2 as Form2;
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;

            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            panel1.Height = this.Height;

        }

        private void TxtUid_Validated(object sender, EventArgs e)
        {
            errorProviderUId.SetError(txtUid, "");

        }

        public bool ValidUserId(string emailAddress, out string errorMessage)
        {
            foreach (char c in emailAddress)
            {
                if (c < '0' || c > '9')
                {
                    errorMessage = "Invalid User ID!\nCan contain only numbers";
                    return false;
                }
            }
            errorMessage = "";
            return true;
        }
        private void TxtUid_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidUserId(txtUid.Text, out errorMsg))
            {
                e.Cancel = true;
                txtUid.Select(0, txtUid.Text.Length);
                this.errorProviderUId.SetError(txtUid, errorMsg);
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidName(txtName.Text, out errorMsg))
            {
                e.Cancel = true;
                txtName.Select(0, txtName.Text.Length);
                this.errorProviderName.SetError(txtName, errorMsg);
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        public bool ValidName(String name, out string errorMessage)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    errorMessage = "Invalid Name.\nCan contain only letters";
                    return false;
                }
            }
            errorMessage = "";
            return true;
        }
        private void TxtName_Validated(object sender, EventArgs e)
        {
            errorProviderName.SetError(txtName, "");
        }


        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            f10.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            f10.Close();
            f2.Show();
        }

        String month, name, id, status;
        int year, date;
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(cmbChange.SelectedItem==null)
            {
                MessageBox.Show("You must select a status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if(txtCurrStatus.Text.Trim().Equals(cmbChange.SelectedItem.ToString().Trim()))
            {
                MessageBox.Show("The current and new status are the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                DialogResult res =  MessageBox.Show("Do you want to change the status to " + cmbChange.SelectedItem.ToString(), "Confirmation", MessageBoxButtons.YesNo,   MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if(res==DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("update [Attendance] set Status = @status where id = @id and name = @name COLLATE SQL_Latin1_General_CP1_CS_AS and Month = @month and DayOfMonth = @date and Year = @year", con);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@status", cmbChange.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@year", year);
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Successfully changed the status", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        txtName.ReadOnly = false;
                        txtUid.ReadOnly = false;
                        dateTimePicker1.Enabled = true;
                        label1.Visible = false;
                        label2.Visible = false;
                        txtCurrStatus.Visible = false;
                        txtCurrStatus.Text = status;
                        cmbChange.Visible = false;
                        btnUpdate.Visible = false;
                        txtName.Clear();
                        txtUid.Clear();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE UPDATING.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    MessageBox.Show("Status not changed", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    txtName.ReadOnly = false;
                    txtUid.ReadOnly = false;
                    dateTimePicker1.Enabled = true;
                    label1.Visible = false;
                    label2.Visible = false;
                    txtCurrStatus.Visible = false;
                    txtCurrStatus.Text = status;
                    cmbChange.Visible = false;
                    btnUpdate.Visible = false;
                    txtName.Clear();
                    txtUid.Clear();
                }
            }
        }

        
        private void BtnChoose_Click(object sender, EventArgs e)
        {
            if (txtUid.Text == "")
            {
                MessageBox.Show("User ID cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Username cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if(dateTimePicker1.Value==null)
            {
                MessageBox.Show("Please select a date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select *from [User] where id = @id and name = @name COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.ToString());
                    cmd.Parameters.AddWithValue("@id", txtUid.Text.ToString());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        name = txtName.Text;
                        id = txtUid.Text;
                        con.Close();
                        month = Microsoft.VisualBasic.DateAndTime.MonthName(dateTimePicker1.Value.Month);
                        date = dateTimePicker1.Value.Day;
                        
                        year = dateTimePicker1.Value.Year;
                        MessageBox.Show(date + " " + month + " " + year);
                        //If there exists this user then check for the selected date in the attendance if exists.
                        SqlConnection con2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                        con2.Open();
                        SqlCommand cmd2 = new SqlCommand("select *from [Attendance] where id = @id and name = @name COLLATE SQL_Latin1_General_CP1_CS_AS and Month = @month and DayOfMonth = @date and Year = @year", con2);
                        cmd2.Parameters.AddWithValue("@name", name);
                        cmd2.Parameters.AddWithValue("@id", id);
                        cmd2.Parameters.AddWithValue("@date", date);
                        cmd2.Parameters.AddWithValue("@year", year);
                        cmd2.Parameters.AddWithValue("@month", month);
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        if (dr2.HasRows)
                        {
                            while (dr2.Read())
                            {
                                status = dr2["Status"].ToString();
                            }

                            //MessageBox.Show("The status of " + txtName.Text + " attendance on " + date +" " + month + " " +year+ " is " + status );
                            txtName.ReadOnly = true;
                            txtUid.ReadOnly = true;
                            dateTimePicker1.Enabled = false;
                            label1.Visible = true;
                            label2.Visible = true;
                            txtCurrStatus.Visible = true;
                            txtCurrStatus.Text = status;
                            cmbChange.Visible = true;
                            btnUpdate.Visible = true;
                            cmbChange.Items.Clear();
                            cmbChange.Items.Add("Half Day");
                            cmbChange.Items.Add("Full Day");
                            cmbChange.Items.Add("Absent");
                        }
                        else
                        {
                            MessageBox.Show("Invalid date! There is no attendance record for the day", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            txtName.Clear();
                            txtUid.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Uder ID, Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        txtName.Clear();
                        txtUid.Clear();
                    }
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE LOADING DATA.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }
    }
}
