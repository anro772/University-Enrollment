using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollment
{
    public class MainFormDataGrid
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public float MainGrade { get; set; }
        public float SecondaryGrade { get; set; }
        public long ID { get; set; }
        public BindingList<Candidate> candidatesGV { get; set; }

        public MainFormDataGrid()
        {
            candidatesGV = new BindingList<Candidate>();
        }
        public void addCandidateGV(Candidate c)
        {
            FirstName = c.FirstName;
            LastName = c.LastName;
            BirthDate = c.BirthDate;
            Email = c.EMail;
            MainGrade = c.grade.MainGrade;
            SecondaryGrade = c.grade.SecondaryGrade;
            ID = c.CandidateID;
            Candidate c1 = new Candidate(FirstName, LastName, BirthDate, Email, MainGrade, SecondaryGrade, ID);
           
            candidatesGV.Add(c1);
        }
    }
}
