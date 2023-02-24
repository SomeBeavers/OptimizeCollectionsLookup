namespace Core_Console.TryGetValue;

public class Keys
{
    Dictionary<(int, string), int> dictionary = new();
    private (int, string) _valueTuple;

    public void Test(Dictionary<(int, string), int> anotherDictionary)
    {
        if (dictionary.ContainsValue(1))
        {
            _valueTuple = (1, "1");
            if (dictionary.ContainsKey(_valueTuple))
            {

                dictionary.TryGetValue(_valueTuple, out var v);
                //v = dictionary[_valueTuple];

                Console.WriteLine(v);

                dictionary = anotherDictionary;
                v = dictionary[_valueTuple];
            }
            dictionary[key: (1, "2")] = 1;

        }
    }
}