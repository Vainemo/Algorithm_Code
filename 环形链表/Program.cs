namespace 环形链表
{
    internal class Program
    {
        #region 问题描述
        /*给定一个链表，返回链表开始入环的第一个节点。 如果链表无环， 则返回 null。
         * 为了表示给定链表中的环，使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。
         * 如果 pos 是 -1，则在该链表中没有环。说明：不允许修改给定的链表。
         */
        #endregion
        static void Main(string[] args)
        {
           
        }
        static int? Solution(ListNode head)
        {
            int pos =0;
            ListNode fast = head;
            ListNode slow = head;
            //关键点：fast指针每次移动两个节点，slow指针每次移动一个节点，有环的话，一定会在环内相遇。（如果有环，在环内相对于slow来说，fast是一个节点一个节点的靠近slow的，所以fast一定可以和slow重合）
            
            while (fast != slow&& fast.Next!=null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }
            if (fast == slow)
            {
                //关键点：假设从头结点到环形入口节点 的节点数为x。 环形入口节点到 fast指针与slow指针相遇节点 节点数为y。 从相遇节点 再到环形入口节点节点数为 z
                //那么相遇时： slow指针走过的节点数为: x + y， fast指针走过的节点数： x + y + n (y + z) 为fast指针在环内走了n圈才遇到slow指针， （y+z）为 一圈内节点的个数A。
                // 因为fast指针是一步走两个节点，slow指针一步走一个节点， 所以 fast指针走过的节点数 = slow指针走过的节点数 * 2：(x + y) * 2 = x + y + n(y + z)
                //有 x = n (y + z) - y
                //当 n为1的时候，公式就化解为 x = z，
                //这就意味着，从头结点出发一个指针，从相遇节点 也出发一个指针，这两个指针每次只走一个节点， 那么当这两个指针相遇的时候就是 环形入口的节点。
                //那么 n如果大于1是什么情况呢，就是fast指针在环形转n圈之后才遇到 slow指针。
                //其实这种情况和n为1的时候 效果是一样的，一样可以通过这个方法找到 环形的入口节点，只不过，index1 指针在环里 多转了(n - 1)圈，然后再遇到index2，相遇点依然是环形的入口节点。
                ListNode index1 = fast;
                ListNode index2 = head;
                while (index1 != index2)
                {
                    pos++;
                    index1 = index1.Next;
                    index2=index2.Next;
                }
            }
            else
            {
                return -1;
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