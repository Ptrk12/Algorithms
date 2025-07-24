namespace Algorithms
{
    internal class Sum3
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();

            for(int i =0;i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[right] + nums[left];

                    if(sum == 0)
                    {
                        result.Add(new List<int>() { nums[i], nums[right], nums[left] });
                        right--;
                        left++;
                        while (right > 0 &&right < nums.Length && nums[right] == nums[right + 1])
                            right--;
                        while (left < nums.Length && left > 0 && nums[left] == nums[left - 1])
                            left++;
                    }
                    else if(sum > 0)
                    {
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                }
            }
            return result;
        }
    }
}
