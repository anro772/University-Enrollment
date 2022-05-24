using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlLibrary
{
    public partial class CloseButtonControl : UserControl
    {
        public CloseButtonControl()
        {
            InitializeComponent();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            X.BackColor = Color.FromArgb(0, 129, 180);
            backPanel.BackColor = Color.FromArgb(0, 129, 180);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            X.BackColor = Color.FromArgb(35,35,35);
            backPanel.BackColor = Color.FromArgb(35,35,35);
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
