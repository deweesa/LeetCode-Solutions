// url: https://leetcode.com/problems/linked-list-cycle/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null || head.next == null) return false;
        ListNode slowRunner, fastRunner;
        slowRunner = fastRunner = head;

        while(slowRunner != null && fastRunner != null) {
            slowRunner = slowRunner.next;
            fastRunner = fastRunner.next;
            
            if(fastRunner != null) {
                fastRunner = fastRunner.next;
            }
            if(slowRunner == fastRunner) {
                return true;
            }
        }

        return false;
    }
}
