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
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
            serialPort1.BaudRate = 9600;

            serialPort1.Open();
            
        }
   
        private void BtnEnroll_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("1");
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            DateTime t = DateTime.Now;
            string sqlFormattedDate = t.ToString("yyyy-MM-dd HH:mm:ss.fff");

            String msg = serialPort1.ReadLine(), temp = "", name = "";

            if (msg.Contains("#"))
            {
                MessageBox.Show(msg.Substring(0,23) +" ID = " + (int.Parse(msg.Substring(24))+100), "ID", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            if (msg.Contains("Failed"))
            {
                MessageBox.Show("Sorry! There was a problem enrolling. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            if (msg.Contains("#")==false && msg.Contains("Successfull")==false && msg.Contains("Failed")==false && msg.Contains("ID") == false)
            {
                
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            
            int id = -1;

            if (msg.Substring(0, 2).Equals("ID"))
            {
                t = DateTime.Now;
                id = int.Parse(msg.Substring(5)) + 100;
                 bool flag = true;
                do
                {
                    try
                    {
                        flag = true;
                        name = Interaction.InputBox("Enter name of the new User whose ID = " + id, "Name");
                        foreach (char c in name)
                        {
                            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                            {
                                flag = false;
                                throw new Exception("Invalid Name!\nCan contain only letters");
                                
                            }
                            if(name.Equals("") || name.Equals(null)) {
                                flag = false;
                                throw new Exception("Invalid Name!\nCan contain only letters");
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                while (flag != true);

                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                    con.Open();
                    String sql = "insert into [User] (Id,Name,Psd, enrollDate) values(@id, @name, @psd, @enroll)";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@psd", id);
                    cmd.Parameters.AddWithValue("@enroll", t);
                    int i = cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("ENROLLED SUCCESSFULLY.\nUSER ID : " + id + "\nNAME : " + name, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED DURING SIGN UP.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    this.Close();
                }
            }
            


        }

        private void FormNewUser_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
        }
    }
}
