using System;

namespace leetcode{
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}
 
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode h1 = l1;
        ListNode h2 = l2;
        while(l1 != null && l2 != null) {
            l1 = l1.next;
            l2 = l2.next;
        }
        if (l1 != null)   // the length of l1 is not less than that of l2
            return AddTwoNumbersHelper(h1, h2, 0);
        else
            return AddTwoNumbersHelper(h2, h1, 0);
    }

    public ListNode AddTwoNumbersHelper(ListNode l1, ListNode l2, int carry) {
        var node = new ListNode(carry);
        node.next = null;
        carry = 0;
        if (l2 == null && l1 != null) {
            node.val += l1.val;
            if (node.val >= 10) {
                carry = 1;
                node.val -= 10;
            }
            node.next = AddTwoNumbersHelper(l1.next, null, carry);
        } else if (l2 == null && l1 == null) {
            if (node.val == 0) 
                return null;
            else 
                return node;
        } else {
            node.val += l1.val + l2.val;
            if (node.val >= 10) {
                carry = 1;
                node.val -= 10;
            }
            node.next = AddTwoNumbersHelper(l1.next, l2.next, carry);
        }
        return node;
    }
    public static void Main(string[] args) {
        ListNode head1_1 = new ListNode(2);
        ListNode node1_2 = new ListNode(4);
        ListNode node1_3 = new ListNode(3);
        node1_2.next = node1_3;
        head1_1.next = node1_2;

        ListNode head2_1 = new ListNode(5);
        ListNode node2_2 = new ListNode(6);
        ListNode node2_3 = new ListNode(9);
        ListNode node2_4 = new ListNode(9);

        node2_3.next = node2_4;
        node2_2.next = node2_3;
        head2_1.next = node2_2;

        var solution = new Solution();
        var result = solution.AddTwoNumbers(head1_1, head2_1);
        while(result != null) {
            Console.WriteLine("{0} ", result.val);
            result = result.next;
        }

    }

}
}
