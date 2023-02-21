namespace Core_Console;

public class QF
{


    public int GetCount
    {
        get
        {
            if (MyDictionary.ContainsKey(Key))
            {
                return MyDictionary[Key];
            }
            return 0;
        }
        set => throw new NotImplementedException();
    }

    public int Key { get; }

    public Dictionary<int, int> MyDictionary { get; set; }
}

