namespace School
{
    using System;

    public class Student
    {
        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value.Trim()))
                {
                    throw new NullReferenceException("Name cannot be empty!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            set
            {
                if (value < 10000 || 99999 < value)
                {
                    throw new ArgumentOutOfRangeException("Student's unique number must be between 10000 and 99999!");
                }
                else
                {
                    this.uniqueNumber = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Student name: {0}, student ID: {1}", this.name, this.uniqueNumber);
        }
    }
}
