namespace 删除元素
{
    #region 问题描述
    /*题意：删除链表中等于给定值 val 的所有节点。
      示例 1： 输入：head = [1,2,6,3,4,5,6], val = 6 输出：[1,2,3,4,5]
      示例 2： 输入：head = [], val = 1 输出：[]
      示例 3： 输入：head = [7,7,7,7], val = 7 输出：[]
     */
    #endregion
    public class ListNode
    {
        public int Value;
        public ListNode? Next;
        public ListNode(int x,ListNode listNode)
        {
            Value = x;
            Next = listNode;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solution(2);
        }
        public static ListNode Solution(ListNode head, int val)
        {
            //虚拟表头，占位
            ListNode newHead = new ListNode(0, head);
            ListNode? TempHead = head;
            while (TempHead.Next!=null)
            {
                if (TempHead.Next.Value==val)
                {
                    TempHead.Next = TempHead.Next.Next;
                }
                else
                {
                    TempHead = TempHead.Next;
                }
            }
            return newHead.Next;
        }
    }
}