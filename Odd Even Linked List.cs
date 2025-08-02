﻿//Given the head of a singly linked list, group all the nodes with odd indices together followed by the nodes with even indices, and return the reordered list.

//The first node is considered odd, and the second node is even, and so on.

//Note that the relative order inside both the even and odd groups should remain as it was in the input.

//You must solve the problem in O(1) extra space complexity and O(n) time complexity.



//Example 1:

//Input: head = [1,2,3,4,5]
//Output: [1,3,5,2,4]

//Example 2:

//Input: head = [2,1,3,5,6,4,7]
//Output: [2,3,6,7,1,5,4]



//Constraints:

//    The number of nodes in the linked list is in the range [0, 104].
//    -106 <= Node.val <= 106

//Given the head of a singly linked list, group all the nodes with odd indices together followed by the nodes with even indices, and return the reordered list.

//The first node is considered odd, and the second node is even, and so on.

//Note that the relative order inside both the even and odd groups should remain as it was in the input.

//You must solve the problem in O(1) extra space complexity and O(n) time complexity.



//Example 1:

//Input: head = [1,2,3,4,5]
//Output: [1,3,5,2,4]

//Example 2:

//Input: head = [2,1,3,5,6,4,7]
//Output: [2,3,6,7,1,5,4]



//Constraints:

//    The number of nodes in the linked list is in the range [0, 104].
//    -106 <= Node.val <= 106



namespace Algorithms
{
    internal class Odd_Even_Linked_List
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return null;

            ListNode evenHead = head;
            ListNode currentEven = head;
            ListNode oddHead = head.next;
            ListNode currentOdd = head.next;

            while (currentEven != null && currentOdd != null)
            {
                if(currentEven.next.next != null)
                {
                    currentEven.next = currentEven.next.next;
                    currentEven = currentEven.next;
                }
                else
                {
                    currentEven.next = null;
                }

                if(currentOdd.next != null && currentOdd.next.next != null)
                {
                    currentOdd.next = currentOdd.next.next;
                    currentOdd = currentOdd.next;
                }
                else
                {
                    currentOdd.next = null;
                }


                if(currentEven.next == null)
                {
                    currentEven.next = oddHead;
                    break;
                }
            }

            return evenHead;
        }
    }
}
