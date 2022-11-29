using System.Linq;
using DataStructures.LeetCode.LinkedList;

namespace DataStructures.LeetCode.Tests.LinkedList;

public static class LinkedListTestHelper
{
    public static ListNode? CreateHead(int[] list)
    {
        if (list.Length == 0) return null;
        
        var last = new ListNode(list.Last());
        for (var i = list.Length - 2; i >= 0; i--)
        {
            var curr = list[i];
            var ln = new ListNode(curr, last);

            last = ln;
        }
        
        return last;
    }

    public static void CreateCycle(this ListNode head, int pos)
    {
        if (pos == -1) return;
        
        var curr = head;
        var count = 0;
        ListNode? nodeAtPos = null;
        while (curr.next != null)
        {
            nodeAtPos = count++ == pos ? curr : nodeAtPos;
            curr = curr.next;
        }

        curr.next = nodeAtPos;
    }
}