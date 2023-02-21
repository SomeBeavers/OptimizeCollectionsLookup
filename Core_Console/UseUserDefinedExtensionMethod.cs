namespace Core_Console;

public class UseUserDefinedExtensionMethod
{
    public void Test()
    {
        IDictionary<string, string> dictionary = new Dictionary<string, string>();

        dictionary.Add("key2", "value");

        if (dictionary.ContainsKey("key2") == true)
        {
            //dictionary.Add("key2", "value");
            dictionary.MyExtension();
            var s = dictionary["key2"];

            Console.WriteLine(s);
        }
    }
}