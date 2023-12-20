namespace 有效的字母异位词
{
    internal class Program
    {
        #region 问题描述
        /*给定两个字符串 s 和 t ，编写一个函数来判断 t 是否是 s 的字母异位词。
         * 示例 1: 输入: s = "anagram", t = "nagaram" 输出: true
         * 示例 2: 输入: s = "rat", t = "car" 输出: false
         * 说明: 你可以假设字符串只包含小写字母。
         */
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static bool Solution(string s,string t)
        {
            if (s.Length!=t.Length) 
            {
                return false;
            }
            //记录各个字母出现的次数，在t中出现++，在i中出现--，最后==0说明完全抵消

            int[] record= new int[26];
            for (int i=0; i<s.Length;i++)
            {
                //26个字母减去第一个‘a’,数值必定落在26以内
                record[t[i] -'a']++;
                record[s[i] -'a']--;
            }
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i]!=0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}