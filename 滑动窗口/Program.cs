namespace 滑动窗口
{
    internal class Program
    {
        #region 问题描述
        /*给定一个含有 n 个正整数的数组和一个正整数 s ，找出该数组中满足其和 ≥ s 的长度最小的 连续 子数组，并返回其长度。如果不存在符合条件的子数组，返回 0。
           示例：
           输入：s = 7, nums = [2,3,1,2,4,3]
           输出：2
           解释：子数组 [4,3] 是该条件下的长度最小的子数组。
         */
        #endregion
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3,4,5 };
            int result = Solution(ints, 6);
        }
        static int Solution(int[] ints,int target)
        {
            int result = int.MaxValue;
            int startIndex = 0;
            int endIndex = 0;
            int sumLength = 0;
            int sum = 0;
            for (endIndex=0; endIndex < ints.Length; endIndex++)
            {
                sum += ints[endIndex];
                while (sum>=target)
                {
                    sumLength = endIndex - startIndex + 1;
                    result=result<sumLength ? result : sumLength;
                    //当条件满足时， 起始指针向前移动
                    sum -= ints[startIndex++];
                }
            }
            return result==int.MaxValue?0:result;
        }
    }
}