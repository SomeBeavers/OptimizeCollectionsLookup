using System.Collections.Generic;

namespace Multi.TryAddKey
{
    public class Multi_TryAddKey
    {
        public void Test(Dictionary<int, string> dictionary)
        {
            if (dictionary != null && !dictionary.ContainsKey(1)) {
                dictionary.Add(1, "1");
            }
            if (dictionary?.ContainsKey(2) != true) {
#if NET6_0
                dictionary?.Add(2, "2");
#else
                dictionary?.Add(2, "2");
#endif
                dictionary?.Add(2, "2");
            }
            if (dictionary?.ContainsKey(3) != true) {
                dictionary?.Add(3, "3");
            }
            if (dictionary?.ContainsKey(4) != true) {
                dictionary?.Add(4, "4");
            }
            if (dictionary?.ContainsKey(5) != true) {
                dictionary?.Add(5, "5");
            }
            if (dictionary?.ContainsKey(6) != true) {
                dictionary?.Add(6, "6");
            }
            if (dictionary?.ContainsKey(7) != true) {
                dictionary?.Add(7, "7");
            }
            if (dictionary?.ContainsKey(8) != true) {
                dictionary?.Add(8, "8");
            }
            if (dictionary?.ContainsKey(9) != true) {
                dictionary?.Add(9, "9");
            }
            if (dictionary?.ContainsKey(10) != true) {
                dictionary?.Add(10, "10");
            }
            if (dictionary?.ContainsKey(11) != true) {
                dictionary?.Add(11, "11");
            }
            if (dictionary?.ContainsKey(12) != true) {
                dictionary?.Add(12, "12");
            }
            if (dictionary?.ContainsKey(13) != true) {
                dictionary?.Add(13, "13");
            }
            if (dictionary?.ContainsKey(14) != true) {
                dictionary?.Add(14, "14");
            }
            if (dictionary?.ContainsKey(15) != true) {
                dictionary?.Add(15, "15");
            }
            if (dictionary?.ContainsKey(16) != true) {
                dictionary?.Add(16, "16");
            }
            if (dictionary?.ContainsKey(17) != true) {
                dictionary?.Add(17, "17");
            }
            if (dictionary?.ContainsKey(18) != true) {
                dictionary?.Add(18, "18");
            }
        }
    }
}