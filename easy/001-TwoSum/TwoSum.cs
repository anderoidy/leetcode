using System;
using System.Collections.Generic;

namespace leetcode.csharp.easy.UmTwoSum
{
    public class TwoSum
    {
        public int[] TwoSumMethod(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                    return new int[] { map[complement], i };

                map[nums[i]] = i;
            }

            throw new ArgumentException("No two sum solution");
        }
    }
}
