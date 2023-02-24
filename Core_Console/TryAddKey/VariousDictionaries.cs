using System.Collections.Immutable;
using System.Collections.Specialized;

namespace Core_Console.TryAddKey
{
    public class VariousDictionaries
    {
        IDictionary<int, string> _dictionary = new Dictionary<int, string>();

        public void Test()
        {
            if (!_dictionary.ContainsKey(1)) {
                _dictionary.Add(1, "1");
            }


            SortedList<int, int> list = new();

            if (!list.ContainsKey(1)) {
                list.Add(1, 1);
            }

            if (list.ContainsKey(1))
            {
                var s = list[1];
            }

            var immutableDictionary = ImmutableDictionary<int, int>.Empty;

            if (!immutableDictionary.ContainsKey(1))
            {
                var _immutableDictionary = immutableDictionary.Add(1, 1);
            }

            OrderedDictionary orderedDictionary = new();

            if (orderedDictionary.Contains(1)) {
                var s = orderedDictionary[1];
            }

            if (!orderedDictionary.Contains(1)) {
                orderedDictionary.Add(1, "1");
            }
        }
    }
}