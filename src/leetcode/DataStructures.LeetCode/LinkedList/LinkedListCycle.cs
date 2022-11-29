namespace DataStructures.LeetCode.LinkedList;

public static class LinkedListCycle
{
    public static bool HasCycle(ListNode? head)
    {
        var hash = new HashSet<ListNode>();
        var curr = head;
        while (curr != null && !hash.Contains(curr))
        {
            hash.Add(curr);
            curr = curr.next;
        }

        return curr != null;
    }

    public static bool HasCycleFastSlow(ListNode? head)
    {
        if (head == null) return false;
        
        var fast = head.next;
        var slow = head;
        while (fast != slow)
        {
            fast = fast?.next?.next;
            slow = slow?.next;
        }

        return fast != null;
    }
}