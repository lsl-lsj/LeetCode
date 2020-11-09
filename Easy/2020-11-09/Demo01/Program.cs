using System;
using System.Linq;

/*
    给定一个二进制矩阵 A，我们想先水平翻转图像，然后反转图像并返回结果。
    水平翻转图片就是将图片的每一行都进行翻转，即逆序。例如，水平翻转 [1, 1, 0] 的结果是 [0, 1, 1]。
    反转图片的意思是图片中的 0 全部被 1 替换， 1 全部被 0 替换。例如，反转 [0, 1, 1] 的结果是 [1, 0, 0]。
    示例：
        输入: [[1,1,0],[1,0,1],[0,0,0]]
        输出: [[1,0,0],[0,1,0],[1,1,1]]
        解释: 首先翻转每一行: [[0,1,1],[1,0,1],[0,0,0]]；
        然后反转图片: [[1,0,0],[0,1,0],[1,1,1]]
*/
namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] test = new int[][] { new int[] { 1 } };
            test = s.FlipAndInvertImage(test);
            foreach (var item in test)
            {
                Console.WriteLine(string.Join(", ", item));
            }
        }
    }

    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                var list = arrays[i].Reverse();
                arrays[i] = list.Select(n =>
                {
                   if(n == 1)
                   {
                       return 0;
                   }
                    return 1;
                }).ToArray();
            }
            return arrays;
        }

        public int[] CustomReverse(int[] array)
        {
            int t = 0;
            int len = array.Length;
            if (len < 2)
            {
                array[0] = array[0] == 1 ? 0 : 1;
            }
            for (int i = 0; i < len / 2; i++)
            {
                int index = len - 1 - i;
                t = array[i];
                array[i] = Xor(array[index]);
                array[index] = Xor(t);

                if (i == len / 2 - 1 && len % 2 != 0)
                {
                    array[i + 1] = Xor(array[i + 1]);
                }
            }
            return array;
        }
        public int Xor(int num)
        {
            return num == 1 ? 0 : 1;
        }
    }
}
