using System;

public class  Job//CLASS
{
    //ATTRIBUTES
    public string Job_Title;
    public string Company;
    public int Start_Year;
    public int End_Year;

    public void Display() //FUNCTON
    {
        Console.WriteLine($"{Job_Title}, {Company}, {Start_Year}, {End_Year}");
    }


}
