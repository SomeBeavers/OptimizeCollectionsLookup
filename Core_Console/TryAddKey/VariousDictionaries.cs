using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data.Common;

namespace Core_Console.TryAddKey;

public class VariousDictionaries
{
    private readonly IDictionary<int, string> _dictionary = new Dictionary<int, string>();

    public void Test()
    {
        if (!_dictionary.ContainsKey(1))
        {
            _dictionary.Add(1, "1");
        }


        SortedList<int, int> list = new();

        if (!list.ContainsKey(1))
        {
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

        if (orderedDictionary.Contains(1))
        {
            var s = orderedDictionary[1];
        }

        if (!orderedDictionary.Contains(1))
        {
            orderedDictionary.Add(1, "1");
        }


        HybridDictionary hybridDictionary = new();
        if (!hybridDictionary.Contains(1))
        {
            hybridDictionary.Add(1, "1");
        }

        if (hybridDictionary.Contains(1))
        {
            var s = hybridDictionary[1];
        }

        ListDictionary listDictionary = new();

        if (!listDictionary.Contains(1)) {
            listDictionary.Add(1, "1");
        }

        if (listDictionary.Contains(1)) {
            var s = listDictionary[1];
        }

        ReadOnlyDictionary<int, string> readOnlyDictionary = new(new Dictionary<int, string>());

        if (!readOnlyDictionary.ContainsKey(1)) {
            readOnlyDictionary.TryAdd(1, "1");
        }

        if (readOnlyDictionary.ContainsKey(1)) {
            var s = readOnlyDictionary[1];
        }

        SortedDictionary<int, string> sortedDictionary = new();

        if (!sortedDictionary.ContainsKey(1)) {
            sortedDictionary.Add(1, "1");
        }

        if (sortedDictionary.ContainsKey(1)) {
            var s = sortedDictionary[1];
        }

        ConcurrentDictionary<int, string> concurrentDictionary = new();

        if (!concurrentDictionary.ContainsKey(1)) {
            concurrentDictionary.TryAdd(1, "1");
        }

        if (concurrentDictionary.ContainsKey(1)) {
            var s = concurrentDictionary[1];
        }

        Hashtable hashtable = new();

        if (!hashtable.ContainsKey(1)) {
            hashtable.Add(1, "1");
        }

        if (hashtable.ContainsKey(1)) {
            var s = hashtable[1];
        }

        DbConnectionStringBuilder dbConnectionStringBuilder = new();

        if (!dbConnectionStringBuilder.ContainsKey(1.ToString())) {
            dbConnectionStringBuilder.Add(1.ToString(), "1");
        }

        if (dbConnectionStringBuilder.ContainsKey("1")) {
            var s = dbConnectionStringBuilder["1"];
        }

        dbConnectionStringBuilder.TryGetValue("1", out var s1);
    }
}