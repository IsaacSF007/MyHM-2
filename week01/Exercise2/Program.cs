using System;
//Asks user
Console.WriteLine("Please enter your grade percentage: ");
string gradePercentage = Console.ReadLine();
int gradeP = int.Parse(gradePercentage);
//Else... If Statements below
if (gradeP >= 90)
{
    Console.WriteLine("Your grade is A");
}
else if (gradeP >= 80)
{
    Console.WriteLine("Your grade is B");
}
else if (gradeP >= 70)
{
    Console.WriteLine("Your grade is C");
}
else if (gradeP >= 60)
{
    Console.WriteLine("Your grade is D");
}
else
{
    Console.WriteLine("Your grade is F");
}