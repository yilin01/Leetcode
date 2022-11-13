/**
 * Definition for singly-linked list.
//  * public class ListNode {
//  *     public int val;
//  *     public ListNode next;
//  *     public ListNode(int val=0, ListNode next=null) {
//  *         this.val = val;
//  *         this.next = next;
//  *     }
//  * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
      ListNode pre = null;
      ListNode cur = head;
      ListNode tempNode;
      while (cur!= null) {
        tempNode = cur.next;
        cur.next = pre;
        pre = cur;
        cur = cur.next;
      }
      return pre;
    }
}

public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
}

// public class Solution {
//     public ListNode ReverseList(ListNode head) {
//       System.Collections.Generic.Stack<int> stack = new System.Collections.Generic.Stack<int>();
//       if (head == null) return null;
//       stack.Push(head.val); 
//       ListNode tempHead = head.next;     
//       while (tempHead != null) {
//         stack.Push(tempHead.val);
//         tempHead = tempHead.next;
//       } 
//       ListNode result = new ListNode(stack.Pop());
//       ListNode tempNode = result;
//       while(stack.Count > 0) {
//         tempNode.next = new ListNode(stack.Pop());
//         tempNode = tempNode.next;
//       }

//       return result;  
//     }
// }
