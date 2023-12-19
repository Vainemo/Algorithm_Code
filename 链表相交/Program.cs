namespace 链表相交
{
    internal class Program
    {
        #region 问题描述
        /*给你两个单链表的头节点 headA 和 headB ，请你找出并返回两个单链表相交的起始节点。如果两个链表没有交点，返回 null 。
         */
        #endregion
        static void Main(string[] args)
        {
           
        }
        static ListNode? Solution(ListNode headA,ListNode headB)
        {
            ListNode curA = headA;
            ListNode curB = headB;
            if (curB==null||curA==null)
            {
                return null;
            }
            while (curA!=null||curB!=null)
            {
                if (curA!=curB)
                {
                    curA = curA.Next;
                    curB = curB.Next;
                }
                else
                {
                    return curA;
                }
            }
            return null;
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