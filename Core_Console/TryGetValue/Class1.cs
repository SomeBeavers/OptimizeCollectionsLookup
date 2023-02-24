namespace Core_Console.TryGetValue;

public class Class1
{
    private readonly string _s;

    // ReSharper disable once CollectionNeverUpdated.Local
    private readonly Dictionary<string, string> _dictionary = new();

    public Class1(string s)
    {
        _s = s;
    }

    public string? GetValue(string? key)
    {
        return _dictionary.ContainsKey(key) ? _dictionary[key] : null;
    }
}