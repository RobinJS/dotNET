using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_1
{
    public class Student : Person
    {
        private string studentName;
        private int studentNumber;

        public Student(string studentName, int studentNumber)
        {
            this.studentName = studentName;
            this.studentNumber = studentNumber;
        }

        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                this.studentNumber = value;
            }
        }

        public string StudentName
        {
            get
            {
                return this.studentName;
            }
            set
            {
                this.studentName = value;
            }
        }
    }
}
