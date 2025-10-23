namespace ArraysAndHashing.Medium;

public class IsValidSudoku
{
    public bool Solution(char[][] board)
    {
        var ys = new HashSet<char>[9];
        var xs = new HashSet<char>[9];
        var scopes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            ys[i] = new();
            xs[i] = new();
            scopes[i] = new();
        }

        for (int y = 0; y < 9; y++)
        {
            for (int x = 0; x < 9; x++)
            {
                var value = board[y][x];
                if (value == '.') continue;

                if (!ys[y].Add(value)) return false;
                if (!xs[x].Add(value)) return false;

                var scopeY = y / 3;
                var scopeX = x / 3;
                var scopeKey = scopeY * 3 + scopeX;
                if (!scopes[scopeKey].Add(value)) return false;
            }
        }

        return true;
    }
}
