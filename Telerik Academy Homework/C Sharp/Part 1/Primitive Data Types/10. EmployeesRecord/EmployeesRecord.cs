using System;

class EmployeesRecord
{
    static void Main()
    {
        string workerFirstName = "";
        string workerLastName = "";
        byte? workerAge = null;
        char? workerGender = null;
        uint? workerID = null;

        Console.WriteLine("Please, enter worker's first name:");
        workerFirstName = Console.ReadLine();
        Console.WriteLine("Please, enter worker's last name:");
        workerLastName = Console.ReadLine();
        Console.WriteLine("Please, enter worker's age:");
        workerAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter worker's gender (m or f):");
        workerGender = char.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter worker's ID:");
        workerID = uint.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("You entered the following data:");
        Console.WriteLine("Name: " + workerFirstName + " " + workerLastName);
        Console.WriteLine("Age: " + workerAge + " y.o.");
        Console.WriteLine("Gender: " + workerGender);
        Console.WriteLine("ID: " + workerID);
    }
}