using System.Collections.Generic;

namespace Framework_Lib.TryAddKey
{
    public class VariousDictionaries
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        public bool Test()
        {
            if (!dictionary.ContainsKey(1))
            {
                dictionary.Add(1, "1");
                return false;
            }

            return true;
        }
    }
}