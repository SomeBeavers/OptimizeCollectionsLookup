using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Framework_Lib
{
    public class Play1
    {
        private readonly string _s;

        public Play1(int key = 1)
        {
            IDictionary<int, string> _dictionary = new Dictionary<int, string>();
            if (((Dictionary<int, string>)_dictionary).ContainsKey(key))
            {
                _s = _dictionary[key];
            }
            if ((_dictionary).ContainsKey(key))
            {
                _s = _dictionary[key];
            }
        }

        public void Test()
        {
            return;
        }



    public class MyInnerClass
    {
    }
}
}