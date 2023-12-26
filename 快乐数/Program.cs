﻿namespace 快乐数
{
    #region 问题描述
    /*「快乐数」定义为：对于一个正整数，每一次将该数替换为它每个位置上的数字的平方和，然后重复这个过程直到这个数变为 1，也可能是 无限循环 但始终变不到 1。如果 可以变为  1，那么这个数就是快乐数。
        如果 n 是快乐数就返回 True ；不是，则返回 False 。
        示例：
        输入：19
        输出：true
        解释：
        1^2 + 9^2 = 82
        8^2 + 2^2 = 68
        6^2 + 8^2 = 100
        1^2 + 0^2 + 0^2 = 1
     */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public bool Solution(int n)
        {
            //关键：不是快乐数会出现循环
            HashSet<int> visited = new HashSet<int>();
            while (n!=1&&visited.Contains(n))
            {
                visited.Add(n);
                n=GetSum(n);
            }
           //n！=1说明存在循环，不是快乐数
            return n==1;
        }

        private  int GetSum( int n)
        {
            int sum = 0;
            while (n > 0)
            {
                //计算每个位数上的平方和
                sum += (n % 10) * (n % 10);
                n = n / 10;
            }
            return sum;
        }
    }
}