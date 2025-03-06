namespace HW4;

public class MyStack<T>
{
    private List<T> items;

    public MyStack()
    {
        items = new List<T>();
    }

    public int Count()
    {
        return items.Count;
    }

    public void Push(T item)
    {
        items.Add(item);
        Console.WriteLine($"Pushed: {item}");
    }

    public T Pop()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        T topItem = items[^1];
        items.RemoveAt(items.Count - 1);
        
        Console.WriteLine($"Popped: {topItem}");
        return topItem;
    }
}