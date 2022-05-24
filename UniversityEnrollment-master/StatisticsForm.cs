using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlLibrary;

namespace UniversityEnrollment
{
    public partial class statisticspanel : Form
    {
        public candidatepanel parent;
        public statisticspanel()
        {
            InitializeComponent();
        } 
        public int v2=0, v3=0, v4=0, v5=0, v6=0, v7=0, v8=0, v9=0, v10=0;

        private void barChart_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
            barChart.BackColor = Color.FromArgb(22, 33, 62);
        }

        private void barChart_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Right click to view details";
            barChart.BackColor = Color.FromArgb(20,31,60);
        }

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.BringToFront();
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
        private void viewDetailedStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailedstatistics ds = new detailedstatistics(parent,this);
            loadForm(ds);
        }

        private void barChart_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                if (me.Button == MouseButtons.Right)
                {
                    contextMenuStrip1.Show(barChart, me.Location);
                }
            }
        }

        public statisticspanel(candidatepanel form)
        {
            InitializeComponent();
            parent = form;
            
            if (parent.faculty.Candidates.Count < 10)
            {
                MessageBox.Show("There are less than 10 candidates in the database. Please add more candidates to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadForm(parent);
                return;
            }
            else
            {
                Count();
                barChart.Data = new BarChart[]
                {
                new BarChart("1 - 2",v2),
                new BarChart("2 - 3",v3),
                new BarChart("3 - 4",v4),
                new BarChart("4 - 5",v5),
                new BarChart("5 - 6",v6),
                new BarChart("6 - 7",v7),
                new BarChart("7 - 8",v8),
                new BarChart("8 - 9",v9),
                new BarChart("9 - 10",v10)
                };
     
            }
        }

        public void Count()
        {
            foreach(Candidate c in parent.faculty.Candidates)
            {
                if (c.grade.GradeValue <= 2)
                    v2++;
                else if (c.grade.GradeValue <= 3)
                    v3++;
                else if (c.grade.GradeValue <= 4)
                    v4++;
                else if (c.grade.GradeValue <= 5)
                    v5++;
                else if (c.grade.GradeValue <= 6)
                    v6++;
                else if (c.grade.GradeValue <= 7)
                    v7++;
                else if (c.grade.GradeValue <= 8)
                    v8++;
                else if (c.grade.GradeValue <= 9)
                    v9++;
                else
                    v10++;
            }
        }
    }
}
