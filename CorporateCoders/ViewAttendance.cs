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
    public partial class ViewAttendance : Form
    {
        public ViewAttendance()
        {
            InitializeComponent();
        }

        Form10 f10 = null;
        Form2 f2=null;
        public ViewAttendance(Form10 form10, Form2 form2)
        {
            f10 = form10 as Form10;
            f2 = form2 as Form2;
            InitializeComponent();
        }

        private void RbnViewIndividual_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnViewIndividual.Checked==true)
            {
                IndividualUserAttendance userAttendance = new IndividualUserAttendance(f10, f2, this);
                userAttendance.Show();
            }
        }

        private void RbnViewAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnViewAll.Checked == true)
            {
                Form16 f16 = new Form16();
                f16.Show();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            f10.Close();
            f2.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            f10.Show();

        }

        private void ViewAttendance_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.AutoScroll = true;
            panel1.Height = this.Height;
        }

        private void LblMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
