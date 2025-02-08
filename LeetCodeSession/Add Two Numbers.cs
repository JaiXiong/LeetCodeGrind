using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace LeetCodeSession
{
    internal class Add_Two_Numbers
    {
        //You are given two non-empty linked lists representing two non-negative integers.
        //The digits are stored in reverse order, and each of their nodes contains a single digit.
        //Add the two numbers and return the sum as a linked list.

        //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        //Input: l1 = [2, 4, 3],
        //       l2 = [5, 6, 4]
        //Output: [7, 0, 8]
        //Explanation: 342 + 465 = 807

        //Example 2:

        //Input: l1 = [0], l2 = [0]
        //Output: [0]
        //Example 3:

        //Input: l1 = [9, 9, 9, 9, 9, 9, 9],
        //       l2 = [9, 9, 9, 9]
        //Output:     [8, 9, 9, 9, 0, 0, 0, 1]

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var list0 = new ListNode(0);    
            var list1 = l1;
            var list2 = l2;
            var output = list0;
            var carryover = 0;

            while (list1 != null || list2 != null)
            {
                var result1 = 0;
                var result2 = 0;

                if (list1 != null)
                {
                    result1 = list1.val;
                }
                else
                {
                    result1 = 0;
                }

                if (list2 != null) 
                {
                    result2 = list2.val;
                }
                else
                {
                    result2 = 0;
                }
                var sum = result1 + result2 + carryover;
                carryover = sum / 10;

                output.next = new ListNode(sum % 10);
                
                list1 = list1?.next;
                list2 = list2?.next;
            }

            if (carryover > 0)
            {
                output.next = new ListNode(carryover);
            }

            return list0.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

//        var l1l2val = 0;
//        var output = new ListNode(0);

//            while (l1 != null)
//            {
//                if (l2 != null)
//                {
//                    l1l2val = l1.val + l2.val;
//                    if (l1l2val >= 10)
//                    {
//                        output.val = l1l2val - 10;
//                        output = output.next;

//                        l1 = l1.next;
//                        l1.val = l1.val + 1;
//                        l2 = l2.next;
//                    }
//}
//                else
//{
//    l1l2val = l1.val;
//    if (l1l2val >= 10)
//    {
//        output.val = l1l2val - 10;
//        output = output.next;

//        l1 = l1.next;
//        l1.val = l1.val + 1;
//    }
//}
//            }
//            return output;
//        }
}

