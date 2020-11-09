﻿using System;

// 给你一个 n 行 m 列的矩阵，最开始的时候，每个单元格中的值都是 0。
// 另有一个索引数组 indices，indices[i][j] = [[ri, ci]] 中的 ri 和 ci 分别表示指定的行和列（从 0 开始编号）。
// 你需要将每对 [ri, ci] 指定的行和列上的所有单元格的值加 1。
// 请你在执行完所有 indices 指定的增量操作后，返回矩阵中 「奇数值单元格」 的数目。
// 示例：
//     输入：n = 2, m = 3, indices = [[0,1],[1,1]]
//     输出：6
//     解释：最开始的矩阵是 [[0,0,0],[0,0,0]]。
//     第一次增量操作后得到 [[1,2,1],[0,1,0]]。
//     最后的矩阵是 [[1,3,1],[1,3,1]]，里面有 6 个

namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var indices = new int[][] { new int[] { 0, 1 }, new int[] { 1, 1 } };

            // foreach (var item in indices)
            // {
            //     Console.WriteLine("行：{0} , 列：{1}", item[0], item[1]);
            // }
            // int[,] array = new int[2, 3];
            // Console.WriteLine("行：{0} , 列：{1}", array.GetLength(0), array.GetLength(1));
            s.OddCells(2, 3, indices);
        }
    }

    public class Solution
    {
        public int OddCells(int n, int m, int[][] indices)
        {
            int count = 0;
            int[,] array = new int[n, m];
            foreach (var item in indices)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    array[item[0], i]++;
                }
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    array[i, item[1]]++;
                }
            }

            foreach (var item in array)
            {
                if (item % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
