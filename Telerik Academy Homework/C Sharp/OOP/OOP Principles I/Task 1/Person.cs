﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_1
{
    public class Person
    {
        private string name;

        public Person()
        {
            
        }

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
    }
}
