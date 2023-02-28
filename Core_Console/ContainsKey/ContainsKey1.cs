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
            d.Add(key, value);
        }
    }
}