namespace Core_Console;

public class QF
{
    public int GetTestCount
    {
        get
        {
            if (MyDictionary.ContainsKey(Key)) return MyDictionary[Key];

            var count = 0;
            return count;
        }
        set
        {
            const int count = 0;
            if (MyDictionary.ContainsKey(count))
            {
                value = MyDictionary[count];
            }
            else
            {
                
                value = count;
            }

            Console.WriteLine(value);
        }
    }

    public int Key { get; }

    public Dictionary<int, int> MyDictionary { get; set; }
}