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
            //ListNode head = new ListNode(1);
            //head.Next = new ListNode(2);
            //head.Next.Next = new ListNode(3);
            //head.Next.Next.Next = new ListNode(4);
            //ListNode? node=Solution(head);
            xx AA= new xx();
            AA.Value = 1;
            xx BB = AA;
            Console.WriteLine(BB.Value);
            AA.Value = 2;
            Console.WriteLine(BB.Value);
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
        /// <summary>
        /// 循环
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode? Solution1(ListNode? head)
        {
            //虚拟头节点
            ListNode dummyHead=new ListNode(0);
            dummyHead.Next = head;
            ListNode cur = dummyHead;
            //循环不变量，cur指向两个元素中的第一个
            while(cur.Next!=null&&cur.Next.Next!=null)
            {
                //存下要交换第一个元素
                ListNode tmp1= cur.Next;
                //存下下一次要交换的元素
                ListNode temp2= cur.Next.Next.Next;
                cur.Next = cur.Next.Next;
                cur.Next.Next=tmp1;
                cur.Next.Next.Next = temp2;
                cur = cur.Next.Next;
            }
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
    public class xx
    {
        public int Value;
    }
}
