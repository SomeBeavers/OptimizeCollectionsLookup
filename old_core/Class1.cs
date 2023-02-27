using System;
using System.Collections.Generic;

namespace old_core {
    public class Class1 {
        public void Test()
        {
            var dictionary = new Dictionary<int, string>();
            if (!dictionary.ContainsKey(1)) {
                dictionary.Add(1, "1");
            }

            if (dictionary.ContainsKey(1)) {
                var s = dictionary[1];
            }
        }
    }
}
