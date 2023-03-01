namespace Core_Console.SetContains;

public class SetContains1
{
    public void Test(int x)
    {
        HashSet<int> set = new();
        int key = 1;
        int value = 2;
        if (set.Contains(key)) {
            set.Add(value);
        }
        else {
            set.Add(key);
        }



        HashSet<int> hs = new HashSet<int>();

        if (!hs.Contains(x)) {
            hs.Add(x);
        }
        
        // ReSharper disable once RedundantSetContainsBeforeAdding
        if (!hs.Contains(x)) {
            hs.Add(x);
        }

    }
}