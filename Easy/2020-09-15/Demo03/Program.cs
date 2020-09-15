using System;
/*
    给你两个整数，n 和 start 。
    数组 nums 定义为：nums[i] = start + 2*i（下标从 0 开始）且 n == nums.length 。
    请返回 nums 中所有元素按位异或（XOR）后得到的结果。
*/
namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.XorOperation(5, 0));
        }
    }

    public class Solution
    {
        public int XorOperation(int n, int start)
        {
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result ^= start + i * 2;
            }

            return result;
        }
    }
}
