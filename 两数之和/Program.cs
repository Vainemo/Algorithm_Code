namespace 两数之和
{
    internal class Program
    {
        #region 问题描述
        /*给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
         * 你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。
         * 示例:
         * 给定 nums = [2, 7, 11, 15], target = 9
         * 因为 nums[0] + nums[1] = 2 + 7 = 9
         * 所以返回 [0, 1]
         */
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public void Solution(int[] nums, int target)
        {
            HashMap<int,int> visited = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int n = target - nums[i];
                if (!visited.Contains(n))
                {
                    visited.Add(n);
                }
            }
        }
    }
}