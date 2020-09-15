using System;
/*
    给你一个正方形矩阵 mat，请你返回矩阵对角线元素的和。
    请你返回在矩阵主对角线上的元素和副对角线上且不在主对角线上元素的和。
*/
namespace Demo07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat = {  new int[] {1, 2, 3},
                            new int[]{4, 5, 6},
                            new int[]{7, 8, 9}
                         };
            Solution s = new Solution();

            Console.WriteLine(s.DiagonalSum(mat));
        }
    }

    public class Solution
    {
        public int DiagonalSum(int[][] mat)
        {
            int sum = 0, n = mat.Length, mid = n >> 1;
            for (int i = 0, j = n - 1; i < n; i++, j--)
            {
                sum += mat[i][i] + mat[i][j];
            }
            return n % 2 == 0 ? sum : sum - mat[mid][mid];
        }
    }
}
