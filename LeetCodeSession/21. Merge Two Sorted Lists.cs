using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSession
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            //check if either list is null
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            //compare the values of the nodes in both lists
            if (list1.val < list2.val)
            {
                //if list1's value is less than list2's value, set list1's next to the result of merging the rest of list1 with list2
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                //if list2's value is less than or equal to list1's value, set list2's next to the result of merging list1 with the rest of list2
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
    }
}
