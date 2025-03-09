using System;
using System.Diagnostics.Tracing;
Random NumberF = new Random();
int NumberR = NumberF.Next(1,101);
int numberGuess = -1;

while (numberGuess != NumberR)
{
    Console.Write("What is the magic number?");
    numberGuess = int.Parse(Console.ReadLine());
    if (numberGuess < NumberR)
    {
        Console.WriteLine("Try a higher number");
    }
    else if (numberGuess > NumberR)
    {
        Console.WriteLine("Try a lower number");
    }
    else if (numberGuess == NumberR)
    {
        Console.WriteLine("You guessed it!");
    }
}