using System;
using System.Linq;
/*
    给定字符串J 代表石头中宝石的类型，和字符串 S代表你拥有的石头。 
    S 中每个字符代表了一种你拥有的石头的类型，你想知道你拥有的石头中有多少是宝石。
    J 中的字母不重复，J 和 S中的所有字符都是字母。字母区分大小写，因此"a"和"A"是不同类型的石头。
*/
namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.NumJewelsInStones("zZ", "ZZZZ"));
        }
    }

    public class Solution
    {
        /* public int NumJewelsInStones(string J, string S)
        {
            var gemstone = J.ToCharArray();
            var stone = S.ToCharArray();
            int count = 0;

            return count = (from a in gemstone
                            join b in stone on a equals b
                            select ++count).LastOrDefault(); // 如果使用count++ 则count默认值为1

        } */

        public int NumJewelsInStones(string J, string S) => S.Count(x => J.Contains(x));
    }
}
