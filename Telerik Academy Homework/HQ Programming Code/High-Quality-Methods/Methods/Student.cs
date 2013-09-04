using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MoreInfo { get; set; }    // name changed from "OtherInfo"

        public bool IsOlderThan(Student otherStudent) // parameter name changed from "other"
        {
            DateTime firstStudentBirthDate =    // names changed from "firstDate" and from secondDate
                DateTime.Parse(this.MoreInfo.Substring(this.MoreInfo.Length - 10));
            DateTime secondStudentBirthDate =
                DateTime.Parse(otherStudent.MoreInfo.Substring(otherStudent.MoreInfo.Length - 10));
            bool isOlder = firstStudentBirthDate < secondStudentBirthDate;  // comparison operator changed from ">". Comparison saved in a variable
            return isOlder;
        }
    }
}
