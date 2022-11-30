namespace DataStructures.LeetCode.Array;

public static class ValidSudoku
{
    public static bool Verify(char[][] board)
    {
        for (var i = 0; i < board.Length; i++)
        {
            var row = (i / 3) * 3;
            var col = (i - row) * 3;
            if (!IsValidSubBoard(board, row, col)) return false;
            
            var lineHash = new HashSet<char>();
            var colHash = new HashSet<char>();
            for (var j = 0; j < board[i].Length; j++)
            {
                var curr = board[i][j];
                if (lineHash.Contains(curr)) return false;
                if (curr != '.') lineHash.Add(curr);

                curr = board[j][i];
                if (colHash.Contains(curr)) return false;
                if (curr != '.') colHash.Add(curr);
            }
        }

        return true;
    }
    
    private static bool IsValidSubBoard(char[][] board, int row, int col)
    {
        var subHash = new HashSet<char>();
        for (var i = row; i < row + board.Length / 3; i++)
        {
            for (var j = col; j < col + board.Length / 3; j++)
            {
                var curr = board[i][j];
                if (subHash.Contains(curr)) return false;
                if (curr != '.') subHash.Add(curr);
            }
        }

        return true;
    }
}