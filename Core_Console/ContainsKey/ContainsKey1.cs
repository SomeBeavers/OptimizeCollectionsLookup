namespace Core_Console.ContainsKey;

public class ContainsKey1
{
    public void Test(int key, int value)
    {
        Dictionary<int, int> d = new();

        if (d.ContainsKey(key))
        {
            d[key] = value;
        }
        else
        {
            d.TryAdd(key, value);
        }

        // ReSharper disable RedundantDictionaryContainsKeyBeforeAdding
        if (d.ContainsKey(key))
            // ReSharper restore RedundantDictionaryContainsKeyBeforeAdding
        {
            d[key] = value;
        }
        else
        {
            d.Add(key, value);
        }
    }
}