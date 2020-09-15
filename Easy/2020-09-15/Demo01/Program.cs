using System;

/*
    字符串的左旋转操作是把字符串前面的若干个字符转移到字符串的尾部。请定义一个函数实现字符串左旋转操作的功能。
    比如，输入字符串"abcdefg"和数字2，该函数将返回左旋转两位得到的结果"cdefgab"。。
*/
namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string str = s.ReverseLeftWords("abcdef1123  3213", 5);
            Console.Write(str);
        }
    }

    public class Solution
    {
        public string ReverseLeftWords(string s, int n)
        {
            return s.Remove(0, n) + s.Substring(0, n);
        }
    }
}