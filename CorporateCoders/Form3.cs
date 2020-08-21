using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CorporateCoders
{
    public partial class Form3 : Form
    {
        public static string uname, id, psd;

        public Form3()
        {
            InitializeComponent();
        }

        //Check if the user left any textboxes empty
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUId.Text == "" )
            {
                MessageBox.Show("User ID cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if(txtName.Text == "")
            {
                MessageBox.Show("Username cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if(txtPassword.Text == "")
            {
                MessageBox.Show("Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select *from [User] where id = @id and name = @name COLLATE SQL_Latin1_General_CP1_CS_AS and psd = @password COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.ToString());
                    cmd.Parameters.AddWithValue("@id", txtUId.Text.ToString());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.ToString());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        con.Close();
                        uname = txtName.Text.ToString();
                        id = txtUId.Text.ToString();
                        psd = txtPassword.Text.ToString();
                        Form4 form = new Form4(this);
                        form.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Uder ID, Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("UNFORTUNATELY STOPPED!\nAN UNEXPECTED ERROR OCCURED DURING LOGIN.", "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }

            }
        }

        
        // Validate User ID
        private void TxtUId_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidUserId(txtUId.Text, out errorMsg))
            {
                e.Cancel = true;
                txtUId.Select(0, txtUId.Text.Length);
                this.errorProviderUId.SetError(txtUId, errorMsg);
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
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
        private void TxtUId_Validated(object sender, EventArgs e)
        {
            errorProviderUId.SetError(txtUId, "");
        }

        // Validate User name
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

        //Validate Password
        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidPsd(txtPassword.Text, out errorMsg))
            {
                e.Cancel = true;
                txtPassword.Select(0, txtPassword.Text.Length);
                this.errorProviderPsd.SetError(txtPassword, errorMsg);
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        private void TxtPassword_Validated(object sender, EventArgs e)
        {
            errorProviderPsd.SetError(txtPassword, "");
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            txtName.Clear();
            txtUId.Clear();
            txtPassword.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            panel1.Height = this.Height;
            toolTip1.SetToolTip(btnLogin, "Contact the admin for issues with your password or login.\ngeekconadmin@gmail.com");
        }

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            txtName.Clear();
            txtUId.Clear();
            txtPassword.Clear();
        }

        public bool ValidPsd(string psd, out string errorMessage)
        {
            foreach (char c in psd)
            {
                if (!char.IsDigit(c) && !char.IsLetter(c))
                {
                    errorMessage = "Invalid Password\nCan contain only numbers or letters";
                    return false;
                }
            }
            errorMessage = "";
            return true;
        }

        
    }
}
