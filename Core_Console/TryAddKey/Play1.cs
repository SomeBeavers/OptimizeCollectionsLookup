using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public static class MyClass
    {
        static void Main()
        {
            Dictionary<int, int> d = new();

            // A) Check the negative returned value
            // Before
            if (!d.ContainsKey(5))
            {
                d.Add(5, 6);
            }

            // After
            d.TryAdd(5, 6);


            // B) Check the negative returned value and preserve existing logic inside the if body
            // Before
            if (!d.ContainsKey(5))
            {
                d.Add(5, 6);
                Console.WriteLine($"Value: {d[5]}");
            }

            // After
            if (d.TryAdd(5, 6))
            {
                Console.WriteLine($"Value: {d[5]}");
            }

            // C) Check the positive returned value and preserve existing logic in the else bodyif there's one
            // Before
            if (d.ContainsKey(5))
            {
                Console.WriteLine($"Value existed: {d[5]}");
            }
            else
            {
                d.Add(5, 6);
                Console.WriteLine($"Value added: {d[5]}");
            }

            // After
            if (!d.TryAdd(5, 6))
            {
                Console.WriteLine($"Value existed: {d[5]}");
            }
            else
            {
                Console.WriteLine($"Value added: {d[5]}");
            }


            if (!d.ContainsKey(5))
            {
                d[5] = ComputeExpensiveValue(); // expensive computation guarded within ContainsKey check
            }
        }

        private static int ComputeExpensiveValue()
        {
            throw new NotImplementedException();
        }
    }
}