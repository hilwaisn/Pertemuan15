using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbatas.Visible = false;
            pbbawah.Visible = true;
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true)
            {
                this.BackColor = Color.FromArgb(34, 36, 49);
                label2.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                label2.ForeColor = Color.Black;
            }
        }

        private void pbatas_Click(object sender, EventArgs e)
        {
            if (pbatas.Visible == true)
            {
                pbatas.Visible = false;
                label2.Text = "Selamat Datang di Aplikasi saya";
            }
        }

        private void pbbawah_Click(object sender, EventArgs e)
        {
            if (pbatas.Visible == false)
            {
                pbatas.Visible = true;
                label2.Text = "Welcome to My Aplikasi";
            }
        }
    }
}
