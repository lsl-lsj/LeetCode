using System;

// 给你一个仅由数字 6 和 9 组成的正整数 num。
// 你最多只能翻转一位数字，将 6 变成 9，或者把 9 变成 6 。
// 请返回你可以得到的最大数字。

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.Maximum69Number(696969));
        }
    }

    public class Solution
    {
        public int Maximum69Number(int num)
        {
            var chars = num.ToString().ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i].Equals('6'))
                {
                    chars[i] = '9';
                    break;
                }
            }
            num = int.Parse(chars);
            return num;
        }
    }
}
