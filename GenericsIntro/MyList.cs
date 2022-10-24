namespace GenericsIntro;

public class MyList<T>
{
    private T[] _items;

    public MyList()
    {
        _items = Array.Empty<T>();
    }
    public void Add(T item)
    {
        T[] tempArray = _items;
        _items = new T[_items.Length + 1];
        for (int i = 0; i < tempArray.Length; i++)
        {
            _items[i] = tempArray[i];
        }

        _items[_items.Length - 1] = item;
        
    }

    public void ListItems()
    {
        Console.WriteLine(string.Join(',', _items));
    }

    public override string ToString()
    {
        return string.Join(',', _items);
    }
}