Dictionary<int, int> identifiersCache = new();

int GetIdentifier(int key)
{
    if (identifiersCache.ContainsKey(key)) return identifiersCache[key];
    
    if (identifiersCache.ContainsKey(key))
    {
        var v1 = 0;
        int v;
        v = identifiersCache[key];
        Console.WriteLine(v);
        Console.WriteLine(v);
    }

    
    var b = true;
    if (b == true)
    {
        return 1;
    }

    return 323;
}