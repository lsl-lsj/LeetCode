using System.Collections.Generic;
using System;
/*
    给你一个整数 n，请你帮忙计算并返回该整数「各位数字之积」与「各位数字之和」的差。
*/
namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.SubtractProductAndSum(4421));
        }
    }

    public class Solution
    {
        public int SubtractProductAndSum(int n)
        {
            int product = 1, sum = 0, length = n.ToString().Length;

            for (int i = 1; i < length + 1; ++i)
            {
                int x = n % 10;

                product *= x;
                sum += x;

                n = n / 10;
            }

            return product - sum;
        }
    }
}
