using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;
        List<int> numberList = new List<int>();
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (0 != number) numberList.Add(number);
        } while (0 != number);

        int total = 0;
        foreach (int n in numberList)
        {
            total += n;
        }

        float average = ((float)total) / numberList.Count;
        int maxNumber = numberList.Max();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}