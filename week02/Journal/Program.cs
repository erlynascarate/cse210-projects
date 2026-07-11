using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int option;
        Journal journal = new Journal();
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                {
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    DateTime theCurrentTime = DateTime.Now;

                    Entry entry = new Entry();
                    entry._date = theCurrentTime.ToShortDateString();
                    entry._promptText = prompt;
                    entry._entryText = response;

                    journal.AddEntry(entry);
                    break;
                }
                case 2:
                {
                    journal.DisplayAll();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();

                    journal.LoadFromFile(filename);
                    break;
                }
                case 4:
                {
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();

                    journal.SaveToFile(filename);
                    break;
                }
            }
        } while (option != 5);
    }
}