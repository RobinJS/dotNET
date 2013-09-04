namespace School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private List<Course> courses;

        public School()
        {
        }

        public List<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        static void Main()
        {
        }
    }
}
