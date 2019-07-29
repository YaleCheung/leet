using System;

namespace removeNthFromEnd
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) {val = x;}
    }
    public class Program
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n) {
            if (head == null) 
                return null;
            ListNode first = head;
            ListNode second = head;
            for(int i = 0; i != n - 1 && second != null; ++ i) 
                second = second.next;
            ListNode pre = null;
            while(second.next != null) {
                pre = first;
                first = first.next;
                second = second.next;
            }
            if (pre == null)
                return first.next;
            else {
                pre.next = first.next;
                return head;
            }
        }
        static void Main(string[] args)
        {
            var sol = new Program();
            ListNode fst = new ListNode(1);
            // ListNode sec = new ListNode(2);
            // ListNode third = new ListNode(3);
            // ListNode four = new ListNode(4);
            // fst.next = sec;
            // sec.next = third;
            // third.next = four;

            var node = sol.RemoveNthFromEnd(fst, 1);
            while(node != null) {
                Console.WriteLine("{0} ", node.val);
                node = node.next;
            }
        }
    }
}
