namespace Core_Console.TryAddKey;

public class VariousKeys
{
    public void Test(Dictionary<(int, string), MyInnerClass> dictionary)
    {
        var _myInnerClass = new MyInnerClass();
        if (!dictionary.ContainsKey((1, "1")))
        {
            dictionary.Add((1, "1"), _myInnerClass);
        }

        if (dictionary.ContainsKey((1, "1")))
        {
            var s = dictionary[(1, "1")];
        }
    }

    public void Test2(Dictionary<string, MyInnerClass> dictionary, string key = "1")
    {
        var _myInnerClass = new MyInnerClass();
        if (!dictionary.ContainsKey(key))
        {
            dictionary.Add(key, _myInnerClass);
        }
        if (!dictionary.ContainsKey(key))
        {
            dictionary.Add(key, _myInnerClass);
        }
        if (!dictionary.ContainsKey(key))
        {
            dictionary.Add(key, _myInnerClass);
        }

        if (dictionary.ContainsKey(key))
        {
            var s = dictionary[key];
        }
    }
}