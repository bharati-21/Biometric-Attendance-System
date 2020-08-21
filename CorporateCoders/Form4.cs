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
    public partial class Form4 : Form
    {
        Form3 f3 = null;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Form f)
        {
            f3 = f as Form3;
            InitializeComponent();
        }
        public string name, id, psd;

       

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void RbnMyAcct_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnMyAcct.Checked == true)
            {
                Form5 form = new Form5(this, f3);
                this.Hide();
                form.Show();
                rbnMyAcct.Checked = false;
            }
        }

        private void RbnCL_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnCL.Checked == true)
            {
                Form6 form = new Form6(this, f3);
                this.Hide();
                form.Show();
                rbnCL.Checked = false;
            }
        }

        private void RbnCheckAttendance_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnCheckAttendance.Checked==true)
            {
                Form15 f15 = new Form15(this);
                f15.Show();
                rbnCheckAttendance.Checked = false;
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            f3.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            f3.Hide();
            id = Form3.id;
            psd = Form3.psd;
            name = Form3.uname;
            lblUid.Text = lblUid.Text + id;
            lblHead.Text =  "Welcome " + name;
        }

    }
}
