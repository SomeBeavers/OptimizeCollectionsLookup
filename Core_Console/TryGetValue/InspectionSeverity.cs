using System.Collections.ObjectModel;

namespace Core_Console.TryGetValue;

public class InspectionSeverity
{
    public void Test(IDictionary<int, string> readOnlyCollection)
    {
        if (readOnlyCollection.ContainsKey(1))
        {
            var v = readOnlyCollection[1];
        }
    }
}