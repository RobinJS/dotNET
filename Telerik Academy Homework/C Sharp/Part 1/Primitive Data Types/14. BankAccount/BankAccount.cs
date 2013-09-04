using System;

class BankAccount
{
    static void Main()
    {
        string holderFirstName = "";
        string holderMiddleName = "";
        string holderLastName = "";
        decimal? balance = null;
        string bankName = "";
        string iban = "";
        string bic = "";
        ulong? carNumber1 = null;
        ulong? carNumber2 = null;
        ulong? carNumber3 = null;

        Console.WriteLine("Please, enter holder's first name:");
        holderFirstName = Console.ReadLine();
        Console.WriteLine("Please, enter holder's middle name:");
        holderMiddleName = Console.ReadLine();
        Console.WriteLine("Please, enter holder's last name:");
        holderLastName = Console.ReadLine();
        Console.WriteLine("Please, enter money balance:");
        balance = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter Bank Name:");
        bankName = (Console.ReadLine());
        Console.WriteLine("Please, enter IBAN:");
        iban = (Console.ReadLine());
        Console.WriteLine("Please, enter BIC code:");
        bic = (Console.ReadLine());
        Console.WriteLine("Please, enter Credit Card number 1:");
        carNumber1 = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter Credit Card number 2:");
        carNumber2 = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter Credit Card number 3:");
        carNumber3 = ulong.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("You entered the following data:");
        Console.WriteLine("Holder's name: " + holderFirstName + " " + holderMiddleName + " " + holderLastName);
        Console.WriteLine("Money balance: " + balance);
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("BIC code: " + bic);
        Console.WriteLine("Credit card number 1: " + carNumber1);
        Console.WriteLine("Credit card number 2: " + carNumber2);
        Console.WriteLine("Credit card number 3: " + carNumber3);
    }
}