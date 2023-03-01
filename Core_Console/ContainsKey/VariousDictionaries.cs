using System.Collections;

namespace Core_Console.ContainsKey;

public class VariousDictionaries
{
    public const int Key = 1;

    public void Test(IDictionary<int, MyInnerClass> dictionary, MyInnerClass? parameter)
    {
        if (parameter != null)
        {
            if (dictionary.ContainsKey(Key))
            {
                dictionary[Key] = parameter;
            }
            else
            {
                dictionary.Add(Key, parameter);
            }
        }
    }

    public void Test2<T>(UserDefinedIDictionary<T, MyInnerClass> dictionary, MyInnerClass? parameter, T key) {
        if (parameter != null)
        {
            key = default!;
            if (dictionary.ContainsKey(key)) {
                dictionary[key] = parameter;
            }
            else {
                dictionary.Add(key, parameter);
            }
        }
    }
}

public class MyInnerClass
{
    public MyInnerClass(string name, int count)
    {
        Name = name;
        Count = count;
    }

    public string Name { get; set; }
    public int Count { get; set; }
}

public class UserDefinedIDictionary<T,U> :IDictionary<T,U>
{
    public IEnumerator<KeyValuePair<T, U>> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(KeyValuePair<T, U> item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(KeyValuePair<T, U> item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(KeyValuePair<T, U>[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(KeyValuePair<T, U> item)
    {
        throw new NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public void Add(T key, U value)
    {
        throw new NotImplementedException();
    }

    public bool ContainsKey(T key)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T key)
    {
        throw new NotImplementedException();
    }

    public bool TryGetValue(T key, out U value)
    {
        throw new NotImplementedException();
    }

    public U this[T key]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public ICollection<T> Keys { get; }
    public ICollection<U> Values { get; }
}