//Given a string s, return the longest palindromic substring in s.

 

//Example 1:

//Input: s = "babad"
//Output: "bab"
//Explanation: "aba" is also a valid answer.

//Example 2:

//Input: s = "cbbd"
//Output: "bb"




//Constraints:

//1 <= s.length <= 1000
//    s consist of only digits and English letters.



namespace Algorithms
{
    internal class Longest_Palindromic_Substring
    {
        private bool IsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        public string LongestPalindrome(string s)
        {
            var result = string.Empty;

            if(s.Length == 1)
            {
                return s;
            }

            for(int i = 0;i<s.Length;i++)
            {
                for(int j = i+1;j<s.Length+1;j++)
                {
                    var substring = s.Substring(i, j - i);
                    if (IsPalindrome(substring))
                    {
                        if(substring.Length > result.Length)
                        {
                            result = substring;
                        }
                    }
                }
            }
            return result;
        }
    }
}
