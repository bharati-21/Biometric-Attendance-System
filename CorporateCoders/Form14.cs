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
    public partial class Form14 : Form
    {
        public String nameReq, attTime, year, month, id, date, time, status, reqLeft, reason, statusAtt;

        private void BtnViewAllRequests_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        

        public Form14()
        {
            InitializeComponent();
        }
        public string name, psd;
        
       
/*
        private void selectedRowsButton_Click(object sender, System.EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(sb.ToString(), "Selected Rows");
            }
        }*/

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Select any ONE row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {

                    id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
                    nameReq = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
                    date = dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();
                    month = dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim();

                    year = dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim();

                    time = dataGridView1.SelectedRows[0].Cells[5].Value.ToString().Trim();
                    reason = dataGridView1.SelectedRows[0].Cells[6].Value.ToString().Trim();
                    status = dataGridView1.SelectedRows[0].Cells[7].Value.ToString().Trim();
                    reqLeft = dataGridView1.SelectedRows[0].Cells[8].Value.ToString().Trim();

                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Pbs\\source\\repos\\CorporateCoders\\CorporateCoders\\Database1.mdf;Integrated Security=True");
                        con.Open();

                                                           
                        String sql = "select status, VerTime from [dbo].[Attendance] where [Name] = @name and [Id] = @id and [Month]= @month and [Year] = @year and [DayOfMonth] = @date";
                        SqlCommand com = new SqlCommand(sql, con);
                        com.Parameters.AddWithValue("@id", id);
                        com.Parameters.AddWithValue("@name", nameReq);
                        com.Parameters.AddWithValue("@month", Microsoft.VisualBasic.DateAndTime.MonthName(DateTime.Now.Month));
                        com.Parameters.AddWithValue("@year", DateTime.Now.Year);
                        com.Parameters.AddWithValue("@date", date);
                        SqlDataReader dr = com.ExecuteReader();
                        //In case there is a row with Id, Name for current month and year : store it in reqLeft
                        if (dr.Read())
                        {
                            statusAtt = dr["status"].ToString();
                            attTime = dr["VerTime"].ToString();
                        }
                        else
                        {
                            statusAtt = "";
                        }
                        con.Close();
                        //MessageBox.Show(id + " " + nameReq + " " + date + " " + month + " " + year + " " + time + " " + status + " " + reqLeft);
                        Form17 f17 = new Form17(this);
                        f17.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex+ "\nUNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            this.reqTableTableAdapter.Fill(this.database1DataSet.reqTable);
            // TODO: This line of code loads data into the 'database1DataSet1.reqTable' table. You can move, or remove it, as needed.
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pbs\source\repos\CorporateCoders\CorporateCoders\Database1.mdf;Integrated Security=True");
                con.Open();
                String check = "select *from [dbo].[reqTable] where Status = @status";
                SqlDataAdapter sa = new SqlDataAdapter();
                sa.SelectCommand = new SqlCommand(check, con);

                //sa.SelectCommand.Parameters.AddWithValue("@year", DateTime.Now.Year);
                //sa.SelectCommand.Parameters.AddWithValue("@month", Microsoft.VisualBasic.DateAndTime.MonthName(DateTime.Now.Month));
                sa.SelectCommand.Parameters.AddWithValue("@status", "Pending Request");
                sa.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                sa.Fill(ds, "reqTable");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "reqTable";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UNFORTUNATELY STOPPED!\nSORRY, AN UNEXPECTED ERROR OCCURED WHILE COLLECTING DATA.", "PLEASE TRY AGAIN",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }




            // TODO: This line of code loads data into the 'database1DataSet.reqTable' table. You can move, or remove it, as needed.

        }
    }
}
