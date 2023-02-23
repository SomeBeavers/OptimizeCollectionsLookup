using System.Collections;
using System.Collections.Concurrent;

namespace Core_Console;

public class VariousIDictionaries
{
    private static readonly string Key = "key";
    public Dictionary<string, MyClass?> MyClasses { get; set; }

    public async Task Test1(ConcurrentDictionary<MyClass, MyAnotherClass?> dictionary, MyClass? myClass)
    {
        Test2(dictionary);
        if (myClass != null && dictionary.ContainsKey(myClass))
        {
            var s = dictionary[myClass]!.ToString() ?? "";
        }

        if (dictionary.ContainsKey(myClass))
        {
            var s = dictionary[myClass]!.ToString() ?? "";
        }

        if (dictionary.ContainsKey(myClass))
        {
            var myAnotherClass = dictionary[myClass];
        }
    }

    private void Test2(IDictionary<MyClass, MyAnotherClass?> myCoolClasses)
    {
        MyClass myClass = new();
        MyAnotherClass? myAnotherClass;

        //foreach (var   in myCoolClassesDictionary.Values)
        //{

        //}


        if (myCoolClasses.ContainsKey(myClass) /*caret*/) myAnotherClass = myCoolClasses[myClass];
    }

    public void Test3()
    {
        if (MyClasses.ContainsKey(Key) /*caret*/)
        {
            var myClass = MyClasses[Key];
        }
    }

    public void Test4<T, U>(MyGenericDictionary<(int, T), U> dictionary, (int, T key) parameter, T key) 
    {
        if (dictionary.ContainsKey(parameter)/*caret*/) {
            var myClass = dictionary[parameter];
        }

        var _valueTuple = (1, key);
        if (dictionary.ContainsKey(_valueTuple)/*caret*/) {
            var myClass = dictionary[_valueTuple];
        }
    }
}

#region Classes

public class MyGenericDictionary<T,U>:IDictionary<T,U>
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

public class MyAnotherClass
{
}

public class MyClass
{
}

#endregion
