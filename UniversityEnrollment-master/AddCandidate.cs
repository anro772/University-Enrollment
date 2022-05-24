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
using System.Windows.Input;

namespace UniversityEnrollment
{
    public partial class candidatepanel : Form //ADD CANDIDATE PANEL
    {
        public static int id = 0;
        public int added = 0;
        public Faculty faculty=new Faculty();
        private const string ConnectionString = "Data Source=database1.db";
        public listpanel child;
        public candidatepanel()
        {
            InitializeComponent();
            
        }
        
        private void candidatepanel_Load(object sender, EventArgs e)
        {

        }

        public void tbFirstName_Enter(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "First Name")
            {
                tbFirstName.Text = "";
                tbFirstName.ForeColor = Color.White;
            }
        }

        private void tbFirstName_Leave(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "")
            {
                tbFirstName.Text = "First Name";
                tbFirstName.ForeColor = Color.DarkGray;
            }
        }

        private void tbLastName_Enter(object sender, EventArgs e)
        {
            if (tbLastName.Text == "Last Name")
            {
                tbLastName.Text = "";
                tbLastName.ForeColor = Color.White;
            }
        }

        private void tbLastName_Leave(object sender, EventArgs e)
        {
            if (tbLastName.Text == "")
            {
                tbLastName.Text = "Last Name";
                tbLastName.ForeColor = Color.DarkGray;
            }
        }

        private void tbDateOfBirth_Enter(object sender, EventArgs e)
        {
            if (tbDateOfBirth.Text == "DD/MM/YYYY")
            {
                tbDateOfBirth.Text = "";
                tbDateOfBirth.ForeColor = Color.White;
            }
        }

        private void tbDateOfBirth_Leave(object sender, EventArgs e)
        {
            if (tbDateOfBirth.Text == "")
            {
                tbDateOfBirth.Text = "DD/MM/YYYY";
                tbDateOfBirth.ForeColor = Color.DarkGray;
            }
        }

        private void tbEMail_Enter(object sender, EventArgs e)
        {
            if (tbEMail.Text == "something@mail.com")
            {
                tbEMail.Text = "";
                tbEMail.ForeColor = Color.White;
            }
        }

        private void tbEMail_Leave(object sender, EventArgs e)
        {
            if (tbEMail.Text == "")
            {
                tbEMail.Text = "something@mail.com";
                tbEMail.ForeColor = Color.DarkGray;
            }
        }

        private void tbMainGrade_Enter(object sender, EventArgs e)
        {
            if (tbMainGrade.Text == "0, 1, 2..")
            {
                tbMainGrade.Text = "";
                tbMainGrade.ForeColor = Color.White;
            }
        }
        private void tbMainGrade_Leave(object sender, EventArgs e)
        {
            if (tbMainGrade.Text == "")
            {
                tbMainGrade.Text = "0, 1, 2..";
                tbMainGrade.ForeColor = Color.DarkGray;
            }
        }
        private void tbSecondaryGrade_Enter(object sender, EventArgs e)
        {
            if (tbSecondaryGrade.Text == "0, 1, 2..")
            {
                tbSecondaryGrade.Text = "";
                tbSecondaryGrade.ForeColor = Color.White;
            }
        }

        private void tbSecondaryGrade_Leave(object sender, EventArgs e)
        {
            if (tbSecondaryGrade.Text == "")
            {
                tbSecondaryGrade.Text = "0, 1, 2..";
                tbSecondaryGrade.ForeColor = Color.DarkGray;
            }
        }
        public void addCandidate(Candidate c)
        {
            faculty.Candidates.Add(c);
        }
        public void addCandidateButton_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                string first_name, last_name, email, dob;

                first_name = tbFirstName.Text;
                last_name = tbLastName.Text;
                email = tbEMail.Text;
                dob = tbDateOfBirth.Text;

                float mainGrade = float.Parse(tbMainGrade.Text);
                float secondaryGrade = float.Parse(tbSecondaryGrade.Text);

                Candidate c = new Candidate(first_name, last_name, dob, email, mainGrade, secondaryGrade);
                
                addCandidateDB(c);
            }
        }
        
        public void addCandidateDB(Candidate c)
        {
           // string query = "INSERT INTO Candidates(ID, FirstName, LastName, BirthDate, Email, MainGrade, SecondaryGrade, GradeValue) " +
             //  "Values('"+ c.FirstName + "', '" + c.LastName + "', '" + c.BirthDate + "', '" + c.EMail + "', '" + c.grade.MainGrade + "', '" + c.grade.SecondaryGrade + "', '" + c.grade.GradeValue + "'"+ ");"+"SELECT last_insert_rowid();";

            string query = "INSERT INTO Candidates(FirstName, LastName, BirthDate, Email, MainGrade, SecondaryGrade, GradeValue)" +
               " values(@firstName,@lastName,@birthDate,@email,@mainGrade,@secondaryGrade,@gradeValue);" +
               "SELECT last_insert_rowid();";


            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@firstName", c.FirstName);
                command.Parameters.AddWithValue("@lastName", c.LastName);
                command.Parameters.AddWithValue("@birthDate", c.BirthDate);
                command.Parameters.AddWithValue("@email", c.EMail);
                command.Parameters.AddWithValue("@mainGrade", c.grade.MainGrade);
                command.Parameters.AddWithValue("@secondaryGrade", c.grade.SecondaryGrade);
                command.Parameters.AddWithValue("@gradeValue", c.grade.GradeValue);
                
                c.CandidateID = (long)command.ExecuteScalar();
                addCandidate(c);
            }
        }
        
        public void loadCandidatesDB()
        {
            string query = "SELECT * FROM Candidates";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["ID"];
                        string firstName = (string)reader["FirstName"];
                        string lastName = (string)reader["LastName"];
                        string birthDate = (string)reader["BirthDate"];
                        string email = (string)reader["Email"];
                        float mainGrade = (long)reader["MainGrade"];
                        float secondaryGrade = (long)reader["SecondaryGrade"];
                        long gradeValue = (long)reader["GradeValue"];

                        Candidate c = new Candidate(firstName, lastName, birthDate, email, mainGrade, secondaryGrade, id);
                        addCandidate(c);
                    }
                }
            }
        }
        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (tbFirstName.Text.Length<1)
            {
                errProvider.SetError((Control)sender, "The name should be at least 1 character long");
                e.Cancel = true;
            }
            if (tbFirstName.Text.Any(char.IsDigit)||tbFirstName.Text.Any(char.IsSymbol)||tbFirstName.Text.Any(char.IsPunctuation))
            {
                errProvider.SetError((Control)sender, "The name should only contain letters");
                e.Cancel = true;
            }
        }

        private void tbFirstName_Validated(object sender, EventArgs e)
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
            int day=0, month=0, year=0;
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
        
        private void tbMainGrade_Validating(object sender, CancelEventArgs e)
        {
            int i;
            if (!int.TryParse(tbMainGrade.Text, out i))
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

    }
    
}
