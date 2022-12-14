namespace DataStructures.LeetCode.Array;

public static class SubarraySumEqualsK
{
    public static int Find(int[] array, int k)
    {
        var n = array.Length;
        if (n == 0) return 0;
        if (n == 1 && array[0] == k) return 1;

        var prefix = new int[n];
        prefix[0] = array[0];
        for (var i = 1; i < n; i++)
        {
            prefix[i] = array[i] + prefix[i - 1];
        }

        var map = new Dictionary<int, int>();
        var count = 0;
        for (var i = 0; i < n; i++)
        {
            var curr = prefix[i];
            if (curr == k) count++;

            if (map.ContainsKey(curr - k))
            {
                count += map[curr - k];
            }

            if (map.ContainsKey(curr)) map[curr]++;
            else map.Add(curr, 1);
        }

        return count;
    }
    
// So, suppose we have an array as arr[]: [1,2,3,4,5] and k = 9
//
// so, our answer will be '2' i.e (2 + 3 + 4 and 4 + 5)
// so if we store our prefix sum array then it should looks like:
// index :   0, 1, 2, 3,  4
// arr[]: [1, 2, 3, 4,  5]
// prefix[]:[1, 3, 6, 10, 15]
//       ↑         ↑
//
// How, we will find our subarray (2 + 3 + 4) using prefix sum, see-
//
// 1) if we see our prefix sum at index 3 then it is 10 and also prefix sum at index 0 is 1
// so, we can say that from index 0 to 3 our prefix sum increases from 1 to 10, right,
//
// 2) So on putting a question, HOW MUCH ? means how much our sum increase from index 0 to index 3
// then, we simply say, we find the difference between these two sums i.e (10 - 1) is the sum that increases
// from index 0 to 3.
//
// 3) If (10 - 1) sum increases from index 0 to 3, then we can say that, ok, this difference, should be the sum
// of elements greater than index 0, and upto index 3, i.e from index 1 to index 3,right.
//
// 4) Now, if we will see then we find out (10 - 1) is nothing but our 'k' that is 9.
//
// 5) So, we find out, that a subarray may also exist if this particular condition satisfied, i.e
// (prefix[i] - k) should exist in our map, 
//
// How? see,
//
// If prefix[i] - prefix[j] = k where i > j (i, j any index, in our case they are i = 3, j = 0)
// prefix[i] - k = prefix[j] na, (simple maths)
//
// i.e if we are able to find (prefix[i] - k) is exist in our map, i.e prefix[j]
// so, we can say that from index j + 1 to i, the sum of the elements is k, right na,
// hence it proves that their exist an subarray from index j + 1 to i whose sum is k.
//
// Now, for subarray (4 + 5) we again find this valid see -
//
// index :   0, 1, 2, 3,  4
// arr[]: [1, 2, 3, 4,  5]
// prefix[]:[1, 3, 6, 10, 15]
//             ↑       ↑
// 			
// 1) if we see our prefix sum at index 4 then it is 15 and also prefix sum at index 2 is 6
// so, we can say that from index 2 to 4 our prefix sum increases from 6 to 15, right,
//
// 2) So on putting a question, HOW MUCH ? means how much our sum increase from index 2 to index 4
// then, we simply say, we find the difference between these two sums i.e (15 - 6) is the sum that increases from
// index 2 to 4.
//
// 3) If (15 - 6) sum increases from index 2 to 4, then we can say that, ok, this difference, should be the sum of
// elements greater than index 2, and upto index 4, i.e from index 3 to index 4,right.
//
// 4) Now, if we will see then we find out (15 - 6) is nothing but our 'k' that is 9.
//
// 5) So, we find out, that a subarray may also exist if this particular condition satisfied, i.e
// (prefix[i] - k) should exist in our map, right na,
//
// How? see,
//
// If prefix[i] - prefix[j] = k where i > j (i, j any index, in our case they are i = 4, j = 2)
// prefix[i] - k = prefix[j] na, (simple maths)
//
// i.e if we are able to find (prefix[i] - k) is exist in our map, i.e prefix[j]
// so, we can say that from index j + 1 to i, the sum of the elements is k, right na,
// hence it proves that their exist an subarray from index j + 1 to i whose sum is k.
//
// I hope u got the reason now, why we will do (prefix[i] - k) in our code.
}