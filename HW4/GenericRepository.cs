using HW4.Repository;

namespace HW4;

public class GenericRepository<T> : IRepository<T> where T : Entity, IRepository<T>
{
    private readonly List<T> _items = new List<T>();
    
    public void Add(T item)
    {
        _items.Add(item);
        Console.WriteLine($"Added {typeof(T).Name} with ID {item.Id}");
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }

    public void Save()
    {
        // need database
        Console.WriteLine($"Changes saved successfully for {typeof(T).Name}.");
    }

    public IEnumerable<T> GetAll()
    {
        return _items;
    }

    public T GetById(int id)
    {
        return _items.FirstOrDefault(i => i.Id == id);
    }
}