namespace DataStructures.LeetCode.LinkedList;

public static class ReverseLinkedList
{
    public static ListNode? ReverseIterative(ListNode? head)
    {
        if (head == null) return null;
        
        var curr = head;
        ListNode? newNext = null;
        while (curr != null)
        {
            var tmp = curr.next;
            curr.next = newNext;
            newNext = curr;
            curr = tmp;
        }

        return newNext;
    }

    public static ListNode? ReverseRecursive(ListNode? head)
    {
        return ReverseRecursive(head, null);
    }

    private static ListNode? ReverseRecursive(ListNode? head, ListNode? newHead)
    {
        if (head == null) return newHead;

        var next = head.next;
        head.next = newHead;
        return ReverseRecursive(next, head);
    }
}