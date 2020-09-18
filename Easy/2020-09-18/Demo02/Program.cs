using System;
using System.Collections.Generic;
using System.Linq;
/*
    给你一个数组 nums，对于其中每个元素 nums[i]，请你统计数组中比它小的所有数字的数目。
    换而言之，对于每个 nums[i] 你必须计算出有效的 j 的数量，其中 j 满足 j != i 且 nums[j] < nums[i] 。
    以数组形式返回答案。
*/
namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] nums = { 8, 1, 2, 2, 3 };
            Console.WriteLine($"[{string.Join(",", s.SmallerNumbersThanCurrent(nums))}]");
        }
    }

    public class Solution
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            List<int> result = new List<int>();

            foreach (var item in nums)
            {
                result.Add(nums.Count(num => num < item));
            }

            return result.ToArray();
        }
    }
}
