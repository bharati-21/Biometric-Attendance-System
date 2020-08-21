using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorporateCoders
{
    public partial class DeleteAdmin : Form
    {
        public DeleteAdmin()
        {
            InitializeComponent();
        }

        Form10 f10 = null;
        Form2 f2 = null;
        public DeleteAdmin(Form10 form10, Form2 form2)
        {
            InitializeComponent();
            f10 = form10 as Form10;
            f2 = form2 as Form2;
        }

        private void DeleteAdmin_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            panel1.Height = this.Height;
            this.MinimizeBox = true;
            this.AutoScroll = true;
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

        string name;
        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Username cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                    con.Open();
                    //Select the admin record from Admin table
                    SqlCommand cmd = new SqlCommand("select *from [Admin] where name = @name COLLATE SQL_Latin1_General_CP1_CS_AS", con);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.ToString().Trim());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        name = txtName.Text.ToString().Trim();
                        string message = "Are you sure you want to delete the following Admin Account?\nNAME = " + name;
                        string title = "CONFIRMATION!";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question,  MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("PLEASE NOTE : YOU CANNOT UNDO THIS ACTION!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning,  MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            string message2 = "DO YOU STILL WANT TO PROCEED WITH THIS DELETION ?";
                            string title2 = "CONFIRMATION!";
                            MessageBoxButtons btns = MessageBoxButtons.YesNo;
                            DialogResult res = MessageBox.Show(message2, title2, btns, MessageBoxIcon.Question ,  MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            if (res == DialogResult.Yes)
                            {
                                if(performDeletion())
                                {
                                    MessageBox.Show("Deleted Admin account successfully", "Deleted Successully", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                    txtName.Clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("DELETION CANCELLED", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                txtName.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("DELETION CANCELLED", "Cencelled", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            txtName.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("USER ACCOUNT NOT FOUND.\nINVALID NAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        txtName.Clear();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED DURING DELETION.\n" + ex, "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }

            }
        }

        private bool performDeletion()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                con.Open();

                String s = "delete from [Admin] where Name = @name";
                SqlCommand c = new SqlCommand(s, con);
                c.Parameters.AddWithValue("@name", name);
                int x = c.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED DURING DELETION.", "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

            return true;
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
    }
}
