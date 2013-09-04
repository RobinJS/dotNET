using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonTypeSystem
{
    class Program
    {

        static void Main(string[] args)
        {
            Student Pesho = new Student("Pesho", "Ivanov", "Georgiev", 1235, "Sofia", 886453212, "asd@asd.gf", 4, "Philosophy", "SU", "Philosophy");
            Student Gosho = new Student("Gosho", "Petrov", "Georgiev", 3658, "Sofia", 789324854, "bgd@asd.gf", 4, "Philosophy", "SU", "Philosophy");
            
            Console.WriteLine(Pesho);

            Console.WriteLine(Pesho.CompareTo(Gosho));

           
        }
    }
}
