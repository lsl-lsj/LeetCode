using System;
/*
    桌上有 n 堆力扣币，每堆的数量保存在数组 coins 中。
    我们每次可以选择任意一堆，拿走其中的一枚或者两枚，求拿完所有力扣币的最少次数。
*/
namespace Demo06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int MinCount(int[] coins)
        {
            int sum = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                sum += (coins[i] + 1) / 2;
            }

            return sum;
        }
    }
}
