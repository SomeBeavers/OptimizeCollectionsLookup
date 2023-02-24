using System.Collections.Generic;

namespace Framework_Lib.TryAddKey
{
    public class VariousDictionaries
    {
        IDictionary<int, string> dictionary = new Dictionary<int, string>();

        public void Test()
        {
            if (!dictionary.ContainsKey(1)) {
                dictionary.Add(1, "1");
            }

        }
    }
}