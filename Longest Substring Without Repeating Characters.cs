

namespace Algorithms
{
    internal class Longest_Substring_Without_Repeating_Characters
    {
        public string LengthOfLongestSubstring(string s)
        {
            var result = string.Empty;

            if(string.IsNullOrEmpty(s))
            {
                return result;
            }

            HashSet<char> chars = new HashSet<char>();
            int slow = 0;
            int maxL = 0;
            
            for(int fast = 0; fast < s.Length; fast++)
            {
                while (chars.Contains(s[fast]))
                {
                    chars.Remove(s[slow]);
                    slow++;
                }

                chars.Add(s[fast]);

                var current = maxL;
                maxL = Math.Max(maxL,fast-slow+ 1);

                if(current != maxL)
                {
                    result = s.Substring(slow, maxL);
                }           

            }

            return result;
        }
    }
}
