using System.Collections.Concurrent;

namespace Core_Console;

public class VariousIDictionaries
{
    public async Task Test1(ConcurrentDictionary<MyClass, MyAnotherClass?> dictionary, MyClass? myClass)
    {
        Test2(dictionary);
        if (myClass != null && dictionary.ContainsKey(myClass))
        {
            var s = (dictionary[myClass]!.ToString() ?? "");
        }
        
        if (dictionary.ContainsKey(myClass))
        {
            var s = (dictionary[myClass]!.ToString() ?? "");
        }

        if (dictionary.ContainsKey(myClass))
        {
            var myAnotherClass = dictionary[myClass];
        }
    }

    private void Test2(IDictionary<MyClass, MyAnotherClass?> myClassesDictionary)
    {
        MyClass myClass = new();
        MyAnotherClass? myAnotherClass;

        //foreach (var   in myClassesDictionary.Values)
        //{
            
        //}


        if (myClassesDictionary.ContainsKey(myClass)/*caret*/)
        {
            myAnotherClass = myClassesDictionary[myClass];
        }
    }
}

public class MyAnotherClass
{
}

public class MyClass
{
}