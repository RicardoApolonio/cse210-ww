using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your favorite number? ");
        string numberText = Console.ReadLine();

        int number = int.Parse(numberText);
        int square = number * number;

        Console.WriteLine($"Hello {firstName}, the square of your number is {square}");
    }
}