using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Ellipse : Control
    {
        GraphicsPath path = new GraphicsPath();

        public Ellipse()
        {
            InitializeComponent();
            path.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            this.Region = new Region(path);

            this.BackColor = SystemColors.ControlDarkDark;
        }

        private void Ellipse_Resize(object sender, EventArgs e)
        {
            path.Reset();

            if (this.Region != null)
            {
                this.Region.Dispose();
                this.Region = null;
            }

            path.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            this.Region = new Region(path);
        }
    }
}
