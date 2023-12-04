namespace 反转链表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static ListNode? Solution(ListNode head)
        {
            //当前的位置
            ListNode cur= head;

            //当前位位置元素的Next指向的位置
            ListNode pre= null;
            //下一个要翻转的元素
            ListNode next = head;
            while(cur != null)
            {
               next = cur.Next;
                cur.Next = pre;
                pre = cur;
                cur = next;
            }
            return pre;
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
