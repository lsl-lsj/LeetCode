using System.Linq;
using System;
using System.Collections.Generic;
/*
    给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。
    如果反转后整数溢出那么就返回 0。
*/
namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.Reverse(-321));
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            try
            {
                if (x < 0)
                {
                    x = Math.Abs(x);
                    return -GetNum(x);
                }

                return GetNum(x);
            }
            catch
            {
                return 0;
            }
        }

        public int GetNum(int x)
        {
            var nums = x.ToString().ToList();
            nums.Reverse();
            return Int32.Parse(string.Join("", nums));
        }
    }
}
