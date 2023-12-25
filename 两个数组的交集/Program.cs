namespace 两个数组的交集
{
    internal class Program
    {
        #region 问题描述
        /*给定两个数组 nums1 和 nums2 ，返回 它们的交集 。输出结果中的每个元素一定是 唯一 的。我们可以 不考虑输出结果的顺序 。
         * 示例 1：
         * 输入：nums1 = [1,2,2,1], nums2 = [2,2]
         * 输出：[2]
         * 示例 2：
         * 输入：nums1 = [4,9,5], nums2 = [9,4,9,8,4]
         * 输出：[9,4]
         * 解释：[4,9] 也是可通过的
         */
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public int[] Solution(int[] nums1, int[] nums2)
        {
           if (nums1==null||nums1.Length==0||nums2==null||nums2.Length==0)
            {
                return new int[0];
            }
            HashSet<int> hash1=new HashSet<int>();
            HashSet<int> hash2=new HashSet<int>();
           for (int i = 0; i < nums1.Length; i++)
            {
                hash1.Add(nums1[i]);
            }
           for (int i = 0;i < nums2.Length; i++)
            {
                hash2.Add(nums2[i]);
            }
            //修改当前的 HashSet<T> 对象，以仅包含该对象和指定集合中存在的元素。
            hash1.IntersectWith(hash2);
            return hash1.ToArray();
        }
    }
}