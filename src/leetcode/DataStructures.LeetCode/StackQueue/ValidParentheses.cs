namespace DataStructures.LeetCode.StackQueue;

public static class ValidParentheses
{
    private static readonly Dictionary<char, char> Lookup = new()
    {
        { '(', ')' },
        { '[', ']' },
        { '{', '}' },
    };

    public static bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (Lookup.ContainsKey(c))
            {
                stack.Push(c);
                continue;
            }

            if (!stack.Any() || Lookup[stack.Peek()] != c) return false;

            stack.Pop();
        }

        return !stack.Any();
    }
}