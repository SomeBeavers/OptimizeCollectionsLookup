namespace Core_Console;

public class Class1
{
    // ReSharper disable once CollectionNeverUpdated.Local
    private readonly Dictionary<string, string> _dictionary = new();

    public string? GetValue(string key)
    {
        return _dictionary.ContainsKey(key) ? _dictionary[key] : null;
    }
}