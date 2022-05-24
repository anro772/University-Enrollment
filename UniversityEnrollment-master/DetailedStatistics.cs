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
    public partial class detailedstatistics : Form
    {
        public candidatepanel parent;
        public statisticspanel infor;
        public detailedstatistics()
        {
            InitializeComponent();
        }
        public detailedstatistics(candidatepanel form, statisticspanel infor)
        {
            this.infor = infor;
            parent = form;
            InitializeComponent();
            info();
        }
        private void info()
        {
            rtb.SelectionColor = Color.White;
            rtb.AppendText("\n    Number of students with grades between 1 and 2: ");
            rtb.SelectionColor = Color.FromArgb(233,69,96);
            rtb.AppendText(infor.v2 + "\n");
            rtb.SelectionColor = Color.White;
            rtb.AppendText("    Number of students with grades between 2 and 3: ");
            rtb.SelectionColor = Color.FromArgb(233, 69, 96);
            rtb.AppendText(infor.v3 + "\n");
            rtb.SelectionColor = Color.White;
            rtb.AppendText("    Number of students with grades between 3 and 4: ");
            rtb.SelectionColor = Color.FromArgb(233, 69, 96);
            rtb.AppendText(infor.v4 + "\n");
            rtb.SelectionColor = Color.White;
            rtb.AppendText("    Number of students with grades between 4 and 5: ");
            rtb.SelectionColor = Color.FromArgb(233, 69, 96);
            rtb.AppendText(infor.v5 + "\n");
            rtb.SelectionColor = Color.White;
            rtb.AppendText("    Number of students with grades between 5 and 6: ");
            rtb.SelectionColor = Color.FromArgb(233, 69, 96);
            rtb.AppendText(infor.v6 + "\n");
            rtb.SelectionColor = Color.White;
            rtb.AppendText("    Number of students with grades between 6 and 7: ");
            rtb.SelectionColor = Color.FromArgb(233, 69, 96);
            rtb.AppendText(infor.v7 + "\n");
            rtb.SelectionColor = Color.White;
            rtb.AppendText("    Number of students with grades between 7 and 8: ");
            rtb.SelectionColor = Color.FromArgb(233, 69, 96);
            rtb.AppendText(infor.v8 + "\n");
            rtb.SelectionColor = Color.White;
            rtb.AppendText("    Number of students with grades between 8 and 9: ");
            rtb.SelectionColor = Color.FromArgb(233, 69, 96);
            rtb.AppendText(infor.v9 + "\n");
            rtb.SelectionColor = Color.White;
            rtb.AppendText("    Number of students with grades between 9 and 10: ");
            rtb.SelectionColor = Color.FromArgb(233, 69, 96);
            rtb.AppendText(infor.v10 + "\n");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            infor.mainPanel.SendToBack();
            this.Hide();
        }
    }
}
