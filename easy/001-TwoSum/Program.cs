using System;
using leetcode.csharp.easy.UmTwoSum;

namespace leetcode.csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando TwoSum
            TwoSum solution = new TwoSum();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = solution.TwoSumMethod(nums, target);
            Console.WriteLine($"Resultado: [{result[0]}, {result[1]}]");
            Console.WriteLine(
                $"A soma de nums[{result[0]}] + nums[{result[1]}] = {nums[result[0]]} + {nums[result[1]]} = {target}"
            );
        }
    }
}
