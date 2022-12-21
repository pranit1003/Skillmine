using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    class Student
    {
        private int studentId;
        private string studentName;
        int phy, chem, maths, total;
        double percentage;

        public Student(int studentId, string studentName,
        int phy, int chem, int maths )
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.phy = phy;
            this.chem = chem;
            this.maths = maths;
         }
        public void CalPercentage()
        {
            total = phy + chem + maths;
            percentage =  (total / 3) ;
        }
        public override string ToString()
        {
            return $"Student id is:{studentId} student name is: {studentName} Percentage is: {percentage}"; 
        }

        
    }

    
}
