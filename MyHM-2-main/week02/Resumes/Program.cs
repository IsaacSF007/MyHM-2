using System;

class  Program
{
    static void Main(string[] args)
    {
        //ASSING INFO TO THE ATTRIBUTES FROM JOBS
        Job Job_1 = new Job();
        Job_1.Job_Title = "Software Engineer";
        Job_1.Company = "Microsoft";
        Job_1.Start_Year = 2019;
        Job_1.End_Year = 2020;

        Job Job_2 = new Job();
        Job_2.Job_Title = "Manager";
        Job_2.Company = "Apple";
        Job_2.Start_Year = 2022;
        Job_2.End_Year = 2023;
        //CALLS RESUME, ASSING THE VALUE OF _UserName AND ADDS THE INFO FROM THE JOBS ATTRIBUTES, CALLS A FUNCTION TO DISPLAY
        Resume User_Resume = new Resume();
        User_Resume._UserName = "Allison Rose";

        User_Resume.Jobs_List.Add(Job_1);
        User_Resume.Jobs_List.Add(Job_2);
        User_Resume.Display();
    }
}