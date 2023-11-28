namespace 快慢指针
{
    /// <summary>
    /// 27.移除元素 
    /// </summary>
    internal class Program
    {
        #region 问题描述
        /*给你一个数组 nums 和一个值 val，你需要 原地 移除所有数值等于 val 的元素，并返回移除后数组的新长度。
         * 不要使用额外的数组空间，你必须仅使用 O(1) 额外空间并原地修改输入数组。
         * 元素的顺序可以改变。你不需要考虑数组中超出新长度后面的元素。
         * 示例 1: 给定 nums = [3,2,2,3], val = 3, 函数应该返回新的长度 2, 并且 nums 中的前两个元素均为 2。 你不需要考虑数组中超出新长度后面的元素。
         */
        #endregion
        static void Main(string[] args)
        {
            int[] ints = { -9, 2, -3,4,-4,6,7,8 };
            int result=Solution(ints,2);
            int result1=Solution1(ints,2);
            int[] ints2 = Solution2(ints);
        }
        /// <summary>
        /// 快慢指针
        /// </summary>
        /// <param name="ints"></param>
        /// <param name="Target"></param>
        /// <returns></returns>
        static int Solution(int[] ints,int Target)
        {
            int slowIndex=0;
            for (int fastIndex = 0; fastIndex < ints.Length; fastIndex++)
            {
                if (ints[fastIndex] !=Target)
                {
                    //先读取，后++; 处理的是除去目标元素后，后面元素相对移动的逻辑
                    ints[slowIndex++] = ints[fastIndex];
                }
            }
            return slowIndex;
        }
        /// <summary>
        /// 相向双指针 改变了元素相对位置，确保了移动最少元素
        /// </summary>
        /// <param name="ints"></param>
        /// <param name="Target"></param>
        /// <returns></returns>
        static int Solution1(int[] ints,int Target)
        {
            int leftIndex = 0;
            int rightIndex = ints.Length - 1;
            while (leftIndex <=rightIndex) 
            {
                //拿左边等于Target的值
                while (leftIndex <= rightIndex && ints[leftIndex]!=Target) 
                {
                    leftIndex++;
                }
                while(leftIndex <= rightIndex && ints[rightIndex] == Target)
                {
                    rightIndex--;
                }
                //不加=：如果刚好是同一个元素，赋值没意义
                if (leftIndex < rightIndex)
                {
                    ints[rightIndex--]= ints[leftIndex++];
                }
            }
            return leftIndex;
        }

        #region 问题描述
        /*给你一个按 非递减顺序 排序的整数数组 nums，返回 每个数字的平方 组成的新数组，要求也按 非递减顺序 排序。
        示例 1：
        输入：nums = [-4,-1,0,3,10]
        输出：[0,1,9,16,100]
        解释：平方后，数组变为[16, 1, 0, 9, 100]，排序后，数组变为[0, 1, 9, 16, 100]
        */
        #endregion
        static int[] Solution2(int[] ints)
        {
            int[] result=new int[ints.Length];
            int leftIndex=0, rightIndex=ints.Length - 1;
            while (leftIndex <=rightIndex)
            {
                if (ints[leftIndex]* ints[leftIndex] > ints[rightIndex] * ints[rightIndex])
                {
                    result[rightIndex--] = ints[leftIndex] * ints[leftIndex++];
                }
                else
                {
                    result[rightIndex] = ints[rightIndex] * ints[rightIndex--];
                }
            }
            return result;
        }

    }
}