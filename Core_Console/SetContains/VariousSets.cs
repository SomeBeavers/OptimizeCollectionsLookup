using System.Collections;
using System.Collections.Immutable;

namespace Core_Console.SetContains;

public class VariousSets
{
    public void Test(SortedSet<MyInnerClass> set, MyInnerClass key)
    {
        if (!set.Contains(key))
        {
            set.Add(key);
        }
    }

    public void Test2(ISet<MyInnerClass> set, MyInnerClass key)
    {
        if (!set.Contains(key))
        {
            set.Add(key);
        }
    }

    public void Test3(HashSet<MyInnerClass> set, MyInnerClass key)
    {
        if (!set.Contains(key))
        {
            var isAdded = set.Add(key);
        }
    }

    public void Test4(ImmutableHashSet<MyInnerClass> set, MyInnerClass key)
    {
        if (!set.Contains(key))
        {
            set.Add(key);
        }
        else
        {
            //test
        }
    }

    public void Test5<T>(UserDefinedSet<T> set, T key) {
        if (!set.Contains(key))
        {
            //var s = 1;
            set.Add(key);
        }
        else
        {
            Console.WriteLine(set[key]);
        }
    }
}

public class MyInnerClass
{
    public int MyProperty { get; set; }
}

public class UserDefinedSet<T>:ISet<T>
{
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public void ExceptWith(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public void IntersectWith(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public bool IsProperSubsetOf(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public bool IsProperSupersetOf(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public bool IsSubsetOf(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public bool IsSupersetOf(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public bool Overlaps(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public bool SetEquals(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public void SymmetricExceptWith(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    public void UnionWith(IEnumerable<T> other)
    {
        throw new NotImplementedException();
    }

    bool ISet<T>.Add(T item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }

    public bool this[object key]
    {
        get { throw new NotImplementedException(); }
    }
}