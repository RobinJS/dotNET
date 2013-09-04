// 3. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators
// 4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
// 5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_04_05_Students
{
    public class StudentsSearch
    {
        public static void Main()
        {
            var students = new Student[]
            {
              new Student { FirstName ="Sylvester", LastName = "Stallone", Age = 18 },
              new Student { FirstName = "Jason", LastName = "Statham", Age = 10 },
              new Student { FirstName = "Jean-Claude", LastName = "Van Damme", Age = 20 },
              new Student { FirstName = "Jet", LastName = "Li", Age = 22 },
              new Student { FirstName = "Dolph", LastName = "Lundgren", Age = 50 },
              new Student { FirstName = "Chuck", LastName = "Norris", Age = 70 },
              new Student { FirstName = "Bruce", LastName = "Willis", Age = 24 },
              new Student { FirstName = "Arnold", LastName = "Schwarzenegger", Age = 55 },
              new Student { FirstName = "Bruce", LastName = "Lee", Age = 35 },
              new Student { FirstName = "Jason", LastName = "Bateman", Age = 44 }
            };

            Console.WriteLine("All students whose first name is before its last name alphabetically:");
            AlphabeticallySearch(students);

            Console.WriteLine();

            Console.WriteLine("The first name and last name of all students with age between 18 and 24:");
            AgedSearch(students);

            Console.WriteLine();

            Console.WriteLine("Sorted by first name and last name in descending order with lambda expressions:");
            DescendingOrderLambda(students);

            Console.WriteLine();

            Console.WriteLine("Sorted by first name and last name in descending order with LINQ:");
            DescendingOrderLINQ(students);

        }

        static void AlphabeticallySearch(Student[] students)
        {
            var theChosenOnes =
                    from student in students
                    where student.FirstName.CompareTo(student.LastName) < 0
                    select student;

            foreach (var student in theChosenOnes)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }

        static void AgedSearch(Student[] students)
        {
            var selectedStudents =
                    from student in students
                    where (student.Age >= 18 && student.Age <= 24)
                    select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }

        static void DescendingOrderLambda(Student[] students)
        {
            var lambdaOrder = students.OrderBy(Student => Student.FirstName).ThenBy(Student => Student.LastName).Reverse();

            foreach (var student in lambdaOrder)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }

        static void DescendingOrderLINQ(Student[] students)
        {
            var linqOrder = 
                from student in students
                    orderby student.FirstName descending, student.LastName descending
                    select student;

            foreach (var student in linqOrder)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

}
