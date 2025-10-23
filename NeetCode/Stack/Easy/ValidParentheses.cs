namespace NeetCode.Stack.Easy;

public class IsValid
{
    public bool Solution(string s)
    {
        if (s.Length % 2 != 0) return false;

        var stack = new Stack<char>();
        var closedParentheses = new Dictionary<char, char>
        {
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };

        foreach (var chr in s)
        {

            if (closedParentheses.TryGetValue(chr, out var v)) stack.Push(v);
            else
            {
                if (stack.Count == 0) return false;
                if (stack.Pop() != chr) return false;
            }
        }

        return stack.Count == 0;
    }
}
