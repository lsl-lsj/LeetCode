using System;
using System.Collections.Generic;
/*
    给你一个数组 nums ，数组中有 2n 个元素，按 [x1,x2,...,xn,y1,y2,...,yn] 的格式排列。
    请你将数组按 [x1,y1,x2,y2,...,xn,yn] 格式重新排列，返回重排后的数组。
*/
namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] test = { 3, 4, 5, 6, 7, 8, 1, 23 };
            Console.WriteLine($"[{string.Join(",", s.Shuffle(test, 4))}]");
        }
    }

    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            List<int> list = new List<int>();

            int[] first = new int[n];
            int[] second = new int[n];

            Array.Copy(nums, first, n);
            Array.Copy(nums, n, second, 0, n);

            for (int i = 0; i < n; i++)
            {
                list.Add(first[i]);
                list.Add(second[i]);
            }

            return list.ToArray();
        }
    }
}
