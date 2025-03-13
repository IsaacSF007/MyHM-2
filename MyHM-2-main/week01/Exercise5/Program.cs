using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Xml.XPath;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome!");
        string name = UserName();
        int Rnumber = Num1();
        int square = CalculateSquare(Rnumber);
        Result(name, square);


    }
    static string UserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();

    }
    static int Num1()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());

    }
    static int CalculateSquare(int number)
    {
        return number * number;
    }
    static void Result(string name, int square)
    {
        Console.WriteLine($"{name}, Your squared favorite number is {square}");
    }
}