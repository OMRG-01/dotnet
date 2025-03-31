using System;
using MyOperationsLibrary;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int den = Convert.ToInt32(Console.ReadLine());

            int result = MyOperations.Divide(num, den);
            Console.WriteLine("Result: " + result);
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine("Custom Exception Caught: " + ex);
        }

        try
        {
            int[] numbers = { 10, 20, 30, 40, 12, 10 };
            Console.Write("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            int value = MyOperations.GetArrayElement(numbers, index);
            Console.WriteLine("Value at index: " + value);
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine("Custom Exception Caught: " + ex);
        }
    }
}
