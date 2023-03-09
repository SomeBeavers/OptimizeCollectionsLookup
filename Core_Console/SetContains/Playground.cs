namespace Core_Console.SetContains;

public class Playground<T>
{
    public void Test(SortedSet<T>? mySet, T? key)
    {
        // comment

        if (mySet is not null && (key is { } && !mySet.Contains(key)))
        {
            // 1
            //mySet.Add(key);
            mySet.Add(key);
            // 2

            // 3
        }
        //else
        //{
        //    Console.WriteLine("null!!");
        //}
    }
}