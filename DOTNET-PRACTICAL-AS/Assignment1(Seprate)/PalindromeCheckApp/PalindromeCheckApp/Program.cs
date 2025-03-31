using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Without recursion
        bool isPalindrome = CheckPalindrome(input);
        Console.WriteLine("Without Recursion: " + (isPalindrome ? "Palindrome" : "Not Palindrome"));

        // With recursion
        bool isPalindromeRecursive = CheckPalindromeRecursive(input, 0, input.Length - 1);
        Console.WriteLine("With Recursion: " + (isPalindromeRecursive ? "Palindrome" : "Not Palindrome"));
    }

    static bool CheckPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right]) return false;
            left++;
            right--;
        }
        return true;
    }

    static bool CheckPalindromeRecursive(string str, int left, int right)
    {
        if (left >= right) return true;
        if (str[left] != str[right]) return false;
        return CheckPalindromeRecursive(str, left + 1, right - 1);
    }
}
