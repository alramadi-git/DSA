namespace NeetCode.Stack.Medium;

public class GenerateParenthesis
{
    public List<string> Solution(int n)
    {
        return _GenerateParenthesis("(", 1, 0, n);
    }

    private List<string> _GenerateParenthesis(string str, int openedParentheses, int closedParentheses, int n)
    {
        var result = new List<string>();
        if (str.Length == n * 2)
        {
            result.Add(str);
            return result;
        }

        if (openedParentheses < n) result.AddRange(_GenerateParenthesis($"{str}(", openedParentheses + 1, closedParentheses, n));
        if (openedParentheses > closedParentheses) result.AddRange(_GenerateParenthesis($"{str})", openedParentheses, closedParentheses + 1, n));

        return result;
    }
}
