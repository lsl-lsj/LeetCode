using System;
using System.Collections.Generic;
/*
    给你一个数组 nums 。数组「动态和」的计算公式为：runningSum[i] = sum(nums[0]…nums[i]) 。
    请返回 nums 的动态和。
*/
namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            Solution s = new Solution();
            var sums = s.RunningSum(nums);

            Console.WriteLine(string.Join(",", sums));
        }
    }

    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            int sum = 0;
            List<int> sums = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                sums.Add(sum);
            }

            return sums.ToArray();
        }
    }
}
