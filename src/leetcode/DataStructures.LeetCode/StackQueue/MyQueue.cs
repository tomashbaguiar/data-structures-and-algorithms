namespace DataStructures.LeetCode.StackQueue;

public class MyQueue
{
    private readonly Stack<int> _mainStack = new();
    private readonly Stack<int> _secondStack = new();
    
    public void Push(int item)
    {
        _mainStack.Push(item);
    }

    public int Peek()
    {
        while (_mainStack.Count != 0) _secondStack.Push(_mainStack.Pop());
        var item = _secondStack.Peek();
        while (_secondStack.Count != 0) _mainStack.Push(_secondStack.Pop());

        return item;
    }

    public int Pop()
    {
        while (_mainStack.Count != 0) _secondStack.Push(_mainStack.Pop());
        var item = _secondStack.Pop();
        while (_secondStack.Count != 0) _mainStack.Push(_secondStack.Pop());

        return item;
    }

    public bool Empty()
    {
        return _mainStack.Count == 0;
    }
}