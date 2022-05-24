using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityEnrollment
{
    public partial class listpanel : Form //LIST VIEW PANEL
    {
        public candidatepanel parent;
        public static int loaded = 0;
        private const string ConnectionString = "Data Source=database1.db";
        public listpanel()
        {
            InitializeComponent();
        }
        public listpanel(candidatepanel form)
        {
            parent = form;
            parent.child = this;
            InitializeComponent();
            if (loaded == 0)
            { 
                parent.loadCandidatesDB(); 
                loaded = 1; 
            }
        }

        public static int id = 0;

        private void ListOfCandidatesForm_Load(object sender, EventArgs e)
        {
        }

        public void displayCandidates()
        {
            lvCandidates.Items.Clear();
            if (parent != null)
            {
                foreach (Candidate c in parent.faculty.Candidates)
                {
                    ListViewItem lv = new ListViewItem(c.FirstName.ToString());
                    lv.SubItems.Add(c.LastName.ToString());
                    lv.SubItems.Add(c.BirthDate.ToString());
                    lv.SubItems.Add(c.EMail.ToString());
                    lv.SubItems.Add(c.grade.GradeValue.ToString());
                    lv.SubItems.Add(c.CandidateID.ToString());
                    lv.Tag = c;
                    lvCandidates.Items.Add(lv);
                    
                }
            }
        }

        public void deleteCandidateDB(Candidate c)
        {
            string query = "DELETE FROM Candidates WHERE ID = @id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", c.CandidateID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void sERIALIZEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (parent != null)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = File.Create("serialized.bin"))
                    formatter.Serialize(stream, parent.faculty);
            }
        }

        private void bINARYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (parent!=null)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = File.OpenRead("serialized.bin"))
                {
                    parent.faculty = (Faculty)formatter.Deserialize(stream);
                    displayCandidates();
                }
            }
        }

        private void eXPORTToolStripMenuItem_Click(object sender, EventArgs e)
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
        public void editCandidate(int index,Candidate c)
        {
            parent.faculty.Candidates[index] = c;
            displayCandidates();
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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (lvCandidates.SelectedItems.Count!=0)
            {
                int index = lvCandidates.SelectedIndices[0];
                EditCandidateForm edit = new EditCandidateForm(index,this,parent.faculty.Candidates.ElementAt(index));
                loadForm(edit);
            }
            else MessageBox.Show("You need to select a candidate to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (lvCandidates.SelectedItems.Count != 0)
            { 
                int index = lvCandidates.SelectedIndices[0];
                ListViewItem item = lvCandidates.SelectedItems[0];
                Candidate c = (Candidate)item.Tag;
                deleteCandidateDB(c);
                parent.faculty.Candidates.RemoveAt(index);
                
                displayCandidates();
            }
            else MessageBox.Show("You need to select a candidate to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        
        private void lvCandidates_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvCandidates.SelectedItems.Count != 0)
                {
                    contextStripEditDelete.Show(Cursor.Position);
                }
                else
                    contextStripSort.Show(Cursor.Position);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //edit
        {
            if (lvCandidates.SelectedItems.Count != 0)
            {
                int index = lvCandidates.SelectedIndices[0];
                EditCandidateForm edit = new EditCandidateForm(index, this, parent.faculty.Candidates.ElementAt(index));
                loadForm(edit);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) //delete
        {
            if (lvCandidates.SelectedItems.Count != 0)
            {
                int index = lvCandidates.SelectedIndices[0];
                ListViewItem item = lvCandidates.SelectedItems[0];
                Candidate c = (Candidate)item.Tag;
                deleteCandidateDB(c);
                parent.faculty.Candidates.RemoveAt(index);
                displayCandidates();
            }
        }

        private void sortByHighestGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.faculty.Candidates.Sort(); //using IComparable
            displayCandidates();
        }

        private void sortByLowestGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.faculty.Candidates.Sort(delegate (Candidate x, Candidate y) //using Lambda Expression
            {
                return x.grade.GradeValue.CompareTo(y.grade.GradeValue);
            });
            displayCandidates();
        }

        private void sortByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.faculty.Candidates.Sort(delegate (Candidate x, Candidate y)
            {
                return x.CandidateID.CompareTo(y.CandidateID);
            });
            displayCandidates();
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { 
                contextStripSort.Show(Cursor.Position);
            }
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
        }

        public int _currentCandidateIndex = 0;
        
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 9);

            var pageSettings = e.PageSettings;
            var printAreaHeight = e.MarginBounds.Height;
            var printAreaWidth = e.MarginBounds.Width;
            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;

            if (pageSettings.Landscape)
            {
                var intTemp = printAreaHeight;
                printAreaHeight = printAreaWidth;
                printAreaWidth = intTemp;
            }
            const int rowHeight = 20;
            var columnWidth = printAreaWidth / 7;
            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;

            var currentX = 72;
            columnWidth += 40;
            e.Graphics.DrawRectangle(
                Pens.Black,
                currentX,
                currentY,
                columnWidth,
                rowHeight);
            e.Graphics.DrawString(
                "FIRST NAME",
                font,
                Brushes.Black,
                new RectangleF(currentX, currentY, columnWidth, rowHeight),
                fmt);
            currentX += columnWidth;

            e.Graphics.DrawRectangle(
                Pens.Black,
                currentX,
                currentY,
                columnWidth,
                rowHeight);
            e.Graphics.DrawString(
                "LAST NAME",
                font,
                Brushes.Black,
                currentX,
                currentY,
                fmt);
            currentX += columnWidth;
            columnWidth -= 40;
            e.Graphics.DrawRectangle(
                Pens.Black,
                currentX,
                currentY,
                columnWidth,
                rowHeight);
            e.Graphics.DrawString(
                "BIRTH DATE",
                font,
                Brushes.Black,
                currentX,
                currentY,
                fmt);
            currentX += columnWidth;
            columnWidth += 100;
            e.Graphics.DrawRectangle(
                Pens.Black,
                currentX,
                currentY,
                columnWidth,
                rowHeight);
            e.Graphics.DrawString(
                "EMAIL",
                font,
                Brushes.Black,
                currentX,
                currentY,
                fmt);
            currentX += columnWidth;
            columnWidth -= 100;
            columnWidth -= 40;
            e.Graphics.DrawRectangle(
                Pens.Black,
                currentX,
                currentY,
                columnWidth,
                rowHeight);
            e.Graphics.DrawString(
                "G 1",
                font,
                Brushes.Black,
                currentX,
                currentY,
                fmt);
            currentX += columnWidth;

            e.Graphics.DrawRectangle(
                Pens.Black,
                currentX,
                currentY,
                columnWidth,
                rowHeight);
            e.Graphics.DrawString(
                "G 2",
                font,
                Brushes.Black,
                currentX,
                currentY,
                fmt);
            currentX += columnWidth;

            e.Graphics.DrawRectangle(
                Pens.Black,
                currentX,
                currentY,
                columnWidth,
                rowHeight);
            e.Graphics.DrawString(
                "FINAL",
                font,
                Brushes.Black,
                currentX,
                currentY,
                fmt);
            currentX += columnWidth;
            columnWidth += 40;
            currentY += rowHeight;

            while (_currentCandidateIndex < parent.faculty.Candidates.Count)
            {
                currentX = 72;
                columnWidth += 40;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    parent.faculty.Candidates[_currentCandidateIndex].FirstName,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    parent.faculty.Candidates[_currentCandidateIndex].LastName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                columnWidth -= 40;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    parent.faculty.Candidates[_currentCandidateIndex].BirthDate,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                columnWidth += 100;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    parent.faculty.Candidates[_currentCandidateIndex].EMail,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                columnWidth -= 100;
                columnWidth -= 40;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    parent.faculty.Candidates[_currentCandidateIndex].grade.MainGrade.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    parent.faculty.Candidates[_currentCandidateIndex].grade.SecondaryGrade.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    parent.faculty.Candidates[_currentCandidateIndex].CandidateID.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                columnWidth += 40;
                _currentCandidateIndex++;
      
                currentY += rowHeight;

              
                if (currentY + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }            
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _currentCandidateIndex = 0;
        }

        private void printPreview_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }
    }
}
