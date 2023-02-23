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

    private void Test2(IDictionary<MyClass, MyAnotherClass?> myCoolClasses)
    {
        MyClass myClass = new();
        MyAnotherClass? myAnotherClass;

        //foreach (var   in myCoolClassesDictionary.Values)
        //{
            
        //}


        if (myCoolClasses.ContainsKey(myClass)/*caret*/)
        {
            myAnotherClass = myCoolClasses[myClass];
        }
    }
}

public class MyAnotherClass
{
}

public class MyClass
{
}