using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            int sum = CalculateDigitSum(input);
            Console.WriteLine("Sum of digits: " + sum);
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
    }

    static int CalculateDigitSum(string numberStr)
    {
        int sum = 0;
        foreach (char digit in numberStr)
        {
            sum += digit - '0'; // Convert char to int
        }
        return sum;
    }
}   