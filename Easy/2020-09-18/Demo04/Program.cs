using System;
/*
    给你一个整数数组 nums 。
    如果一组数字 (i,j) 满足 nums[i] == nums[j] 且 i < j ，就可以认为这是一组 好数对 。
    返回好数对的数目。
*/
namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 1 };
            Solution s = new Solution();
            Console.WriteLine(s.NumIdenticalPairs(nums));
        }
    }

    public class Solution
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                for (int j = i + 1; j < nums.Length; ++j)
                {
                    if (nums[i] == nums[j])
                        count++;
                }
            }

            return count;
        }
    }
}
