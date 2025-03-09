using System;
using System.Diagnostics.CodeAnalysis;
List <int> number1 = new List<int>();

while (true)
{
    Console.WriteLine("Write a number (0 to stop)");
    string userNum = Console.ReadLine();
    int number2 = int.Parse(userNum);
    if (number2 == 0)
    {
        break;
    }
   number1.Add(number2);
}
if (number1.Count > 0)
{
    var sum = number1.Sum();
    var largest = number1.Max();
    var average = number1.Average();
    Console.WriteLine("The sum of the number is: " + sum);
    Console.WriteLine("And the Average number is " + average);
    Console.WriteLine("And the largest number was " + largest);
}
else
{
    Console.WriteLine("No numbers were added to the list");
}

