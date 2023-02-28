using System.Collections.Generic;

namespace Framework_Lib.ContainsKey
{
    public class ContainsKey1
    {
        private Dictionary<int, int> _d = new Dictionary<int, int>();

        public void Test()
        {
            if (_d.ContainsKey(1)) {
                _d[1] = 1;
            }
            else {
                _d.Add(1, 1);
            }
        }
    }
}