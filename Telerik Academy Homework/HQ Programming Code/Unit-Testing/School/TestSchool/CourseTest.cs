using School;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestSchool
{
    /// <summary>
    ///This is a test class for CourseTest and is intended
    ///to contain all CourseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CourseTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        /// <summary>
        ///Tests for Course AddStudent
        ///</summary>
        [TestMethod()]
        public void AddStudentTestOneStudent()
        {
            List<Student> studentList = new List<Student>();
            Course courseOneStudent = new Course(studentList);
            Student studentPesho = new Student("Pesho", 10000);
            courseOneStudent.AddStudent(studentPesho);
            Assert.IsTrue(Course.students.Count == 1);
        }

        [TestMethod()]
        public void AddStudentTestThirtyStudents()
        {
            List<Student> studentList = new List<Student>();
            Course courseThirtyStudents = new Course(studentList);
            for (int i = 0; i < 30; i++)
            {
                courseThirtyStudents.AddStudent(new Student("Pesho", 10000 + i));
            }

            Assert.IsTrue(Course.students.Count == 30);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudentTestThirtyOneStudents()
        {
            List<Student> studentList = new List<Student>();
            Course courseThirtyOneStudents = new Course(studentList);
            for (int i = 0; i < 30; i++)
            {
                courseThirtyOneStudents.AddStudent(new Student("Pesho", 10000 + i));
            }

            Student studentPesho = new Student("Pesho", 10031);
            courseThirtyOneStudents.AddStudent(studentPesho);
        }

        /// <summary>
        ///Tests for Course RemoveStudent
        ///</summary>
        [TestMethod()]
        public void RemoveStudentTest()
        {
            List<Student> studentList = new List<Student>();
            Course courseRemovingStudents = new Course(studentList);

            Student studentPesho = new Student("Pesho", 10000);
            courseRemovingStudents.AddStudent(studentPesho);
            Student studentGosho = new Student("Gosho", 10001);
            courseRemovingStudents.AddStudent(studentGosho);
            Student studentMimi = new Student("Mimi", 10002);
            courseRemovingStudents.AddStudent(studentMimi);

            courseRemovingStudents.RemoveStudent(studentPesho);
            Assert.IsTrue(Course.students.Count == 2);
        }
    }
}
