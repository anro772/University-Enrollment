using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollment
{
    [Serializable]
    public class Candidate : IComparable<Candidate>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string EMail { get; set; }
        public long CandidateID { get; set; }

        public Grade grade;

        //public Candidate()
        //{
        //    grade = new Grade();
        //}
        
        public Candidate(string firstName, string lastName, string birthDate,string eMail, float mainGrade,
           float secondaryGrade, long candidateID)
        {
            grade = new Grade(mainGrade, secondaryGrade);
            FirstName = firstName;
            LastName= lastName;
            BirthDate= birthDate;
            EMail= eMail;
            CandidateID= candidateID;
        }

        public Candidate(string firstName, string lastName, string birthDate, string eMail, float mainGrade,
            float secondaryGrade)
        {
            grade = new Grade(mainGrade, secondaryGrade);
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            EMail = eMail;
        }

        public int CompareTo(Candidate other)
        {
            if (this.grade.GradeValue > other.grade.GradeValue)
                return -1;
            if (this.grade.GradeValue < other.grade.GradeValue)
                return 1;
            return 0;
        }
    }
}
