using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorporateCoders
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        public string psd, name;
        Form2 mainForm = null;

        public Form10(Form2 f)
        { 
            mainForm = f as Form2;
            InitializeComponent();
        }

        private void RbnUserAccount_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnUserAccount.Checked==true)
            {
                Form11 f11 = new Form11(this, mainForm);
                f11.Show();
                rbnUserAccount.Checked = false;
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void RbnNewAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnNewAdmin.Checked == true)
            {
                FormNewAdmin ad = new FormNewAdmin(mainForm, this);
                ad.Show();
                rbnNewAdmin.Checked = false;
            }
        }

        private void RbnViewRequests_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnViewRequests.Checked == true)
            {

                Form14 f14 = new Form14();
                f14.Show();
                rbnViewRequests.Checked = false;
            }
        }

        private void RbnAddUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnAddUser.Checked == true)
            {
                FormNewUser newUser = new FormNewUser();
                newUser.Show();
                rbnAddUser.Checked = false;
            }
        }
        private void RbnDeleteUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnDeleteUser.Checked == true)
            {
                FormDeleteUser deleteUser = new FormDeleteUser(this, mainForm);
                deleteUser.Show();
                rbnDeleteUser.Checked = false;
            }
        }

        private void RbnVerify_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnVerify.Checked==true)
            {
                GiveAttendance giveAttendance = new GiveAttendance();
                giveAttendance.Show();
                rbnVerify.Checked = false;
            }
        }

        private void RbnViewAttendance_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnViewAttendance.Checked == true)
            {
                ViewAttendance view = new ViewAttendance(this,mainForm);
                view.Show();
                rbnViewAttendance.Checked = false;
            }
        }

        private void RbnUpdateAttendance_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnUpdateAttendance.Checked==true)
            {
                Form8 f8 = new Form8(this, mainForm);
                f8.Show();
                rbnUpdateAttendance.Checked = false;             
            }
        }

        private void RbnDeleteAdmin_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbnDeleteAdmin.Checked == true)
            {
                DeleteAdmin f8 = new DeleteAdmin(this, mainForm);
                f8.Show();
                rbnDeleteAdmin.Checked = false;
            }
        }

        private void BtnViewAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (btnViewAdmin.Checked == true)
            {
                ViewAdmin viewAdmin = new ViewAdmin(this);
                viewAdmin.Show();
                btnViewAdmin.Checked = false;
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;


            mainForm.Hide();
            psd = mainForm.psd;
            name = mainForm.uname;
        }
    }
}
