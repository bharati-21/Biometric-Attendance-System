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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

       
        Form11 f11 = null;

        public Form12(Form11 form11)
        {
            f11 = form11 as Form11;
            
            InitializeComponent();
        }

        public String  uid;
       
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string email = "";
            string psd = "";
            string name = "";
            long ph = 0;
            string dept = "";
            try
            {

                email = txtEmail.Text.Trim();
                ph = long.Parse(txtPhone.Text.Trim());
                dept = cmbDept.SelectedItem.ToString().Trim();
                psd = txtPsd.Text.ToString().Trim();
                name = txtName.Text.ToString().Trim();

            }
            catch (Exception ex)
            {
                ;
            }

            DateTime dob = dtpDob.Value;
            dob.ToString("yyyy-MM-dd");
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                con.Open();
                if (name.Equals("") == false)
                {
                    SqlCommand cmd = new SqlCommand("update [User] set name=@name where Id=@id", con);
                    SqlCommand cmd1 = new SqlCommand("update [Attendance] set name=@name where Id=@id", con);
                    SqlCommand cmd2 = new SqlCommand("update [reqTable] set name=@name where Id=@id", con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@id", uid);

                    cmd1.Parameters.AddWithValue("@name", name);
                    cmd1.Parameters.AddWithValue("@id", uid);

                    cmd2.Parameters.AddWithValue("@name", name);
                    cmd2.Parameters.AddWithValue("@id", uid);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd.Dispose();

                }
                if (psd.Equals("") == false)
                {
                    SqlCommand cmd = new SqlCommand("update [User] set psd=@psd where Id=@id", con);
                    cmd.Parameters.AddWithValue("@psd", psd);
                    cmd.Parameters.AddWithValue("@id", uid);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                if (email.Equals("") == false)
                {
                    SqlCommand cmd = new SqlCommand("update [User] set email=@email where Id=@id", con);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@id", uid);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                if (ph != 0)
                {
                    SqlCommand cmd = new SqlCommand("update [User] set phone=@phone where Id=@id", con);
                    cmd.Parameters.AddWithValue("@phone", ph);
                    cmd.Parameters.AddWithValue("@id", uid);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                if (!dob.Equals("") || dob != null)
                {
                    SqlCommand cmd = new SqlCommand("update [User] set dob=@dob where Id=@id", con);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@id", uid);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                if (dept.Equals("") == false)
                {
                    SqlCommand cmd = new SqlCommand("update [User] set dept=@dept where Id=@id", con);
                    cmd.Parameters.AddWithValue("@dept", dept);
                    cmd.Parameters.AddWithValue("@id", uid);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }

                con.Close();
                this.Refresh();
                MessageBox.Show("Successfully saved the data", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nAN UNEXPECTED ERROR OCCURED WHILE SAVING YOUR DATA.\n" + ex, "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

        }

        /*Valid Name. Password, Email ID and Phone Number */
        public bool ValidName(string nameIp, out string errorMessage)
        {
            foreach (char c in nameIp)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    errorMessage = "Name can only contain letters";
                    return false;
                }
            }
            errorMessage = "";
            return true;
        }
        public bool ValidPsd(string psd, out string errorMessage)
        {
            foreach (char c in psd)
            {
                if (!char.IsDigit(c) && !char.IsLetter(c))
                {
                    errorMessage = "Password can only contain digits and letters";
                    return false;
                }
            }
            errorMessage = "";
            return true;
        }

        public bool ValidEmail(string emailAddress, out string errorMessage)
        {
            if (emailAddress == "" || emailAddress.Equals(""))
            {
                errorMessage = "";
                return true;
            }
            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            if (expr.IsMatch(emailAddress))
            {
                errorMessage = "";
                return true;
            }
            errorMessage = "Invalid email Address";
            return false;
        }

        public bool ValidPhone(string phone, out string errorMessage)
        {
            if (phone.Length > 10 || phone.Length < 10)
            {
                errorMessage = "Phone number must have 10 digits";
                return false;
            }
            foreach (char c in phone)
            {
                if (c < '0' || c > '9')
                {
                    errorMessage = "Phone number can only contain digits";
                    return false;
                }
            }
            errorMessage = "";
            return true;
        }

        /*UDF Validation functions for Name, Password, Email ID, Phone number ends here*/

        /*Validating Name*/
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

        /*Validating Psd*/
        private void TxtPsd_Validated(object sender, EventArgs e)
        {
            errorProviderPsd.SetError(txtPsd, "");
        }

        private void TxtPsd_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidPsd(txtPsd.Text, out errorMsg))
            {
                e.Cancel = true;
                txtPsd.Select(0, txtPsd.Text.Length);
                this.errorProviderPsd.SetError(txtPsd, errorMsg);
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }


        /*Validating Email ID*/
        private void TxtEmail_Validated(object sender, EventArgs e)
        {
            errorProviderEmail.SetError(txtEmail, "");
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmail(txtEmail.Text, out errorMsg))
            {
                e.Cancel = true;
                txtEmail.Select(0, txtEmail.Text.Length);
                this.errorProviderEmail.SetError(txtEmail, errorMsg);
                MessageBox.Show("Invalid Email ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        /*Validating Phone No.*/
        private void TxtPhone_Validated(object sender, EventArgs e)
        {
            errorProviderPhone.SetError(txtPhone, "");
        }

        private void Form12_Load(object sender, EventArgs e)
        {

            dtpDob.MaxDate = new DateTime(DateTime.Now.Year-19, 12, 31);
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            
            uid = f11.Userid;
            txtUid.Text = uid;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand("select *from [User] where Id=@id", con);
                com.Parameters.AddWithValue("@id", uid);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    txtName.Text = dr["name"].ToString().Trim();
                    lblUserDeets.Text = "USER DETAILS OF : " + txtName.Text.Trim();
                   

                    if (dr["email"] != null && dr["email"].ToString().Equals("") == false)
                    {
                        txtEmail.Text = dr["email"].ToString().Trim();
                    }
                    if (dr["psd"] != null && dr["psd"].ToString().Equals("") == false)
                    {
                        string psd1 = dr["psd"].ToString().Trim();
                        txtPsd.Text = psd1;
                    }

                    string d = dr["dept"].ToString().Trim();
                    int x = cmbDept.FindString(d);
                    if (x != -1)
                        cmbDept.SelectedIndex = cmbDept.FindString(d);

                    if (dr["dob"] != null && !dr["dob"].ToString().Equals(""))
                    {
                        string s = dr["dob"].ToString();
                        dtpDob.Text = s;
                    }
                    if (dr["phone"] != null && dr["phone"].ToString().Equals("") == false)
                    {
                        txtPhone.Text = dr["phone"].ToString().Trim();
                    }

                }
                dr.Close();

                com.Dispose();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nAN UNEXPECTED ERROR OCCURED WHILE LOADING YOUR DATA.\n" + ex, "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                
            }
        }

        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidPhone(txtPhone.Text, out errorMsg))
            {
                e.Cancel = true;
                txtPhone.Select(0, txtPhone.Text.Length);
                this.errorProviderEmail.SetError(txtPhone, errorMsg);
                MessageBox.Show("Invalid Phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
