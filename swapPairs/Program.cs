using System;
namespace swapPairs
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class Program
    {
        public ListNode SwapPairs(ListNode head) {
            if (head.next == null) 
                return head;
            ListNode pre = null;
            ListNode cur = head;
            head = head.next;
            while(cur != null) {
                ListNode post = cur.next;
                cur.next = post.next;
                if (pre != null)
                    pre.next = post;
		if (post != null)
                    post.next = cur; 
                pre = cur;
                cur = cur.next;
            }
            return head;
        }
        static void Main(string[] args)
        {
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            // ListNode n3 = new ListNode(3);
            // ListNode n4 = new ListNode(4);
            n1.next = n2;
            // n2.next = n3;
            // n3.next = n4;


            var tmp = new Program().SwapPairs(n1);
            while(tmp != null) {
                Console.WriteLine("{0}\t", tmp.val);
                tmp = tmp.next;
            }

        }
    }
}
