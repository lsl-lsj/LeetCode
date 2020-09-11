using System.Linq;
using System;
/*
    判断一个整数是否是回文数。
    回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
*/
namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.IsPalindrome(-23124124));
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var num = x.ToString().ToList();
            num.Reverse();

            if (x == Convert.ToInt64(string.Join("", num)))
            {
                return true;
            }

            return false;
        }
    }
}
