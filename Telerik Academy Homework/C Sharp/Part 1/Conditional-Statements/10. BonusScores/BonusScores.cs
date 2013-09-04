using System;

class BonusScores
{
    static void Main()
    {
        Console.WriteLine("Enter your score from 1 to 9 and you will receive some bonus scores.");
        byte userScore = Convert.ToByte(Console.ReadLine());
        switch (userScore)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Your new score is {0}.", userScore * 10);
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("Your new score is {0}.", userScore * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("Your new score is {0}.", userScore * 1000);
                break;
        default:
                Console.WriteLine("You should have entered an integer number between 1 and 9 (including). Try again!");
                break;
        }
    }
}
