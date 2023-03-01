using System.Diagnostics.Contracts;


namespace Core_Console.ContainsKey;

public class VariousAddKey
{
    private Dictionary<int, int> _dictionary = new();

    public void Test()
    {
        if (_dictionary.ContainsKey(1))
        {
            _dictionary[1] = 2;
        }
        else
        {
            _dictionary.Add(1, 2);
        }

        if (_dictionary.ContainsKey(1))
        {
            _dictionary.TryGetValue(1, out var value);
            // update
            _dictionary[1] = 2;
        }
        else
        {
            // add key-value pair
            _dictionary.TryAdd(1, 2);
            _dictionary[1] = 2;
        }
    }

    public void Test2(int parameter, List<int> list)
    {
        if (_dictionary.ContainsKey(Key()))
        {
            _dictionary[Key()] = parameter;
        }
        else
        {
            _dictionary.Add(Key(), parameter);
        }

        if (!_dictionary.ContainsKey(PropertyKey) is true)
        {
            _dictionary.Add(PropertyKey, list.MyExt());
        }
        else {
            _dictionary[PropertyKey] = list.MyExt();
        }


        foreach (var _i in list)
        {
            Console.WriteLine(_i);

            void LocalFunction(int localFunctionParameter)
            {
                if (true)
                {
                    _dictionary = null;
                    if (_dictionary.ContainsKey(key: _i))
                    {
                        _dictionary[_i] = parameter;
                    }
                    else
                    {
                        _dictionary.Add(_i, parameter);
                    }
                }
            }

            LocalFunction(1);
        }

        //var _parameter = 
        //    _dictionary.ContainsKey(PropertyKey) ? 
        //        _dictionary[PropertyKey] = parameter 
        //        : _dictionary.Add(PropertyKey,parameter);
    }

    public int PropertyKey { get; set; }

    private static int Key()
    {
        return 1;
    }
}

public static class MyListExtensions
{
    [Pure]
    public static int MyExt(this List<int> list)
    {
        return 1;
    }
}