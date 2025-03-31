using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        try
        {
            double number = Convert.ToDouble(Console.ReadLine());

            if (number < 0)
                throw new ArgumentException("Cannot calculate square root of a negative number.");

            double sqrt = Math.Sqrt(number);
            Console.WriteLine("Square root: " + sqrt);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
