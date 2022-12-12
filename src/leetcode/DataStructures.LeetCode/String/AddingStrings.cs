using System.Text;

namespace DataStructures.LeetCode.String;

public static class AddingStrings
{
    private const int Offset = '0';

    public static string Add(string num1, string num2)
    {
        var n1Len = num1.Length - 1;
        var n2Len = num2.Length - 1;
        var digits = new Stack<char>();
        var sum = 0;
        while (n1Len >= 0 || n2Len >= 0 || sum > 0)
        {
            var n1 = n1Len >= 0 ? num1[n1Len--] - Offset : 0;
            var n2 = n2Len >= 0 ? num2[n2Len--] - Offset : 0;
            sum += n1 + n2;
            if (sum < 10)
            {
                digits.Push((char)(sum + Offset));
                sum = 0;
                continue;
            }

            digits.Push((char)(sum - 10 + Offset));
            sum = 1;
        }

        var sb = new StringBuilder();
        while (digits.Count > 0) sb.Append(digits.Pop());

        return sb.ToString();
    }
}