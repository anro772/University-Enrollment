using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityEnrollment
{
    public partial class menupanel : Form
    {
        
        public menupanel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToShortTimeString();
            Time.Text = DateTime.Now.ToLongDateString();
        }

        private void menupanel_Load(object sender, EventArgs e)
        {
            DateTimer.Start();
        }

        private void siteButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.ase.ro/");
        }

        private void siteButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
        }

        private void siteButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Go to ASE website";
        }
    }
}
