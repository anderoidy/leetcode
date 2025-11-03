using System;

namespace TheTwoSneakyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 3, 2, 1, 3, 2 };
            int[] result = Solution.GetSneakyNumbers(nums);

            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }
    }

    public class Solution
    {
        public static int[] GetSneakyNumbers(int[] nums)
        {
            int[] result = new int[2];
            int k = 0;

            for (int i = 0; i < nums.Length && k < 2; i++)
                for (int j = i + 1; j < nums.Length && k < 2; j++)
                    if (nums[i] == nums[j])
                        result[k++] = nums[i];

            return result;
        }
    }
}
