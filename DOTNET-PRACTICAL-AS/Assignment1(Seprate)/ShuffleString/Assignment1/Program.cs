using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) | input.Length < 2)
        {
            Console.WriteLine("String must have at least two characters.");
        }
        else
        {
            string shuffledString = ShuffleFirstLast(input);
            Console.WriteLine("Shuffled string: " + shuffledString);
        }
    }

    static string ShuffleFirstLast(string str)
    {
        char[] charArray = str.ToCharArray();
        char temp = charArray[0];
        charArray[0] = charArray[^1];
        charArray[^1] = temp;

        return new string(charArray);
    }
}
