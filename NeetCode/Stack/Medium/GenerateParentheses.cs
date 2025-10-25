namespace NeetCode.Stack.Medium;

public class GenerateParenthesis
{
    public List<string> Solution(int n)
    {
        var stack = new List<string>();
        _GenerateParenthesis(stack, "(", 1, 0, n);
        
        return stack;
    }

    private void _GenerateParenthesis(List<string> stack, string str, int openedParentheses, int closedParentheses, int n)
    {
        if (str.Length == n * 2)
        {
            stack.Add(str);
            return;
        }

        if (openedParentheses < n) _GenerateParenthesis(stack, $"{str}(", openedParentheses + 1, closedParentheses, n);
        if (openedParentheses > closedParentheses) _GenerateParenthesis(stack, $"{str})", openedParentheses, closedParentheses + 1, n);
    }
}
