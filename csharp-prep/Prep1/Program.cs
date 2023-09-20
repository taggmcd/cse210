using System;

class Program
{
    static void Main(string[] args)
    {
        string firstname;
        string lastName;

        Console.Write("What is your first name? ");
        firstname = Console.ReadLine();
        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstname} {lastName}.");
    }
}