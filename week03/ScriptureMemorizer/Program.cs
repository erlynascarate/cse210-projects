// Stretch Challenge: Hide randomly from only those words that are not already hidden.
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("D&C", 78, 19);
        Scripture scripture = new Scripture(reference, "And he who receiveth all things with thankfulness shall be made glorious; and the things of this earth shall be added unto him, even an hundred fold, yea, more.");
        
        string quit;
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            quit = Console.ReadLine();
            scripture.HideRandomWords(3);
        } while(quit != "quit" && !scripture.IsCompletelyHidden());
        
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}