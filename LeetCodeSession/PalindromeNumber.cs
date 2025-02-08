using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSession
{
    internal class Palindrome_Number
    {
        //Given an integer x, return true if x is a palindrome, and false otherwise.
        //we know that negative numbers are not palindromes
        //we know that numbers that end with 0 are not palindromes
        //we know that numbers that are palindromes have the same digits when reversed
        //we can convert the number to a string and check if the string is a palindrome
        //we can also reverse the number and check if the reversed number is the same as the original number
        //here we just check left side with ending side, if they match then it is a palindrome else it is not
        public bool IsPalindrome(int x)
        {
            var palidrome = x.ToString();

            for (int i = 0; i < palidrome.Length / 2; i++)
            {
                if (palidrome[i] != palidrome[palidrome.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
