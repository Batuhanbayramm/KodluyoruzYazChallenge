using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your birth day (exp: aa/bb/cccc): ");
        string userInput = Console.ReadLine();

        DateTime date;
        DateTime today = DateTime.Today;

        if (DateTime.TryParse(userInput, out date))
        {
            int age = today.Year - date.Year;
            Console.WriteLine("Your age is: " + age);
        }
        else
        {
            Console.WriteLine("Not valid.");
        }
    }
}
