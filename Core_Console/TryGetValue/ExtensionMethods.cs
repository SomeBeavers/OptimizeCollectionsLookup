using JetBrains.Annotations;

namespace Core_Console.TryGetValue;

public static class ExtensionMethods
{
    [CollectionAccess(CollectionAccessType.UpdatedContent)]
    public static int MyExtension(this IDictionary<string, string> dictionary)
    {
        dictionary.Remove("key2");
        return 0;
    }
}