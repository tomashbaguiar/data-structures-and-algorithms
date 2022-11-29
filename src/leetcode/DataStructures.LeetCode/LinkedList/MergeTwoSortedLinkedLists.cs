namespace DataStructures.LeetCode.LinkedList;

public static class MergeTwoSortedLinkedLists
{
    public static ListNode? MergeIterative(ListNode? list1, ListNode? list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        var head = new ListNode(0);
        var curr = head;
        var curr1 = list1;
        var curr2 = list2;
        while (curr1 != null || curr2 != null)
        {
            if (curr1 == null)
            {
                curr!.next = curr2;
                curr = curr2;
                curr2 = curr2?.next;
                continue;
            }

            if (curr2 == null)
            {
                curr!.next = curr1;
                curr = curr1;
                curr1 = curr1.next;
                continue;
            }

            if (curr1.val < curr2.val)
            {
                curr!.next = curr1;
                curr = curr1;
                curr1 = curr1.next;
                continue;
            }

            curr!.next = curr2;
            curr = curr2;
            curr2 = curr2.next;
        }

        return head.next;
    }

    public static ListNode? MergeRecursive(ListNode? head1, ListNode? head2)
    {
        if (head1 == null) return head2;
        if (head2 == null) return head1;
        if (head1.val < head2.val)
        {
            head1.next = MergeRecursive(head1.next, head2);
            return head1;
        }
        
        head2.next = MergeRecursive(head1, head2.next);
        return head2;
    }
}