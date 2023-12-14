namespace 交换元素
{
    #region 问题描述
    /*给定一个链表，两两交换其中相邻的节点，并返回交换后的链表。
     *你不能只是单纯的改变节点内部的值，而是需要实际的进行节点交换。
     */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = new ListNode(4);
            ListNode? node=Solution(head);
            Console.WriteLine( "11");
        }
        /// <summary>
        /// 递归方法
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode? Solution(ListNode? head)
        {
           
            if(head==null||head.Next==null)
            {
                return head;
            }
            //获取第二个节点为头节点
            ListNode cur = head.Next;
            //指向第二个节点，设置为头节点
            head.Next = Solution(head.Next.Next);
            cur.Next = head;
            return cur;
        }
        public static ListNode? Solution1(ListNode? head)
        {
            ListNode dummyHead=new ListNode(0);
            dummyHead.Next = head.Next;
            head.Next = head;
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
