using System;
using static System.Net.Mime.MediaTypeNames;

namespace 设计链表
{
    internal class Program
    {
        #region 问题描述
        /*在链表类中实现这些功能：
          get(index)：获取链表中第 index 个节点的值。如果索引无效，则返回-1。
          addAtHead(val)：在链表的第一个元素之前添加一个值为 val 的节点。插入后，新节点将成为链表的第一个节点。
          addAtTail(val)：将值为 val 的节点追加到链表的最后一个元素。
          addAtIndex(index,val)：在链表中的第 index 个节点之前添加值为 val  的节点。如果 index 等于链表的长度，则该节点将附加到链表的末尾。如果 index 大于链表长度，则不会插入节点。如果index小于0，则在头部插入节点。
          deleteAtIndex(index)：如果索引 index 有效，则删除链表中的第 index 个节点。
         */
        #endregion
       
        static void Main(string[] args)
        {
           
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
    public class MyLinkedList
    {
        /// <summary>
        /// 虚拟表头
        /// </summary>
        private ListNode _virtualHead;
        /// <summary>
        /// 链表长度
        /// </summary>
        private int _count;
       public  MyLinkedList() 
        {
            _virtualHead = new ListNode(0);
            _count = 0;
        }
        /// <summary>
        /// 获取链表中第 index 个节点的值。如果索引无效，则返回-1
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Get(int index)
        {
            ListNode tempListNode = _virtualHead;
            if (index<0||index>_count)
            {
                return -1;
            }
            //可以考虑改用for循环，更直观
            while (index>=0) 
            {
                tempListNode=tempListNode.Next;
                index--;
            }
            return tempListNode.Value;
        }
        /// <summary>
        /// 将值为 val 的节点追加到链表的最后一个元素
        /// </summary>
        /// <param name="val"></param>
        public void AddAtTail(int val)
        {
            ListNode tempListNode=_virtualHead;
            while (tempListNode.Next!=null)
            {
                tempListNode= tempListNode.Next;
            }
            tempListNode.Next=new ListNode(val);
            _count++;
        }
        /// <summary>
        /// 在链表的第一个元素之前添加一个值为 val 的节点。插入后，新节点将成为链表的第一个节点。
        /// </summary>
        /// <param name="val"></param>
        public void AddAtHead(int val)
        {
            ListNode tempListNode = _virtualHead.Next;
            if (tempListNode==null)
            {
                AddAtTail(val);
            }
            else
            {
                _virtualHead.Next = new ListNode(val);
                _virtualHead.Next.Next= tempListNode;
                _count++;
            }
        }
        /// <summary>
        /// 在链表中的第 index 个节点之前添加值为 val  的节点。如果 index 等于链表的长度，则该节点将附加到链表的末尾。如果 index 大于链表长度，则不会插入节点。如果index小于0，则在头部插入节点。
        /// </summary>
        /// <param name="index"></param>
        /// <param name="val"></param>
        public void AddAtIndex(int index,int val)
        {
            if (index<0)
            {
                AddAtHead(val);
            }
           else  if (index>_count)
            {
                return;
            }
            else if (index==_count)
            {
                AddAtTail(val);
            }
            else
            {
                ListNode tempListNode = _virtualHead;
                while (index>0)
                {
                    tempListNode= _virtualHead.Next;
                    index--;
                }
                ListNode NextNode = _virtualHead.Next;
                _virtualHead.Next= new ListNode(val);
                _virtualHead.Next = NextNode;

            }
        }
        /// <summary>
        /// 如果索引 index 有效，则删除链表中的第 index 个节点。
        /// </summary>
        /// <param name="index"></param>
        public void DeleteAtIndex(int index)
        {
            if (index<0||index>_count-1)
            {
                return;
            }
            ListNode tempListNode = _virtualHead;
            while (index >=0)
            {
                tempListNode = _virtualHead.Next;
                index--;
            }
            tempListNode.Next = tempListNode.Next.Next;
            _count--;
        }
    }
}