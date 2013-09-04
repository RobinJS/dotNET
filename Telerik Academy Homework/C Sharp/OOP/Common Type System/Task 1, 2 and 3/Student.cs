// 1. Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
// 2. Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
// 3. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonTypeSystem
{

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string address;
        private int phone;
        private string email;
        private int course;
        private string specialty;
        private string university;
        private string faculty;


        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string MiddleName { get { return this.middleName; } set { this.middleName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public int SSN { get { return this.ssn; } set { this.ssn = value; } }
        public string Address { get { return this.address; } set { this.address = value; } }
        public int Phone { get { return this.phone; } set { this.phone = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public int Course { get { return this.course; } set { this.course = value; } }
        public string Specialty { get { return this.specialty; } set { this.specialty = value; } }
        public string University { get { return this.university; } set { this.university = value; } }
        public string Faculty { get { return this.faculty; } set { this.faculty = value; } }

        public Student(string firstName, string middleName, string lastName, int ssn, string address, int phone, string email, int course, string Specialty, string University, string Faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        // overriding
        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
            {
                return false;
            }

            if (! Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }

            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }

            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }

            if (!Object.Equals(this.Phone, student.Phone))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode() ^ Phone.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder std = new StringBuilder();

            std.AppendFormat(this.FirstName + " ");
            std.AppendFormat(this.MiddleName+ " ");
            std.AppendFormat(this.LastName + " ");
            std.AppendFormat(this.SSN + " ");
            std.AppendFormat(this.Address + " ");
            std.AppendFormat(this.Phone + " ");
            std.AppendFormat(this.Email + " ");
            std.AppendFormat(this.Course + " ");
            std.AppendFormat(this.Specialty + " ");
            std.AppendFormat(this.University + " ");
            std.AppendFormat(this.Faculty + " ");

            return std.ToString();
        }

        public static bool operator == (Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }
        public static bool operator != (Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        // cloning
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            Student original = this;
            Student copy = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.Phone, this.Email, this.Course, this.Specialty, this.University, this.Faculty);
            return copy;
        }

        // comparing
        public int CompareTo(Student student2)
        {
            if (firstName.CompareTo(student2.firstName) != 0)
            {
                return this.firstName.CompareTo(student2.firstName);
            }

            if (middleName.CompareTo(student2.middleName) != 0)
            {
                return this.middleName.CompareTo(student2.middleName);
            }

            if (LastName.CompareTo(student2.LastName) != 0)
            {
                return this.LastName.CompareTo(student2.LastName);
            }

            if (ssn.CompareTo(student2.ssn) != 0)
            {
                return this.ssn.CompareTo(student2.ssn);
            }

            if (Phone.CompareTo(student2.Phone) != 0)
            {
                return this.Phone.CompareTo(student2.Phone);
            }

            return 0;
        }
    }
}
