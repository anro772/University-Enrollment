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
    public partial class Form1 : Form 
    {
        Faculty faculty = new Faculty();
        candidatepanel addCandidatesPanel =new candidatepanel();
        listpanel listOfCandidatesPanel=new listpanel();
        statisticspanel statisticsPanel;
        DataGridForm datagridpanel = new DataGridForm();

        bool sidebarExpand;
        bool mainExpand;


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        public Form1()
        {
            InitializeComponent();
            loadForm(addCandidatesPanel);
            listOfCandidatesPanel = new listpanel(addCandidatesPanel);
            loadForm(listOfCandidatesPanel);
            loadForm(new menupanel());
            
        }

       public void loadForm(object Form)
        {
            if(this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            sidebarTimer.Start();
        }
        
        int move = 0;
        int move2 = 0;
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                move = 1;
                sidebar.Width -= 30;
                if(sidebar.Width==sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                move = 1;
                sidebar.Width += 30;
                if(sidebar.Width==sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            loadForm(new menupanel());
            if (move2 == 1)
                move = 1;
            sidebarTimer.Start();
            if(move==1)
            {
                maintimer.Start();
            }
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            move = 0;
            move2 = 1;
            if(addCandidatesPanel==null)
            {
                loadForm(addCandidatesPanel);
            }
            else
            {
                loadForm(addCandidatesPanel);
            }
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            move = 0;
            move2 = 1;
           
                if (addCandidatesPanel.faculty.Candidates.Count > 10)
                {
                    statisticsPanel = new statisticspanel(addCandidatesPanel);
                    loadForm(statisticsPanel);
                }
                else
                {
                    MessageBox.Show("There are less than 10 candidates in the database. Please add more candidates to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadForm(addCandidatesPanel);
                }
        } 
        
        public void listButton_Click(object sender, EventArgs e)
        {
           if(listOfCandidatesPanel==null)
            {
                listOfCandidatesPanel=new listpanel(addCandidatesPanel);
                loadForm(listOfCandidatesPanel);
                listOfCandidatesPanel.displayCandidates();
            }
            else
            {
                listOfCandidatesPanel = new listpanel(addCandidatesPanel);
                loadForm(listOfCandidatesPanel);
                listOfCandidatesPanel.displayCandidates();
            }
        }
        private void dataGridButton_Click(object sender, EventArgs e)
        {
            if (addCandidatesPanel == null)
            {
                datagridpanel = new DataGridForm(addCandidatesPanel);
                loadForm(datagridpanel);
            }
            else
            {
                datagridpanel = new DataGridForm(addCandidatesPanel);
                loadForm(datagridpanel);
            }
        }
        private void maintimer_Tick(object sender, EventArgs e)
        {
            if (mainExpand)
            {
                mainpanel.Width -= 30;
                mainpanel.Left += 30;
                if (mainpanel.Width == mainpanel.MinimumSize.Width||mainpanel.Left>=187)
                {
                    mainpanel.Left = 187;
                    mainExpand = false;
                    maintimer.Stop();
                }
            }
            else
            {
                mainpanel.Width += 30;
                mainpanel.Left -= 30;
                
                if (mainpanel.Width == mainpanel.MaximumSize.Width||mainpanel.Left<=55)
                {
                    mainpanel.Left = 55;
                    mainExpand = true;
                    maintimer.Stop();
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                Application.Exit();
            }
            if(e.Alt&&e.KeyCode==Keys.D1)
            {
                loadForm(new menupanel());
            }
            if (e.Alt && e.KeyCode == Keys.D2)
            {
                loadForm(listOfCandidatesPanel);
            }
            if(e.Alt&&e.KeyCode == Keys.D3)
            {
                loadForm(addCandidatesPanel);
            }
            if (e.Alt && e.KeyCode == Keys.D4)
            {
                if (addCandidatesPanel.faculty.Candidates.Count > 10)
                {
                    statisticsPanel = new statisticspanel(addCandidatesPanel);
                    loadForm(statisticsPanel);
                }
                else
                {
                    MessageBox.Show("There are less than 10 candidates in the database. Please add more candidates to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadForm(addCandidatesPanel);
                }
            }
            if (e.Alt && e.KeyCode == Keys.D5)
            {
                if (addCandidatesPanel == null)
                {
                    datagridpanel = new DataGridForm(addCandidatesPanel);
                    loadForm(datagridpanel);
                }
                else
                {
                    datagridpanel = new DataGridForm(addCandidatesPanel);
                    loadForm(datagridpanel);
                }
            }
            if (e.Alt == true && e.KeyCode == Keys.A)
            {
                if (addCandidatesPanel.ValidateChildren())
                {
                   string first_name, last_name, email, dob;

                    first_name = addCandidatesPanel.tbFirstName.Text;
                    last_name = addCandidatesPanel.tbLastName.Text;
                    email = addCandidatesPanel.tbEMail.Text;
                    dob = addCandidatesPanel.tbDateOfBirth.Text;

                    float mainGrade = float.Parse(addCandidatesPanel.tbMainGrade.Text);
                    float secondaryGrade = float.Parse(addCandidatesPanel.tbSecondaryGrade.Text);

                    Candidate c = new Candidate(first_name, last_name, dob, email, mainGrade, secondaryGrade);

                    addCandidatesPanel.addCandidateDB(c);
                }
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new menupanel());
        }

        private void goToListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(listOfCandidatesPanel);
        }

        private void goToAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(addCandidatesPanel);
        }

        private void pictureBox1_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        
    }
}
