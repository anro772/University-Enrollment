using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityEnrollment
{
    public partial class EditCandidateForm : Form
    {
        public listpanel parent;
        public DataGridForm parent2;
        public int elIndex;
        public static long x;
        private const string ConnectionString = "Data Source=database1.db";
        public EditCandidateForm(int index, listpanel form, Candidate c)
        {
            parent = form;
            elIndex = index;
            InitializeComponent();
            tbFirstName.Text = c.FirstName.ToString();
            tbLastName.Text = c.LastName.ToString();
            tbDateOfBirth.Text = c.BirthDate.ToString();
            tbEMail.Text = c.EMail.ToString();
            tbMainGrade.Text = c.grade.MainGrade.ToString();
            tbSecondaryGrade.Text = c.grade.SecondaryGrade.ToString();
            x = c.CandidateID;
        }
        public EditCandidateForm(int index, DataGridForm form, Candidate c)
        {
            parent2 = form;
            elIndex = index;
            InitializeComponent();
            tbFirstName.Text = c.FirstName.ToString();
            tbLastName.Text = c.LastName.ToString();
            tbDateOfBirth.Text = c.BirthDate.ToString();
            tbEMail.Text = c.EMail.ToString();
            tbMainGrade.Text = c.grade.MainGrade.ToString();
            tbSecondaryGrade.Text = c.grade.SecondaryGrade.ToString();
            x = c.CandidateID;
        }

        private void editCandidateButton_Click(object sender, EventArgs e)
        {
            string firstName, lastName, DOB, email;
            float mainGrade, secondaryGrade;
            long id = x;
            firstName = tbFirstName.Text;
            lastName = tbLastName.Text;
            DOB = tbDateOfBirth.Text;
            email = tbEMail.Text;
            mainGrade = float.Parse(tbMainGrade.Text);
            secondaryGrade = float.Parse(tbSecondaryGrade.Text);
            float gradeValue = (float)(0.8 * mainGrade + 0.2 * secondaryGrade);
            Candidate c = new Candidate(firstName, lastName, DOB, email, mainGrade, secondaryGrade, id);
            editCandidateDB(c);
            if (parent != null)
            {
                parent.editCandidate(elIndex, c);
                parent.mainPanel.SendToBack();
            }
            else
            {
                parent2.mainPanel.SendToBack();
                parent2.parent.faculty.Candidates[elIndex] = c;
                parent2.reload();
                parent2.loadSource();
            }
        }

        public void editCandidateDB(Candidate c)
        {
            string query = "UPDATE Candidates SET FirstName = '" + c.FirstName + "', LastName = '" + c.LastName + 
                "', BirthDate = '" + c.BirthDate + "', Email = '" + c.EMail + "', MainGrade = '" + c.grade.MainGrade 
                + "', SecondaryGrade = '" + c.grade.SecondaryGrade + "' WHERE ID = '" + c.CandidateID + "';";
            using(SQLiteConnection connection=new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if(parent!=null)
                parent.mainPanel.SendToBack();
            else
                parent2.mainPanel.SendToBack();
        }

        private void tbMainGrade_Validating(object sender, CancelEventArgs e)
        {
            int i;
            if (!int.TryParse(tbMainGrade.Text,out i))
            {
                errProvider.SetError((Control)sender, "The grade should be a number");
                e.Cancel = true;
            }

            else if (float.Parse(tbMainGrade.Text) > 10 || float.Parse(tbMainGrade.Text) < 0)
            {
                errProvider.SetError((Control)sender, "The grade should be between 0 and 10");
                e.Cancel = true;
            }
        }

        private void tbMainGrade_Validated(object sender, EventArgs e)
        {
            errProvider.SetError((Control)sender, String.Empty);
        }

        private void tbSecondaryGrade_Validating(object sender, CancelEventArgs e)
        {
            int i;
            if (!int.TryParse(tbSecondaryGrade.Text, out i))
            {
                errProvider.SetError((Control)sender, "The grade should be a number");
                e.Cancel = true;
            }
            else if (float.Parse(tbSecondaryGrade.Text) > 10 || float.Parse(tbSecondaryGrade.Text) < 0)
            {
                errProvider.SetError((Control)sender, "The grade should be between 0 and 10");
                e.Cancel = true;
            }
        }

        private void tbSecondaryGrade_Validated(object sender, EventArgs e)
        {
            errProvider.SetError((Control)sender, String.Empty);
        }

        private void tbEMail_Validating(object sender, CancelEventArgs e)
        {
            if (!tbEMail.Text.Contains("@") || !tbEMail.Text.Contains("."))
            {
                errProvider.SetError((Control)sender, "The email should contain @ and .");
                e.Cancel = true;
            }
        }

        private void tbEMail_Validated(object sender, EventArgs e)
        {
            errProvider.SetError((Control)sender, String.Empty);
        }

        private void tbDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            if (tbDateOfBirth.Text.Length > 10)
            {
                errProvider.SetError((Control)sender, "The date should be 10 characters long");
                e.Cancel = true;
            }
            if (tbDateOfBirth.Text.Any(char.IsLetter))
            {
                errProvider.SetError((Control)sender, "The date should only contain digits and slashes");
                e.Cancel = true;
            }
            int day = 0, month = 0, year = 0;
            string[] date = tbDateOfBirth.Text.Split('/');
            if (date.Length == 3)
            {
                if (!date[0].Any(char.IsLetter))
                {
                    day = int.Parse(date[0]);
                    if (day > 31 || day < 1)
                    {
                        errProvider.SetError((Control)sender, "The day should be between 1 and 31");
                        e.Cancel = true;
                    }
                }
                if (!date[1].Any(char.IsLetter))
                {
                    month = int.Parse(date[1]);
                    if (month > 12 || month < 1)
                    {
                        errProvider.SetError((Control)sender, "The month should be between 1 and 12");
                        e.Cancel = true;
                    }
                }
                if (!date[2].Any(char.IsLetter))
                {
                    year = int.Parse(date[2]);
                    if (year > DateTime.Now.Year || year < 1900)
                    {
                        errProvider.SetError((Control)sender, "The year should be between 1900 and " + DateTime.Now.Year);
                        e.Cancel = true;
                    }
                }
            }
            else
            {
                errProvider.SetError((Control)sender, "The date is not valid");
                e.Cancel = true;
            }
        }

        private void tbDateOfBirth_Validated(object sender, EventArgs e)
        {
            errProvider.SetError((Control)sender, String.Empty);
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (tbLastName.Text.Length < 1)
            {
                errProvider.SetError((Control)sender, "The name should be at least 1 character long");
                e.Cancel = true;
            }
            if (tbLastName.Text.Any(char.IsDigit))
            {
                errProvider.SetError((Control)sender, "The name should not contain a digit");
                e.Cancel = true;
            }
        }

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            errProvider.SetError((Control)sender, String.Empty);
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (tbFirstName.Text.Length < 1)
            {
                errProvider.SetError((Control)sender, "The name should be at least 1 character long");
                e.Cancel = true;
            }
            if (tbFirstName.Text.Any(char.IsDigit) || tbFirstName.Text.Any(char.IsSymbol) || tbFirstName.Text.Any(char.IsPunctuation))
            {
                errProvider.SetError((Control)sender, "The name should only contain letters");
                e.Cancel = true;
            }
        }

        private void tbFirstName_Validated(object sender, EventArgs e)
        {
            errProvider.SetError((Control)sender, String.Empty);
        }
    }
}
