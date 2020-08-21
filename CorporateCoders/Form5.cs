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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        Form4 f4 = null;
        Form3 f3 = null;
        public Form5(Form form4, Form form3)
        {
            f4 = form4 as Form4;
            f3 = form3 as Form3;
            InitializeComponent();
        }

        public String name, uid, psd;
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            f4.Close();
            this.Close();
            f3.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string email = "";
            long ph=0;
            string dept = "";
            try
            {

                email = txtEmail.Text.Trim();
                ph = long.Parse(txtPhone.Text.Trim());
                dept = cmbDept.SelectedItem.ToString().Trim() ;

            }
            catch(Exception ex)
            {
                ;
            }
            try
            {
                DateTime dob = dtpDob.Value;
                dob.ToString("yyyy-MM-dd");
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                con.Open();
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
                MessageBox.Show("Saved Successfully!" ,"Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                Form5 x = new Form5(f4, f3);
                this.Close();
                x.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY. AN UNEXPECTED ERROR OCCURED DURING UPDATE.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

        }

       
        public bool ValidEmail(string emailAddress, out string errorMessage)
        {
            if(emailAddress=="" || emailAddress.Equals(""))
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
            if (phone.Length>10 || phone.Length<10)
            {
                errorMessage = "Phone number must have 10 digits";
                return false;
            }
            foreach (char c in phone)
            {
                if(c<'0' || c> '9')
                {
                    errorMessage = "Phone number can only contain digits";
                    return false;
                }
            }
            errorMessage = "";
            return true;
        }

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

        private void TxtPhone_Validated(object sender, EventArgs e)
        {
            errorProviderPhone.SetError(txtPhone, "");
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            f4.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dtpDob.MaxDate = new DateTime(DateTime.Now.Year-19, 12, 31);
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            name = f4.name;
            psd = f4.psd;
            uid = f4.id;
            lblHead.Text = "Welcome " + f4.name;
            txtUid.Text = uid;
            txtName.Text = name;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand("select *from [User] where Id=@id", con);
                com.Parameters.AddWithValue("@id", uid);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["email"] != null && dr["email"].ToString().Equals("") == false)
                    {
                        txtEmail.Text = dr["email"].ToString().Trim();
                    }

                    string d = dr["dept"].ToString();
                    d = d.Trim();
                    int x = cmbDept.FindString(d);
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
                MessageBox.Show("UNFORTUNATELY STOPPED!\nAN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
