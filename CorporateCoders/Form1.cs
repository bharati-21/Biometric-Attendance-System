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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void BtnUserLogin_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            panel1.Height = this.Height;
            //panel2.Width = this.Width;
        }
    }
}
