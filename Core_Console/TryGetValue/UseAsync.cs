using System.Collections.Concurrent;
using JetBrains.Annotations;

namespace Core_Console.TryGetValue;

public class UseAsync
{
    public async Task Test1(ConcurrentDictionary<string, MyInnerClass?> dictionary, MyInnerClass myClass)
    {
        MyInnerClass? _myInnerClass = null;

        async Task NewFunction()
        {
            if (dictionary.ContainsKey(myClass.Name))
            {
                await ChangeDictionary(dictionary);

                var _myInnerClass = dictionary[myClass.Name];
                Console.WriteLine(_myInnerClass.Name);
            }
        }

        Console.WriteLine(_myInnerClass);

        await NewFunction();
    }

    [CollectionAccess(CollectionAccessType.UpdatedContent)]
    private async Task ChangeDictionary(ConcurrentDictionary<string, MyInnerClass?> dictionary)
    {
        dictionary = null;
        await Task.Delay(100);
    }
}

public class MyInnerClass
{
    public string Name { get; set; }
}