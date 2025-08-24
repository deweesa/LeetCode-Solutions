/* https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/?envType=study-plan-v2&envId=leetcode-75
 * In a linked list of size n, where n is even, the ith node (0-indexed) of the linked list is known as the twin of the (n-1-i)th node, if 0 <= i <= (n / 2) - 1.
 * For example, if n = 4, then node 0 is the twin of node 3, and node 1 is the twin of node 2. These are the only nodes with twins for n = 4.
 * The twin sum is defined as the sum of a node and its twin.
 *
 * Given the head of a linked list with even length, return the maximum twin sum of the linked list.
 *
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int PairSum(ListNode head) {
        ListNode slow = head;
        ListNode fast = head.next;

        while(fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        slow.next = ReverseList(slow.next);

        fast = slow.next;
        slow = head;

        int maxSum = 0;

        while(fast != null) {
            int currSum = slow.val + fast.val;
            if(currSum > maxSum) {
                maxSum = currSum;
            }

            slow = slow.next;
            fast = fast.next;
        }
        
        return maxSum;
    }

    public ListNode ReverseList(ListNode node) {
        ListNode prev = null;
        ListNode curr = node;
        ListNode next;

        while(curr != null) {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}
