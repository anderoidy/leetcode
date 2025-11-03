using System;
using PalindromeNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Solution PalindromeNumber = new Solution();
        //int result = PalindromeNumber.Palindrome.IsPalindrome(121);
        Console.WriteLine(PalindromeNumber.IsPalindrome(121));
        Console.WriteLine(PalindromeNumber.IsPalindrome(123));
    }
}
