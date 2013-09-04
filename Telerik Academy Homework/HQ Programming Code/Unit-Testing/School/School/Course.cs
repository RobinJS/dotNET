namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        public static List<Student> students = new List<Student>();
        private const byte MaxStudentsInCourse = 30;
        private object currentStudent;

        public Course(object student)
        {
            this.currentStudent = student;
        }

        public static List<Student> Students
        {
            get { return students; }
        }

        public void AddStudent(Student student)
        {
            if (students.Count < MaxStudentsInCourse)
            {
                students.Add(student);
            }
            else
            {
                throw new ArgumentOutOfRangeException("You cannot add more students!");
            }
        }

        public void RemoveStudent(Student student)
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("There are no students to remove!");
            }
            else
            {
                Students.Remove(student);
            }
        }
    }
}
