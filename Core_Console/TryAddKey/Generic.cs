namespace Core_Console.TryAddKey;

public class Generic<T,U> where U:BaseClass, new() where T : new()
{
    public BaseClass Test(T key, BaseClass s1)
    {
        Dictionary<T, BaseClass> dictionary = GetDictionary();

        var _key = new T();
        s1 = dictionary.ContainsKey(_key) switch
        {
            //case false:
            //    dictionary.Add(_key, new U());
            //    break;
            true => dictionary[_key],
            _ => s1
        };

        return s1;
    }

    private static Dictionary<T, BaseClass> GetDictionary()
    {
        return new Dictionary<T, BaseClass>();
    }
}

public class BaseClass
{
    //public BaseClass()
    //{
    //}

    public string Name { get; set; }
}