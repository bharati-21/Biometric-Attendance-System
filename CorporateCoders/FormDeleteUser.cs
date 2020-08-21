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
    public partial class FormDeleteUser : Form
    {
        public FormDeleteUser()
        {
            
            InitializeComponent();
            
            

        }
        Form10 f10 = null;
        Form2 f2 = null;
        public FormDeleteUser(Form10 form10, Form2 form2 )
        {
            InitializeComponent();
            f10 = form10 as Form10;
            f2 = form2 as Form2;
            serialPort1.BaudRate = 9600;

            serialPort1.PortName = "COM3";
            serialPort1.Open();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            f10.Show();
            this.Close();
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
        private void TxtUid_Validated(object sender, EventArgs e)
        {
            errorProviderUId.SetError(txtUid, "");
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

        string id, name;
        int idToSend;
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
            if (txtUid.Text == "")
            {
                MessageBox.Show("User ID cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Username cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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
                        idToSend = int.Parse(id) - 100;
                        string message = "Are you sure you want to delete the following User Account?\nUSER ID = " + id + "\nNAME = " + name;
                        string title = "CONFIRMATION!";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("PLEASE NOTE : YOU CANNOT UNDO THIS ACTION!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            string message2 = "DO YOU STILL WANT TO PROCEED WITH THIS DELETION ?";
                            string title2 = "CONFIRMATION!";
                            MessageBoxButtons btns = MessageBoxButtons.YesNo;
                            DialogResult res = MessageBox.Show(message2, title2, btns, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            if (res == DialogResult.Yes)
                            {
                                serialPort1.WriteLine("3");
                                serialPort1.WriteLine(idToSend.ToString());
                               
                            }
                            else
                            {
                                MessageBox.Show("DELETION CANCELLED", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                this.Close();
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("DELETION CANCELLED", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            this.Close();
                            
                        }

                    }
                    else
                    {
                        MessageBox.Show("USER ACCOUNT NOT FOUND.\nINVALID ID OR NAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        
                    }
                    con.Close();
                    txtName.Clear();
                    txtUid.Clear();  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED DURING DELETION.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    txtName.Clear();
                    txtUid.Clear();
                }

            }
        }

        
        private bool performDeletion()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                con.Open();

                String s = "delete from [User] where id = @id and Name = @name";
                SqlCommand c = new SqlCommand(s, con);
                c.Parameters.AddWithValue("@id", id);
                c.Parameters.AddWithValue("@name", name);
                int x = c.ExecuteNonQuery();

                con.Close();
                if (x == 1)
                {
                    SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                    con1.Open();
                    String s2 = "delete from [Attendance] where id = @id and Name = @name";
                    SqlCommand c2 = new SqlCommand(s2, con1);
                    c2.Parameters.AddWithValue("@id", id);
                    c2.Parameters.AddWithValue("@name", name);
                    c2.ExecuteNonQuery();
                    con1.Close();

                    SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                    con2.Open();
                    String s3 = "delete from [reqTable] where id = @id and Name = @name";
                    SqlCommand c3 = new SqlCommand(s3, con2);
                    c3.Parameters.AddWithValue("@id", id);
                    c3.Parameters.AddWithValue("@name", name);
                    c3.ExecuteNonQuery();
                    con2.Close();
                    if (x != 1)
                        return false;
                }


               


            }
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED DURING DELETION." + ex, "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            
            return true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            f10.Close();
            f2.Show();
        }

        private void FormDeleteUser_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            panel1.Height = this.Height;
            this.MinimizeBox = true;
            this.AutoScroll = true;
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String msg = serialPort1.ReadLine();
           
            if (msg.Contains("Deleted"))
            {
                bool deletion = performDeletion();
                if(deletion==true)
                {
                    MessageBox.Show("Successfully deleted the follwouing user\nUser ID " + id + "\nName " + name, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                   
                }
            }
            else if(msg.Contains("Invalid"))
            {
                MessageBox.Show("Sorry some problem occured! Couldn't perform deletion. Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                
            }
            else
            {
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
