using System;

class Company
{
    static void Main()
    {
        Console.WriteLine("Enter Company's name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter Company's address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter Company's stationary phone number (with area code): ");
        int companyPhone = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Company's fax number (with area code): ");
        int companyFax = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Company's website: ");
        string companyWebsite = Console.ReadLine();
        Console.WriteLine("Enter Company's manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Enter Company's manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Enter Company's manager age: ");
        int managerAge = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Company's manager phone number: ");
        int managerPhone = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("     If you want to contact {0} you can visit their office at {1} or you can call them on {2:(0#) ### ## ##}.{3}", companyName, companyAddress, companyPhone, Environment.NewLine);
        Console.Write("     If you wish, you can also send a fax to {0}. The number is: {1:(0#) ### ## ##} or you can visit their website at {2} for more info.{3}", companyName, companyFax, companyWebsite, Environment.NewLine);
        Console.Write("     To contact Company's manager whose name is {0} {1} and is {2} yers old, please call this phone number: {3:(0)### ### ###}.{4}", managerFirstName, managerLastName, managerAge, managerPhone, Environment.NewLine);
        Console.WriteLine();
        Console.WriteLine("     Have a nice day!");
        Console.WriteLine();
    }
}
