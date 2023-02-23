using System.Collections.Concurrent;
using Core_Console;

Dictionary<int, int> identifiersCache = new();
MyInnerClass myInnerClass = new MyInnerClass(){Name = "Name"};
var _myInnerClasses = new ConcurrentDictionary<string, MyInnerClass?>();
_myInnerClasses.TryAdd(myInnerClass.Name, myInnerClass);
await new UseAsync().Test1(_myInnerClasses, myInnerClass);



int GetIdentifier(int key)
{
    if (identifiersCache.ContainsKey(key)) return identifiersCache[key];
    
    if (identifiersCache.ContainsKey(key))
    {
        var v1 = 0;
        int v;
        v = identifiersCache[key];
    }

    
    var b = true;
    if (b == true)
    {
        return 1;
    }

    return 323;
}