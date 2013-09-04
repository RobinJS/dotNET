using System;

class UsersChoice
{
    static void Main()
    {
        Console.WriteLine("What type of variable would you like to enter?");
        Console.WriteLine("For \"int\" press 1, for \"double\" press 2, for \"string\" press 3...");
        byte entered = Convert.ToByte(Console.ReadLine());
        switch (entered)
        {
            case 1:
                Console.Write("Enter a value for your int: ");
                int userInt = Int32.Parse(Console.ReadLine());
                Console.WriteLine("The result is: {0}", userInt + 1);
                break;
            case 2:
                Console.Write("Enter a value for your double: ");
                double userDouble = Double.Parse(Console.ReadLine());
                Console.WriteLine("The result is: {0}", userDouble + 1);
                break;
            case 3:
                Console.Write("Enter a value for your string: ");
                string userString = Console.ReadLine();
                Console.WriteLine("The result is: {0}", userString + "*");
                break;
            default:
                Console.WriteLine("Not a valid number!");
                break;
        }
    }
}
