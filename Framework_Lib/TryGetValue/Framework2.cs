using System.Collections.Generic;

namespace Framework_Lib
{
    
    public class Framework2
    {
        IDictionary<string, string> _dictionary = new Dictionary<string, string>();

        public string GetValue(string key)
        {
            if (_dictionary.ContainsKey(key))
                return _dictionary[key];
            else
                return null;
        }
    }
}