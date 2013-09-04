using School;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSchool
{
    /// <summary>
    ///This is a test class for StudentTest and is intended
    ///to contain all StudentTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StudentTest
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
        ///Tests for Student Constructor Name
        ///</summary>
        [TestMethod()]
        public void TestStudentConstructorName()
        {
            string name = "Pesho";
            int uniqueNumber = 10000;
            Student target = new Student(name, uniqueNumber);
            Assert.AreEqual(target.Name, "Pesho");
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestStudentConstructorNameEmptyString()
        {
            string name = "";
            int uniqueNumber = 10000;
            Student target = new Student(name, uniqueNumber);
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestStudentConstructorNameStringOfSpaces()
        {
            string name = "   ";
            int uniqueNumber = 10000;
            Student target = new Student(name, uniqueNumber);
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestStudentConstructorNameNull()
        {
            string name = null;
            int uniqueNumber = 10000;
            Student target = new Student(name, uniqueNumber);
        }

        /// <summary>
        ///Tests for Student Constructor UniqueNumber
        ///</summary>
        [TestMethod()]
        public void TestStudentConstructorUniqueNumber()
        {
            string name = "Pesho";
            int uniqueNumber = 10000;
            Student target = new Student(name, uniqueNumber);
            Assert.AreEqual(target.UniqueNumber, 10000);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentConstructorUniqueNumberTooLess()
        {
            string name = "Pesho";
            int uniqueNumber = 9999;
            Student target = new Student(name, uniqueNumber);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentConstructorUniqueNumberTooMuch()
        {
            string name = "Pesho";
            int uniqueNumber = 100000;
            Student target = new Student(name, uniqueNumber);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentConstructorUniqueNumberNegative()
        {
            string name = "Pesho";
            int uniqueNumber = -100;
            Student target = new Student(name, uniqueNumber);
        }
    }
}
