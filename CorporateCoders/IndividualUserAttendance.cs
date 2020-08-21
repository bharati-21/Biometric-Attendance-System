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
    public partial class IndividualUserAttendance : Form
    {
        public IndividualUserAttendance()
        {
            InitializeComponent();
        }

        Form10 f10 = null;
        Form2 f2 = null;
        ViewAttendance userAttendance = null;
        public IndividualUserAttendance(Form10 form10, Form2 form2, ViewAttendance ff)
        {
            InitializeComponent();
            f10 = form10 as Form10;
            f2 = form2 as Form2;
            userAttendance = ff as ViewAttendance;

        }

        private void TxtUid_Validated(object sender, EventArgs e)
        {
            errorProviderUId.SetError(txtUid, "");

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

        public bool ValidUserId(string userID, out string errorMessage)
        {
            foreach (char c in userID)
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

        private void TxtName_Validated(object sender, EventArgs e)
        {
            errorProviderName.SetError(txtName, "");
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
        public String name, id;
        public bool ValidName(String nameIp, out string errorMessage)
        {
            foreach (char c in nameIp)
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            userAttendance.Close();
            f10.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            userAttendance.Close();
            f10.Close();
            f2.Show();
        }

        private void IndividualUserAttendance_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            panel1.Height = this.Height;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            if(txtUid.Text.Equals(""))
            {
                MessageBox.Show("User ID cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if(txtName.Text.Equals(""))
            {
                MessageBox.Show("User Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                name = txtName.Text;
                id = txtUid.Text;
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
                        Form15 f15 = new Form15(this);
                        f15.Show();
                        txtName.Clear();
                        txtUid.Clear();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User ID or name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }

            
        }
    }
}
