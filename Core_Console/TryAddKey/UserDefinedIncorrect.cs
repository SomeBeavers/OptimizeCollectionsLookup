namespace Core_Console.TryAddKey;

public class UserDefinedIncorrect
{
    public void Test(Dictionary dictionary)
    {
        if (!dictionary.ContainsKey(1)) {
            dictionary.Add(1, "1");
        }

        if (dictionary.ContainsKey(1)) {
            var s = dictionary[1];
        }
    }

    public class Dictionary
    {
        public bool ContainsKey(int i)
        {
            throw new NotImplementedException();
        }

        public void Add(int i, string s)
        {
            throw new NotImplementedException();
        }

        public bool TryAdd(int i, string s)
        {
            throw new NotImplementedException();
        }

        public object this[int i]
        {
            get { throw new NotImplementedException(); }
        }
    }
}