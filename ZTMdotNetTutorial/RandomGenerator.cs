namespace ZTMdotNetTutorial;

public class RandomGenerator<T>
{
    private readonly List<T> _items = new List<T>();
    private readonly Random _random = new Random();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T Get()
    {
        var index = _random.Next(0, _items.Count);
        return _items[0];
    }
}