using System.Text;

namespace GenericsIntro;

public class MyDictionary<TKey,TValue>
{
    private TKey[] _keys;
    private TValue[] _values;
    
    public MyDictionary()
    {
        _keys = Array.Empty<TKey>();
        _values = Array.Empty<TValue>();
    }

    public void Add(TKey key, TValue value)
    {
        TKey[] tempKeyArray = _keys;
        TValue[] tempValueArray = _values;

        _keys = new TKey[_keys.Length + 1];
        _values = new TValue[_values.Length + 1];

        for (int i = 0; i < tempKeyArray.Length; i++)
        {
            _keys[i] = tempKeyArray[i];
        }

        _keys[_keys.Length - 1] = key;

        for (int i = 0; i < tempValueArray.Length; i++)
        {
            _values[i] = tempValueArray[i];
        }

        _values[_values.Length - 1] = value;
    }

    public TValue Get(TKey key)
    {
        var index = Array.FindIndex(_keys, s => Equals(s, key));
        return _values[index];
    }
    
    

    public override string ToString()
    {
        var a = new StringBuilder();
        for (int i = 0; i < _keys.Length; i++)
        {
            a.Append($"{_keys[i]} => {_values[i]}\n");
            
        }

        return a.ToString();
    }
    
}