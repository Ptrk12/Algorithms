namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Two_Sum_II___Input_Array_Is_Sorted res = new Two_Sum_II___Input_Array_Is_Sorted();

            //var test = res.TwoSum(new int[] { 0,0,3,4 }, 0);

            //Console.WriteLine();

            //Sum3 res = new Sum3();

            //var test = res.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });

            //Console.WriteLine();

            //Set_Matrix_Zeroes sol = new Set_Matrix_Zeroes();

            //sol.SetZeroes(new int[][] { [1, 2, 3, 4], [5, 0, 7, 8], [0, 10, 11, 12], [13, 14, 15, 0]});

            //Group_Anagrams res = new Group_Anagrams();

            //var ress = res.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

            //Longest_Substring_Without_Repeating_Characters res = new Longest_Substring_Without_Repeating_Characters();

            //var ressult = res.LengthOfLongestSubstring("aaa");

            //Console.WriteLine(ressult);

            //Sum3 sum = new Sum3();

            //var res = sum.ThreeSum(new int[] { -2, 0, 1, 1, 2});

            //Longest_Palindromic_Substring res = new Longest_Palindromic_Substring();

            //var result = res.LongestPalindrome("bb");

            //Console.WriteLine(result);
            //Increasing_Triplet_Subsequence result = new Increasing_Triplet_Subsequence();

            //var resultt = result.IncreasingTriplet(new int[] {2,4,-2,-3,});
            //Console.WriteLine(resultt);

            ListNode l11 = new ListNode(4);
            ListNode l12 = new ListNode(1);
            ListNode l13 = new ListNode(8);
            ListNode l14 = new ListNode(4);

            l11.next = l12;
            l12.next = l13;
            l13.next = l14;

            ListNode l21 = new ListNode(5);
            ListNode l22 = new ListNode(6);
            ListNode l23 = new ListNode(1);
            ListNode l24 = new ListNode(8);
            ListNode l25 = new ListNode(4);

            l21.next = l22;
            l22.next = l23;
            l23.next = l24;
            l24.next = l25;

            //Add_Two_Numbers res = new Add_Two_Numbers();

            //res.AddTwoNumbers(l11, l21);

            Intersection_of_Two_Linked_Lists result = new Intersection_of_Two_Linked_Lists();
            var res =result.GetIntersectionNode(l11, l21);
            Console.WriteLine();

        }
    }
}
