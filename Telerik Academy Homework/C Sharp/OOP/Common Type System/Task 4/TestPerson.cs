using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    public class TestPerson
    {
        static void Main(string[] args)
        {
            Person someone = new Person("Pesho");

            Console.WriteLine(someone);

            Person someoneElse = new Person("Gosho");
            someoneElse.Age = 43;

            Console.WriteLine(someoneElse);
        }
    }
}
