namespace Core_Console.TryAddKey;

public class VariousCollections
{
    private Dictionary<int, string>? _dictionary = new Dictionary<int, string>();

    public void Test()
    {

        HashSet<int>? hs = new();

        if (!hs.Contains(1))
        {
            hs.Add(1);
        }


        void NewFunction()
        {
            if (_dictionary.ContainsKey(2) == false)
            {
                // comment
                _dictionary.Add(2, "2");/*comment 3*/
                // comment 2
            }
        }

        if (_dictionary != null && !_dictionary.ContainsKey(1)) {
            _dictionary.Add(1, "1");
        }
        NewFunction();
        if (_dictionary?.ContainsKey(3) != true) {
            _dictionary?.Add(3, "3");
        }
        if (_dictionary.ContainsKey(4)) {
            _dictionary.Add(4, "4");
        }
        if (_dictionary.ContainsKey(5)) {
            _dictionary.Add(5, "5");
        }
        if (_dictionary.ContainsKey(6)) {
            _dictionary.Add(6, "6");
        }

     
        _dictionary.Add(8, "8");
        _dictionary.Add(9, "9");
        _dictionary.Add(10, "10");
        _dictionary.Add(11, "11");
        _dictionary.Add(12, "12");
        _dictionary.Add(13, "13");
        _dictionary.Add(14, "14");
        _dictionary.Add(15, "15");
        _dictionary.Add(16, "16");
        _dictionary.Add(17, "17");
        _dictionary.Add(18, "18");
        _dictionary.Add(19, "19");
        _dictionary.Add(20, "20");
        _dictionary.Add(21, "21");
        _dictionary.Add(22, "22");
        _dictionary.Add(23, "23");
        _dictionary.Add(24, "24");
        _dictionary.Add(25, "25");
        _dictionary.Add(26, "26");
        _dictionary.Add(27, "27");
        _dictionary.Add(28, "28");
        _dictionary.Add(29, "29");
        _dictionary.Add(30, "30");
        _dictionary.Add(31, "31");
        _dictionary.Add(32, "32");
        _dictionary.Add(33, "33");
        _dictionary.Add(34, "34");
        _dictionary.Add(35, "35");
        _dictionary.Add(36, "36");
        _dictionary.Add(37, "37");
        _dictionary.Add(38, "38");
        _dictionary.Add(39, "39");
        _dictionary.Add(40, "40");
        _dictionary.Add(41, "41");
        _dictionary.Add(42, "42");
        _dictionary.Add(43, "43");
        _dictionary.Add(44, "44");
        _dictionary.Add(45, "45");
        _dictionary.Add(46, "46");
        _dictionary.Add(47, "47");
        _dictionary.Add(48, "48");
        _dictionary.Add(49, "49");
        _dictionary.Add(50, "50");
        _dictionary.Add(51, "51");
        _dictionary.Add(52, "52");
        _dictionary.Add(53, "53");
        _dictionary.Add(54, "54");
    }
}