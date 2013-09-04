using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public abstract class TelerikAcademyCourse
    {
        private string courseName;
        private string teacherName;
        private IList<string> students;

        public TelerikAcademyCourse()
        {
            this.CourseName = null;
            this.TeacherName = null;
            this.Students = null;
        }

        public TelerikAcademyCourse(string name)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public TelerikAcademyCourse(string courseName, string teacherName, IList<string> students)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string CourseName
        {
            get { return this.courseName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("You must enter a name for the course!.");
                }

                this.courseName = value;
            }
        }

        public string TeacherName
        {
            get { return this.teacherName; }
            set { this.teacherName = value; }
        }

        public IList<string> Students {
            get { return this.students; }
            set { this.students = value; }
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
