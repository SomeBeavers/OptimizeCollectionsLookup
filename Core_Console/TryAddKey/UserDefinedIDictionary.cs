using System.Collections;

namespace Core_Console.TryAddKey;

public class UserDefinedIDictionary
{
    public void Test(MyIDictionary<int, string> myIDictionary, MyDictionary<int, string> myDictionary)
    {
        if (!myIDictionary.ContainsKey(1)) {
            myIDictionary.Add(1, "1");
        }

        if (myIDictionary.ContainsKey(1)) {
            var s = myIDictionary[1];
        }

        if (!myDictionary.ContainsKey(1)) {
            myDictionary.Add(1, "1");
        }
    }
}

public class MyDictionary<T, U> : Dictionary<T, U>
{
    public new bool TryAdd(T key, U value) {
        Console.WriteLine("MyDictionary.TryAdd");
        return true;
    }


    //public bool Add(T key, U value) {
    //    return true;
    //}
}

public class MyIDictionary<T, U>:IDictionary<T, U>
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