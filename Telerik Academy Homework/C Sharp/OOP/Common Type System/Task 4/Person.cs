using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            
            string ageCheck;

            if (this.Age > 0)
            {
                ageCheck = string.Format("{0}", this.Age);
            }
            else
	        {
                ageCheck = "Age not specified";
	        }

            return string.Format("Name: {0}, Age: {1}", this.Name, ageCheck);
        }
    }
}
