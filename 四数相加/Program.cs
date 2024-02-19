namespace 四数相加
{
    #region 问题描述
    /*给定四个包含整数的数组列表 A , B , C , D ,计算有多少个元组 (i, j, k, l) ，使得 A[i] + B[j] + C[k] + D[l] = 0。
     * 为了使问题简单化，所有的 A, B, C, D 具有相同的长度 N，且 0 ≤ N ≤ 500 。所有整数的范围在 -2^28 到 2^28 - 1 之间，最终结果不会超过 2^31 - 1 。
     * 例如:
     * 输入:
     * A = [ 1, 2]
     * B = [-2,-1]
     * C = [-1, 2]
     * D = [ 0, 2]
     * 输出:
     * 2
     */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public int Solution(int[] a, int[] b, int[] c, int[] d)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();
            int count = 0;
            ///先计算a和b所有和出现的次数和数值
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    map[a[i] + b[j]]++;
                }
            }
           // 跟c和d进行比较，如果有相减等0的就count++
            for (int i = 0; i <c.Length; i++)
            {
                for (int j = 0; j <d.Length; j++)
                {
                    if (map.ContainsKey(-(c[i] + d[j])))
                    {
                        count += map[-(c[i] + d[j])];
                    }
                }
            }
            return count;
        }
    }
}