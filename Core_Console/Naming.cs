namespace Core_Console;

public class Naming
{
    public void GetMyCollections(Dictionary<string, string> dictionary)
    {
        if (dictionary.ContainsKey("key") /*caret*/)
        {
            var _myCollections = dictionary["key"];
            Console.WriteLine(_myCollections);
        }
    }
}