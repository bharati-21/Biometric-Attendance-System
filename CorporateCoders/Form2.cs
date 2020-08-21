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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string uname, psd;
        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            panel1.Height = this.Height;
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

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select *from [Admin] where Name = @name COLLATE SQL_Latin1_General_CP1_CS_AS and Password = @password COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.ToString());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.ToString());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        con.Close();
                        uname = txtName.Text.ToString();
                        psd = txtPassword.Text.ToString();
                        Form10 form = new Form10(this);
                        form.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Admin Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("UNFORTUNATELY STOPPED!\nAN UNEXPECTED ERROR OCCURED DURING LOGIN.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }

            }
        }
    }
}
