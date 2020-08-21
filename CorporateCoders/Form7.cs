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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        //To access home page and login page
        Form3 form3 = null;
        Form4 form4 = null;

        public Form7(Form4 f4, Form3 f3)
        {
            InitializeComponent();
            form4 = f4 as Form4;
            form3 = f3 as Form3;
        }


        public string id, name, psd;

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            form4.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            form4.Close();
            this.Close();
            form3.Show();
        }

        private void PictureBoxLogo2_Click(object sender, EventArgs e)
        {

        }

        private void BtnViewResults_Click(object sender, EventArgs e)
        {
            if(cmbMonth.SelectedItem==null)
            {
                MessageBox.Show("Please select a month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if(cmbYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                String month="";
                int m = 0;
                month = cmbMonth.SelectedItem.ToString().Trim() ;
                /*if(month.Equals("January"))
                {
                    m = 1;
                }
                else if (month.Equals("February"))
                {
                    m = 2;
                }
                else if (month.Equals("March"))
                {
                    m = 3;
                }
                else if (month=="April")
                {
                    m = 4;
                }
                else if (month.Equals("May"))
                {
                    m = 5;
                }
                else if (month.Equals("June"))
                {
                    m = 6;
                }
                else if (month.Equals("July"))
                {
                    m = 7;
                }
                else if (month.Equals("August"))
                {
                    m = 8;
                }
                else if (month.Equals("September"))
                {
                    m = 9;
                }
                else if (month.Equals("October"))
                {
                    m = 10;
                }
                else if (month.Equals("November"))
                {
                    m = 11;
                }
                else
                {
                    m = 12;
                }*/
                int year = int.Parse(cmbYear.SelectedItem.ToString());
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                    con.Open();
                    String check = "select *from [dbo].[reqTable] where Name=@name and Id=@id and Year = @year and Month = @month";
                    SqlDataAdapter sa = new SqlDataAdapter();
                    sa.SelectCommand = new SqlCommand(check, con);
                    sa.SelectCommand.Parameters.AddWithValue("@name", name);
                    sa.SelectCommand.Parameters.AddWithValue("@id", id);
                    sa.SelectCommand.Parameters.AddWithValue("@year", year);
                    sa.SelectCommand.Parameters.AddWithValue("@month", month);
                    sa.SelectCommand.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    sa.Fill(ds, "reqTable");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "reqTable";
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }

            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            // TODO: This line of code loads data into the 'dbds.reqTable' table. You can move, or remove it, as needed.
            name = form4.name;
            id = form4.id;
            psd = form4.psd;
            lblHead.Text = "Welcome " + name;
            lblUid.Text = lblUid.Text + id;
            int i = 0;
            for(i=2000; i<=int.Parse(DateTime.Now.Year.ToString()); i++)
            {
                cmbYear.Items.Add(i);
            }
            cmbMonth.Items.Add("January");
            cmbMonth.Items.Add("February");
            cmbMonth.Items.Add("March");
            cmbMonth.Items.Add("April");
            cmbMonth.Items.Add("May");
            cmbMonth.Items.Add("June");
            cmbMonth.Items.Add("July");
            cmbMonth.Items.Add("August");
            cmbMonth.Items.Add("Sepetember");
            cmbMonth.Items.Add("October");
            cmbMonth.Items.Add("November");
            cmbMonth.Items.Add("December");
        }
    }
}
