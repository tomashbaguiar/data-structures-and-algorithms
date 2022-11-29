namespace DataStructures.LeetCode.LinkedList;

public static class RemoveLinkedListElements
{
    public static ListNode? RemoveIterative(ListNode? head, int val)
    {
        if (head == null) return head;

        while (head != null && head.val == val) head = head.next;

        var curr = head;
        var last = head;
        while (curr != null)
        {
            if (curr.val == val)
            {
                if (last != null) last.next = curr.next;
                curr = curr.next;
                continue;
            }

            last = curr;
            curr = curr.next;
        }

        return head;
    }

    public static ListNode? RemoveRecursive(ListNode? head, int val)
    {
        if (head == null) return head;
        
        head.next = RemoveRecursive(head.next, val);
        return head.val == val 
            ? head.next 
            : head;
    }
}