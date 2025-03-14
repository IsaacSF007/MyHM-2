using System;

public class Resume
{
    public string _UserName;
    public List<Job> Jobs_List = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{_UserName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in Jobs_List)
        {
            job.Display();
        }
    }
}
