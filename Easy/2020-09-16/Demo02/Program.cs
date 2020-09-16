using System.Collections.Generic;
using System;
using System.Linq;
/*
给定一个非负整数数组 A，返回一个数组，在该数组中， A 的所有偶数元素之后跟着所有奇数元素。
*/
namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3363, 4833, 290, 3381, 4227, 1711, 1253, 2984, 2212, 874, 2358, 2049, 2846, 2543, 1557, 1786, 4189, 1254, 2803, 62, 3708, 1679, 228, 1404, 1200, 4766, 1761, 1439, 1796, 4735, 3169, 3106, 3578, 1940, 2072, 3254, 7, 961, 1672, 1197, 3187, 1893, 4377, 2841, 2072, 2011, 3509, 2091, 3311, 233 };
            Solution s = new Solution();
            Console.WriteLine($"[{string.Join(",", s.SortArrayByParity(A))}]");
        }
    }

    public class Solution
    {
        public int[] SortArrayByParity(int[] A)
        {
            List<int> nums = new List<int>(A);

            var even = nums.Where(x => x % 2 == 0);
            var odd = nums.Where(x => x % 2 != 0);
            
            return even.Concat(odd).ToArray();
        }
    }
}
