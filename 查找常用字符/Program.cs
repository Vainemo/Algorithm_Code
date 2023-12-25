namespace 查找常用字符
{
    internal class Program
    {
        #region 问题描述
        /*给你一个字符串数组 words ，请你找出所有在 words 的每个字符串中都出现的共用字符（ 包括重复字符），并以数组形式返回。你可以按 任意顺序 返回答案。
        示例 1：
        输入：words = ["bella","label","roller"] 输出：["e","l","l"]
        示例 2：
        输入：words = ["cool","lock","cook"] 输出：["c","o"]
         */
        #endregion
        static void Main(string[] args)
        {
            string[] A = { "bella", "label", "roller" };
            List<Char> chars = Solution(A);
            Console.WriteLine("Hello, World!");
        }
        public static List<Char> Solution(string[] words)
        {
            //第一个单词进行初始化
            int[] hash=new int[26];
            int[] otherStrHash=new int[26];
            for (int i = 0; i < words[0].Length; i++)
            {
                //用‘a’ 来对表示第一个单词的表进行初始化
                hash[words[0][i] - 'a']++;
            }
            for (int i = 1;i<words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    //将剩余所有字符串都初始化存入
                    otherStrHash[words[i][j] - 'a']++;
                }
            }
            List<Char> result=new List<char>();
            for(int i = 0;i<26;i++)
            {
                if (otherStrHash[i]>= words.Length-1)
                {
                    hash[i] = Math.Min(hash[i], otherStrHash[i]);
                }
                else
                {
                    hash[i] =0;
                }

                while (hash[i]!=0)
                {
                    result.Add((char)(i + 'a'));
                    hash[i]--;
                }
            }
            return result;
        }
    }
}