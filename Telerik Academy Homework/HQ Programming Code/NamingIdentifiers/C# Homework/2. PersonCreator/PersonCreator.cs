using System;
using System.Collections.Generic;
using System.Text;

namespace _2.PersonCreator
{
    class PersonCreator
    {
        enum Gender
        {
            coolBoy, hotChick
        }

        class Person
        {
            public Gender Gender { get; set; }
            public string PersonName { get; set; }
            public int Age { get; set; }
        }

        public void MakePerson(int personalMagicalNumber)
        {
            Person newPerson = new Person();
            newPerson.Age = personalMagicalNumber;

            if (personalMagicalNumber % 2 == 0)
            {
                newPerson.PersonName = "The Batka";
                newPerson.Gender = Gender.coolBoy;
            }
            else
            {
                newPerson.PersonName = "The Chick";
                newPerson.Gender = Gender.hotChick;
            }

            Console.WriteLine("Person's name is: {0}", newPerson.PersonName);
            Console.WriteLine("Person's gender is: {0}", newPerson.Gender);
        }

        static void Main()
        {
            int personalMagicalNumber = 26;

            PersonCreator newPerson = new PersonCreator();
            newPerson.MakePerson(personalMagicalNumber);
        }
    }
}
