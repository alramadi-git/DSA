namespace NeetCode.Stack.Medium;

public class MinStack
{
    private Stack<int> _Stack;
    private Stack<int> _MinValue;

    public MinStack()
    {
        _Stack = new Stack<int>();
        _MinValue = new Stack<int>();
    }

    public void Push(int val)
    {
        _Stack.Push(val);

        if (_MinValue.Count == 0) _MinValue.Push(val);
        else
        {
            var minValue = _MinValue.Peek();
            if (val <= minValue) _MinValue.Push(val);
        }
    }

    public void Pop()
    {
        if (_MinValue.Peek() == _Stack.Pop()) _MinValue.Pop();
    }

    public int Top()
    {
        return _Stack.Peek();
    }

    public int GetMin()
    {
        return _MinValue.Peek();
    }
}
