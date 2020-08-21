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
    public partial class FormNewAdmin : Form
    {
        public FormNewAdmin()
        {
            InitializeComponent();
        }

        Form2 f2 = null;
        Form10 f10 = null;
        
        public FormNewAdmin(Form form2, Form form10)
        {
            f2 = form2 as Form2;
            f10 = form10 as Form10;
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            f10.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            f10.Close();
            this.Close();
            f2.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Equals(""))
            {
                MessageBox.Show("Admin name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if(txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                String name = txtName.Text.Trim();
                String psd = txtPassword.Text.Trim();
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select *from [Admin] where Name = @name", con);
                    cmd.Parameters.AddWithValue("@name", name);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("This name has already been taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        txtName.Clear();
                        txtPassword.Clear();
                        con.Close();
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                        conn.Open();
                        string query = "insert into [Admin] (Name, Password) values (@name, @psd)";
                        SqlCommand com = new SqlCommand(query, conn);

                        com.Parameters.AddWithValue("@name", name);
                        com.Parameters.AddWithValue("@psd", psd);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Successfully created a new Admin account\nName = " + name, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        txtPassword.Clear();
                        txtName.Clear();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UNFORTUNATELY STOPPED!\nAN UNEXPECTED ERROR OCCURED WHILE PROCESSING YOUR DATA.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }

        private void FormNewAdmin_Load(object sender, EventArgs e)
        {
            f10.Hide();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            panel1.Height = this.Height;
            this.AutoScroll = true;
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

        private void TxtPassword_Validated(object sender, EventArgs e)
        {
            errorProviderPassword.SetError(txtPassword, "");
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidPsd(txtPassword.Text, out errorMsg))
            {
                e.Cancel = true;
                txtPassword.Select(0, txtPassword.Text.Length);
                this.errorProviderPassword.SetError(txtPassword, errorMsg);
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        public bool ValidPsd(string psd, out string errorMessage)
        {
            if (psd.Length < 3 || psd.Length > 15)
            {
                errorMessage = "Invalid Password\nPassword length must be 3 to 15 characters";
                return false;
            }
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
