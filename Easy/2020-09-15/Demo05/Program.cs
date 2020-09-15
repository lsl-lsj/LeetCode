using System;
/*
    给你一个有效的 IPv4 地址 address，返回这个 IP 地址的无效化版本。
    所谓无效化 IP 地址，其实就是用 "[.]" 代替了每个 "."。
*/
namespace Demo05
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.DefangIPaddr("1.1.1.1"));
        }
    }

    public class Solution
    {
        public string DefangIPaddr(string address) => address.Replace(".", "[.]");
    }
}
