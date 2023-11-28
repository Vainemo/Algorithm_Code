namespace AlgorithmTest
{
    /// <summary>
    /// 704. 二分查找
    /// </summary>
    internal class Program
    {

        #region 问题描述
        /*给定一个 n 个元素有序的（升序）整型数组 nums 和一个目标值 target  ，写一个函数搜索 nums 中的 target，如果目标值存在返回下标，否则返回 -1。
         * 输入: nums = [-1,0,3,5,9,12], target = 9     
         * 输出: 4       
         * 解释: 9 出现在 nums 中并且下标为 4     
         */
        #endregion
        static void Main(string[] args)
        {
            int[] aa = { 1,2,3,4,5,6,7,8};
            int b=Search(aa, -1);
            Console.WriteLine(b);
        }
        /// <summary>
        /// 查找数组中Target
        /// </summary>
        /// <param name="ints"></param>
        /// <param name="Target"></param>
        /// <returns></returns>
        public static int Search(int[] ints, int Target)
        {
            
            int left = 0;
            int right=ints.Length-1;
            int Middle;
            //定搜索边界
           while (left <= right) 
            {
                Middle =left+(right- left) / 2;
                if (Target<ints[Middle]) 
                {
                    right = Middle-1;
                }
                if (Target> ints[Middle])
                {
                    left = Middle+ 1;
                }
                if (Target == ints[Middle])
                {
                    return Middle;
                }
            }
            return -1;
        }
    }
    
}