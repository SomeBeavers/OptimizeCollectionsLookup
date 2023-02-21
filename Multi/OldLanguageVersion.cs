using System;
using System.Collections.Generic;

namespace Multi
{
    public class OldLanguageVersion
    {
        public void Test(IDictionary<string, string> dictionary, string parameter)
        {
            foreach (var item in dictionary)
            {
                if (dictionary.ContainsKey(item.Key))
                {
                    var key = item.Key;
                }
                var value = item.Value;
            }

            string myTestKey;
            //comment
            if (dictionary.ContainsKey(parameter) == true)
            {
               // dictionary.Add("key", "value");
                //var myTestKey = dictionary[parameter];
                //var myTestKey2 = dictionary[parameter];
                
                var keysCount = dictionary.Keys.Count;
                
                myTestKey = dictionary[parameter];
                //myTestKey = "test";
                Console.WriteLine(myTestKey);
            }
        }
    }
}