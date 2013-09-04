using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_1
{
    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Teacher()
        {
            
        }
    }
}
