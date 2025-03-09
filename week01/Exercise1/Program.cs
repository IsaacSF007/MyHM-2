using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        var fname = Console.ReadLine();
        Console.WriteLine("What is your Last name? ");
        var lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}");
    }
}