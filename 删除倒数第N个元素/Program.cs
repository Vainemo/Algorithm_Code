namespace 删除倒数第N个元素
{
    internal class Program
    {
        #region 问题描述
        /*给你一个链表，删除链表的倒数第 n 个结点，并且返回链表的头结点
         * 进阶：你能尝试使用一趟扫描实现吗？
         */
        #endregion 
        static void Main(string[] args)
        {
            
        }
        /// <summary>
        /// 快慢指针
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode Solution(ListNode head,int n)
        {
            ListNode dummyHead = new ListNode(0);
            dummyHead.Next = head;
            //快指针
            ListNode fast = dummyHead;
            //慢指针
            ListNode slow = dummyHead;
            //fast先移动n+1步
            for (int i = 0; i <= n+1; i++)
            {
                if (fast.Next != null)
                {
                    fast = fast.Next;
                }
            }
            //再将fast移动到末尾为空的位置，这样slow就移动到了要删除节点的上一个节点。
            //设总数为m，先移动n+1,那么剩余未移动到的为m-n-1，再将fast移动到末尾，slow同时移动，就移动了m-n的位数，加上虚拟头节点刚好slow在倒数第n位的上一位
            while (fast != null)
            {
                fast= fast.Next;
                slow= slow.Next;
            }
            slow.Next = slow.Next.Next;
            return dummyHead.Next;
        }
    }
    public class ListNode
    {
        public int Value;
        public ListNode? Next;
        public ListNode(int x)
        {
            Value = x;
        }
    }
}