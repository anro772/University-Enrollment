using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityEnrollment
{
    public partial class DataGridForm : Form
    {
        public candidatepanel parent;
        public MainFormDataGrid maindatagrid;
        public static int loaded = 0;
        public DataGridForm()
        {
            InitializeComponent();
        }
        public DataGridForm(candidatepanel form)
        {
            parent = form;
          
            reload();
            
            InitializeComponent();
            if (loaded == 0)
            {
                loaded = 1;           
            }
            else
            {
                loadSource();
            }
            dgvCandidates.EnableHeadersVisualStyles = false;
            dgvCandidates.DataSource = maindatagrid.candidatesGV;
            dgvCandidates.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCandidates.DefaultCellStyle.BackColor = Color.FromArgb(15,52,96);
            dgvCandidates.DefaultCellStyle.ForeColor = Color.White;
            dgvCandidates.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22,33,62);
            dgvCandidates.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 52, 96);
            dgvCandidates.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCandidates.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCandidates.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCandidates.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }
        
        
        public void reload()
        {
            maindatagrid = new MainFormDataGrid();
            foreach (Candidate c in parent.faculty.Candidates)
            {
                maindatagrid.addCandidateGV(c);
            }
        }

        public void loadSource()
        {
            dgvCandidates.DataSource = maindatagrid.candidatesGV;
        }

        public void DataGridForm_Load(object sender, EventArgs e)
        {
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dgvCandidates.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose a participant!");
                return;
            }

            DataGridViewRow row = dgvCandidates.SelectedRows[0];
            Candidate c = (Candidate)row.DataBoundItem;
            parent.faculty.Candidates.Remove(c);
            int index = dgvCandidates.SelectedRows[0].Index;
            maindatagrid.candidatesGV.RemoveAt(index);
            parent.faculty.Candidates.RemoveAt(index);
            parent.child.deleteCandidateDB(c);
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Export";
            dialog.Filter = "Text File|*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                {
                    writer.WriteLine("First Name,Last Name,Date of Birth,Email,Grade,ID");

                    foreach (Candidate c in parent.faculty.Candidates)
                        writer.WriteLine(c.FirstName + "," + c.LastName + "," + c.BirthDate + "," + c.EMail + "," +
                            c.grade.GradeValue + "," + c.CandidateID);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvCandidates.SelectedRows.Count!=0)
            {
                int index = dgvCandidates.SelectedRows[0].Index;
                EditCandidateForm edit = new EditCandidateForm(index, this, parent.faculty.Candidates.ElementAt(index));

                  loadForm(edit);
            }
            else MessageBox.Show("You need to select a candidate to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
