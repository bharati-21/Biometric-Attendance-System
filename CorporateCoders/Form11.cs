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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        public string name, psd, Userid, Username;
        Form10 f10 = null;
        Form2 f2 = null;
        public Form11(Form10 form10, Form2 form2)
        {
            f10 = form10 as Form10;
            f2 = form2 as Form2;
            InitializeComponent();
        }

        private void BtnViewUserDeets_Click(object sender, EventArgs e)
        {
            
            if (txtUId.Text == "")
            {
                MessageBox.Show("User ID cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            /*else if (txtName.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }*/
            else
            {
                
                Userid = txtUId.Text;
                //Username = txtName.Text;
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select *from [User] where Id = @id", con);
                    //cmd.Parameters.AddWithValue("@name", txtName.Text.ToString());
                    cmd.Parameters.AddWithValue("@id", txtUId.Text.ToString());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        con.Close();
                        Form12 form = new Form12(this);
                        txtUId.Clear();
                       // txtName.Clear();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Admin Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        //txtName.Clear();
                        txtUId.Clear();
                    }
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("UNFORTUNATELY STOPPED. SOMETHING HAPPENED WHILE COLLECTING DATA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }

            }
        }

        /* Validating User ID*/
        public bool ValidID(String id, out string errorMessage)
        {
            foreach (char c in id)
            {
                if (!char.IsDigit(c))
                {
                    errorMessage = "Invalid ID.\nCan contain only digits";
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

        private void TxtUId_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidID(txtUId.Text, out errorMsg))
            {
                e.Cancel = true;
                txtUId.Select(0, txtUId.Text.Length);
                this.errorProviderUId.SetError(txtUId, errorMsg);
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }


       /* public bool ValidName(String nameIp, out string errorMessage)
        {
            foreach (char c in nameIp.Trim())
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

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidName(txtName.Text, out errorMsg))
            {
                e.Cancel = true;
                txtName.Select(0, txtName.Text.Length);
                this.errorProviderName.SetError(txtName, errorMsg);
                MessageBox.Show(errorMsg);
            }
        }*/

        /*Validating Name 
        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidName(txtName.Text, out errorMsg))
            {
                e.Cancel = true;
                txtName.Select(0, txtName.Text.Length);
                this.errorProviderName.SetError(txtName, errorMsg);
                MessageBox.Show(errorMsg);
            }
        }
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
        }*/

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            f10.Close();
            f2.Show();
        }

        private void LblHead_Click(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            f10.Show();
        }

        /*private void TxtName_Validated(object sender, EventArgs e)
        {
            errorProviderName.SetError(txtName, "");
        }*/

        private void BtnAllUsers_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13();
            txtUId.Clear();
            //txtName.Clear();
            form.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            name = f10.name;
            psd = f10.psd;
            lblHead.Text = "Welcome " + name;
            f10.Hide();
        }
    }
}
