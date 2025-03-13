using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<string> write1_list = new List<string>(); // Saves entries
    static void Main()
    {
        while (true)
        {
            // Displays the menu
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Your choice: ");
            
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice)) 
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }

            // Calls chosen function
            if (choice == 1)
            {
                WriteEntry();
            }
            else if (choice == 2)
            {
                DisplayEntries();
            }
            else if (choice == 3)
            {
                LoadEntries();
            }
            else if (choice == 4)
            {
                SaveEntries();
            }
            else if (choice == 5)
            {
                QuitProgram();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
            }
        }
    }

    // FUNCTIONS
    
    static void WriteEntry()
    {
        Console.WriteLine("What would you like to write?");
        string entry = Console.ReadLine();
        write1_list.Add(entry);
        Console.WriteLine("Entry added.");
    }

    static void DisplayEntries()
    {
        Console.WriteLine("\nJournal Entries:");
        DateTime current_time = DateTime.Now;
        string date_data = current_time.ToShortDateString();

        if (write1_list.Count == 0)
        {
            Console.WriteLine("No entries yet.");
        }
        else
        {
            foreach (string entry in write1_list)
            {
                Console.WriteLine($"{date_data} - {entry}");
            }
        }
        Console.WriteLine();
    }

    static void LoadEntries()
    {
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            write1_list = new List<string>(File.ReadAllLines(filename));
            Console.WriteLine("Entries loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    static void SaveEntries()
    {
        Console.Write("Enter the filename to save: ");
        string filename = Console.ReadLine();
        
        File.WriteAllLines(filename, write1_list);
        Console.WriteLine("Entries saved successfully.");
    }

    static void QuitProgram()
    {
        Console.WriteLine("Exiting program...");
        Environment.Exit(0);
    }
}
