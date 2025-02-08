using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace LeetCodeSession
{
    public class Container_With_Most_Water
    {
        //You are given an integer array height of length n.
        //There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and(i, height[i]).
        //Find two lines that together with the x-axis form a container, such that the container contains the most water.
        //Return the maximum amount of water a container can store.
        //Notice that you may not slant the container.
        public int MaxArea(int[] height)
        {
            var leftHeight = 0;
            var Width = height.Length;
            var rightHeight = 0;
            var curArea = 0;
            var maxArea = 0;

            for (var i = 0; i < height.Length; i++)
            {
                for (var j = height.Length - 1; j != i; j--)
                {
                    leftHeight = height[i];
                    rightHeight = height[j];
                    Width = j - i;

                    if (i == 0 && j == height.Length - 1)
                    {
                        maxArea = Math.Min(leftHeight, rightHeight) * Width;
                    }

                    curArea = Math.Min(leftHeight, rightHeight) * Width;

                    if (maxArea < curArea)
                    {
                        maxArea = curArea;
                    }

                    if (height[i] < height[j])
                    {
                        break;
                    }
                }
            }
            return maxArea;
        }
    }
}

