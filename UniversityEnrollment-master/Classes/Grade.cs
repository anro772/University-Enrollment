using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollment
{
    [Serializable]
    public class Grade
    {
        public float MainGrade { get; set; }
        public float SecondaryGrade { get; set; }
        public float GradeValue { get; set; }

        public Grade()
        {
            GradeValue = (float)(MainGrade * 0.8 + SecondaryGrade * 0.2);
        }
        
        public Grade(float mainGrade, float secondaryGrade)
        { 
            GradeValue = (float)(mainGrade * 0.8) + (float)(secondaryGrade * 0.2);
            MainGrade = mainGrade;
            SecondaryGrade = secondaryGrade;
        }

        public float calculateGrade(float mainGrade, float secondaryGrade)
        {
            return (float)(mainGrade * 0.8 + secondaryGrade * 0.2);
        }
    }
}
