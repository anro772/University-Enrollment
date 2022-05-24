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
    public partial class MinimizeButtonControl : UserControl
    {
        public MinimizeButtonControl()
        {
            InitializeComponent();
        }

        private void minimize_MouseMove(object sender, MouseEventArgs e)
        {
            minimize.BackColor = Color.FromArgb(0, 129, 180);
            backPanel.BackColor = Color.FromArgb(0, 129, 180);
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.BackColor = Color.FromArgb(35,35,35);
            backPanel.BackColor = Color.FromArgb(35,35,35);
        }

        private void minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }
    }
}
