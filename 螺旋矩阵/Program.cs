namespace 螺旋矩阵
{
    #region 问题描述
    /*给定一个正整数 n，生成一个包含 1 到 n^2 所有元素，且元素按顺时针顺序螺旋排列的正方形矩阵。
      示例:
      输入: 3 输出: [ [ 1, 2, 3 ], [ 8, 9, 4 ], [ 7, 6, 5 ] ]
     */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution(4);
        }
        /// <summary>
        /// 模拟行为
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        static int[][] Solution(int target)
        {
            ///循环不变量：区间，选择左闭右开
            int[][] result = new int[target][];
            int startIndex = 0;
            int endIndex = target-1;
            //依次从1-target*target的值。
            int value = 1;
            for (int i = 0;i<target;i++) 
            {
                result[i] = new int[target];
            }
            while (value< target*target)
            {
                for (int j = 0; j<endIndex;j++)
                {
                    result[startIndex][j]= value;
                    value++;
                }
                for (int j = startIndex; j<endIndex; j++)
                {
                    result[j][endIndex] = value;
                    value++;
                }
                for(int j = endIndex; j>startIndex;j--)
                {
                    result[endIndex][j]= value;
                    value++;
                }
                for (int j = endIndex; j>startIndex; j--)
                {
                    result[j][startIndex] = value;
                    value++;
                }
                startIndex++;
                endIndex--;
            }
            //偶数刚好转完，奇数会剩一个中心点没赋值
            if (target%2==1)
            {
                result[startIndex][endIndex] = value;
            }
            return result;
        }
    }
}