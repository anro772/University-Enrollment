using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class CloseButtonControl : UserControl
    {
        
        public CloseButtonControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {   
            Application.Exit();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(60, 60, 60);
            backPanel.BackColor = Color.FromArgb(60,60,60);
        }

        private void backPanel_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.FromArgb(0, 122, 204);
            backPanel.BackColor = Color.FromArgb(0, 122, 204);
        }
    }
}
