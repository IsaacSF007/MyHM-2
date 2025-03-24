using System;
using System.Collections.Generic;

class References
{
    private string book;
    private int chapter;
    private int start_verse;
    private int end_verse;

    public References(string book, int chapter, int verse) //For 1 verse
    {
        this.book = book;
        this.chapter = chapter;
        this.start_verse = verse;
        this.end_verse = verse;
    }
    public References (string book, int chapter, int start_verse, int end_verse)//For 2 or more verses
    {
        this.book = book;
        this.chapter = chapter;
        this.start_verse = start_verse;
        this.end_verse = end_verse;
    }
    public string GetScripture()
    {
        return start_verse == end_verse
        ? $"{book} {chapter}:{start_verse}"
        : $"{book} {chapter}:{start_verse}-{end_verse}";
    }
}

//Class for hidden words
class Word
{
    private string text;
    private bool hidden;

    public Word (string text)
    {
        this.text = text;
        this.hidden = false;
    }        
    //functions
    public void Hide()
    {
        hidden = true;
    }
    public string GetWord()
    {
        return hidden ? new string('_', text.Length) : text;
    }
}

class Scriptures
{
    private string reference;//Contains scripture
    private List<Word> words;//List with each word of the verse
    private Random random = new Random();
    //Constructor
    public Scriptures(string reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();//Splits the verse by spaces, adding word by word
        foreach (string w in text.Split(" "))
        {
            words.Add(new Word(w));
        }
    }

    //Methods
    public void Display()//Displays using the info from references
    {
        Console.Clear();
        Console.WriteLine(reference);
        foreach (Word word in words)
        {
            Console.Write(word.GetWord() + " ");
        }
        Console.WriteLine();
    }

    public void HideWords()//Hides words
    {
        if (words.Count == 0) return;
        int index = random.Next(words.Count);//Gets a random number
        words[index].Hide();//Hides it getting the length of the word and replacing with "_"
    }
    public bool AllHidden
    {
        get
        {
            foreach (Word word in words)
            {
                if (word.GetWord() != new string('_', word.GetWord().Length))
                {
                    return false;
                }
            } 
            return true;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        References reference = new References("Philippians", 4, 13);
        string text = "I can do all things through Christ which strengtheneth me.";
        Scriptures scripture = new Scriptures(reference.GetScripture(), text);
        scripture.Display();

        while (true)
        {
            Console.WriteLine("Press Enter to hide words or write 'quit' to exit");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            scripture.HideWords();
            scripture.Display();
            if (scripture.AllHidden)
            {
                Console.WriteLine("All words have been hidden.");
                break;
            }
        }
    }
}