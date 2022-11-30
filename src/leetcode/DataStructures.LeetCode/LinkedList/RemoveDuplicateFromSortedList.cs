namespace DataStructures.LeetCode.LinkedList;

public static class RemoveDuplicateFromSortedList
{
    public static ListNode? DeleteIterative(ListNode? head)
    {
        if (head == null) return null;
        
        var curr = head.next;
        var last = head;
        while (curr != null)
        {
            if (curr.val != last.val)
            {
                last = curr;
                curr = curr.next;
                continue;
            }

            last.next = curr.next;
            curr = curr.next;
        }

        return head;
    }

    public static ListNode? DeleteRecursive(ListNode? head)
    {
        if(head?.next == null) return head;
        
        head.next = DeleteRecursive(head.next);
        return head.next != null && head.val == head.next.val ? head.next : head;
    }
}