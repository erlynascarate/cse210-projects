using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type your porcentage: ");
        int percentage = int.Parse(Console.ReadLine());

        string letter;
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";

        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("You didn't pass the course. Try it better");
        }

        Console.WriteLine($"Grade: {letter}");
    }
}