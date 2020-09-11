using System;
using System.Collections.Generic;
using System.Linq;

/*
    找出和为目标值的那 两个 整数，并返回他们的数组下标。

    你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。    
*/
namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] nums = { 2, 5, 6, 3, 6, 4 };
            int target = 9;
            Console.WriteLine(string.Join(",", from a in s.TwoSum(nums, target)
                                               select $"{a}"));
        }
    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result.Add(nums[i]);
                        result.Add(nums[j]);
                        return result.ToArray();
                    }
                }
            }
            return result.ToArray();
        }
    }
}