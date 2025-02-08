using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeSession
{
    internal class ZigZagConversion
    {
        //The string "PAYPALISHIRING" is written in a zigzag pattern on a
        //given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

        //P   A   H   N
        //A P L S I I G
        //Y   I   R

        //And then read line by line: "PAHN APLSIIG YIR" "PAHNA IIYIPGLSR"
        //Write the code that will take a string and make this conversion given a number of rows:

        public string Convert(string s, int numRows)
        {
            //if the number of rows is less than or equal to 1
            //or the string length is less than or equal to the number of rows
            //then you the string is already in the correct format
            if (numRows <= 1 || s.Length <= numRows)
            {
                return s;
            }

            var dict = new List<StringBuilder>();
            for (int i = 0; i < numRows; i++)
            {
                dict.Add(new StringBuilder());
            }

            var currentRow = 0;
            var down = false;

            foreach (var row in s)
            {
                //if (currentRow >= dict.Count)
                //{
                //    break;
                //}

                dict[currentRow].Append(row);
                if (currentRow == 0 || currentRow == numRows - 1)
                {
                    down = !down;
                }

                if (down)
                {
                    currentRow++;
                }
                else
                {
                    currentRow--;
                }
            }

            var actualString = new StringBuilder();
            foreach (var row in dict)
            {
                actualString.Append(row);
            }

            return actualString.ToString();
        }
    }
}
