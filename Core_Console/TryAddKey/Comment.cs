namespace Core_Console.TryAddKey;

public class Comment
{
    public string Test(Dictionary<int, string> dictionary)
    {
        // 1
        if (!dictionary.ContainsKey(1))
        {
            //2
            //3
            /*4*/
            dictionary.Add(1, "1"); //5
            //6
            //Console.WriteLine(dictionary[1]);
        }

        return 2.ToString();
    }
}