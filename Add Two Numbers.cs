//You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

//You may assume the two numbers do not contain any leading zero, except the number 0 itself.



//Example 1:

//Input: l1 = [2,4,3], l2 = [5,6,4]
//Output: [7,0,8]
//Explanation: 342 + 465 = 807.

//Example 2:

//Input: l1 = [0], l2 = [0]
//Output: [0]

//Example 3:

//Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
//Output: [8,9,9,9,0,0,0,1]



//Constraints:

//    The number of nodes in each linked list is in the range [1, 100].
//    0 <= Node.val <= 9
//    It is guaranteed that the list represents a number that does not have leading zeros.

//You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

//You may assume the two numbers do not contain any leading zero, except the number 0 itself.



//Example 1:

//Input: l1 = [2,4,3], l2 = [5,6,4]
//Output: [7,0,8]
//Explanation: 342 + 465 = 807.

//Example 2:

//Input: l1 = [0], l2 = [0]
//Output: [0]

//Example 3:

//Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
//Output: [8,9,9,9,0,0,0,1]



//Constraints:

//    The number of nodes in each linked list is in the range [1, 100].
//    0 <= Node.val <= 9
//    It is guaranteed that the list represents a number that does not have leading zeros.



using System.Text;

namespace Algorithms
{
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

    internal class Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var firstNumber = CreateNumberFromList(l1);
            var secondNumber = CreateNumberFromList(l2);

            var sum = AddTwoBigNumbers(firstNumber, secondNumber);

            ListNode head = null;
            ListNode current = null;

            for(int i = sum.Length - 1; i >= 0; i--)
            {
                var node = new ListNode(int.Parse(sum[i].ToString()));
                if(head == null)
                {
                    head = current = node;
                }
                else
                {
                    current.next = node;
                    current = node;
                }
            }
            return head;
        }

        private string CreateNumberFromList(ListNode l)
        {
            var result = string.Empty;
            var current = l;

            while(current.next != null)
            {
                result += current.val.ToString();
                current = current.next;
            }

            result += current.val.ToString();
            return string.Join("", result.Reverse());
        }

        private string AddTwoBigNumbers(string first, string second)
        {
            int rest = 0;
            int maxLength = Math.Max(first.Length, second.Length);

            var result = new StringBuilder();

            first = first.PadLeft(maxLength, '0');
            second = second.PadLeft(maxLength, '0');

            for (int i = maxLength - 1; i >= 0; i--)
            {
                var firstNumber = first[i] - '0';
                var secondNumber = second[i] - '0';

                var sum = firstNumber + secondNumber + rest;
                rest = sum / 10;

                result.Insert(0, (sum % 10).ToString());
            }

            if (rest > 0)
            {
                result.Insert(0, rest.ToString());
            }

            return result.ToString();
        }
    }
}
