using System.Collections.Concurrent;

namespace Core_Console1;

public class VariousIDictionaries
{
    public void Test1(ConcurrentDictionary<MyClass, MyAnotherClass?> dictionary, MyClass? myClass)
    {
        Test2(dictionary);
        if (myClass != null && dictionary.TryGetValue(myClass, out var VALUE))
        {
            var s = (VALUE!.ToString() ?? "");
        }
    }

    private void Test2(IDictionary<MyClass, MyAnotherClass?> dictionary)
    {
        
    }
}

public class MyAnotherClass
{
}

public class MyClass
{
}