using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSession
{
    internal class LengthOfLongestSubstring
    {
        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {
                /* 
                 * Given a string s, find the length of the longest substring without repeating characters.
                 Create a list to store the characters
                    Create a variable to store the maximum length
                    Loop through the string
                        If the character is not in the list
                            Add the character to the list
                            Update the maximum length
                        Else
                            Remove the first character from the list
                            Add the character to the list
                            //why does this work?
                            //why do we need to remove the first character?
                            //because as we added new chars, we need to remove the first char to make sure we have the longest substring
                            //the first char is the oldest char in the list, else the other chars would have been removed
                    Return the maximum length
                 */
                var answer = new List<char>();
                var maxLength = 0;

                foreach (var item in s)
                {
                    if (!answer.Contains(item))
                    {
                        answer.Add(item);
                        maxLength = Math.Max(maxLength, answer.Count);
                    }
                    else 
                    {
                        while(answer.Contains(item))
                        {
                            answer.RemoveAt(0);
                        }
                        answer.Add(item);
                    }
                }
                return maxLength;
            }
        }
    }
}
