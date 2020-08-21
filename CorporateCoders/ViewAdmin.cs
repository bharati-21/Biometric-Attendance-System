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
    public partial class ViewAdmin : Form
    {
        public ViewAdmin()
        {
            InitializeComponent();
        }

        Form10 f10 = null;

        public ViewAdmin(Form10 form10)
        {
            f10 = form10 as Form10;

            InitializeComponent();
        }

        public String adminName;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string psd = "";
            
            try
            {
                psd = txtPsd.Text.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOMETHING HAPPENED. UNFORTUNATELY STOPPED.", "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                con.Open();
                if (psd.Equals("") == false)
                {
                    SqlCommand cmd = new SqlCommand("update [Admin] set Password=@psd  where Name=@name", con);
                    cmd.Parameters.AddWithValue("@name", adminName);
                    cmd.Parameters.AddWithValue("@psd", psd);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                
                con.Close();
                this.Refresh();
                MessageBox.Show("Successfully saved the data", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            }
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nAN UNEXPECTED ERROR OCCURED WHILE SAVING YOUR DATA.\n" + ex, "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

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



        private void ViewAdmin_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;

            adminName = f10.name;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                con.Open();
                SqlCommand com = new SqlCommand("select *from [Admin] where Name=@name", con);
                com.Parameters.AddWithValue("@name", adminName);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    txtName.Text = dr["name"].ToString().Trim();
                    lblAdminDetails.Text = "ADMIN DETAILS OF : " + txtName.Text.Trim();


                    if (dr["Password"] != null && dr["Password"].ToString().Equals("") == false)
                    {
                        string psd1 = dr["Password"].ToString().Trim();
                        txtPsd.Text = psd1;
                    }

                }
                dr.Close();

                com.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nAN UNEXPECTED ERROR OCCURED WHILE LOADING YOUR DATA.\n" + ex, "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            }
        }

        private void TxtName_Validated(object sender, EventArgs e)
        {

        }
    }
}
