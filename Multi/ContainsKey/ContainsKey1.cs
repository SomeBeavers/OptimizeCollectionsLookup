using System.Collections.Generic;

namespace Multi.ContainsKey
{
    public class ContainsKey1
    {
        private readonly Dictionary<int, int> _d = new Dictionary<int, int>();

        public void Test(int key = 1)
        {
#if NET6_0
            if (_d.ContainsKey(key)) {

                _d[key] = 2;

            }
#endif
            if (_d.ContainsKey(key)) {

                _d[key] = 2;

            }
            else {
                _d.Add(key, 2);
            }
        }
    }
}