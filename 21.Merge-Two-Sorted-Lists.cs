public class ListNode {
    public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
          this.next = next;
  }
}
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

      ListNode result = new ListNode();
      ListNode curNode = result;

      while (list1 != null && list2 != null) {
        if(list1.val < list2.val) {
          curNode.next = list1;
          list1 = list1.next;
        } else {
          curNode.next = list2;
          list2 = list2.next;
        }
        curNode = curNode.next;        
      }

      if(list1 == null) {curNode.next = list2;} 
      if(list2 == null) {curNode.next = list1;}
  
      return result.next;
        
    }
}