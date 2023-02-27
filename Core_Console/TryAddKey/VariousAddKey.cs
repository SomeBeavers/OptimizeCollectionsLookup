using System.Collections.Immutable;
using System.Collections.Specialized;

namespace Core_Console.TryAddKey;

public class VariousAddKey
{
    public static Dictionary<string, MyInnerClass> FieldDictionary = new();

    public VariousAddKey()
    {
    }

    public int Test(MyInnerClass anotherField)
    {
        anotherField = FieldDictionary["testname"];
        if (FieldDictionary.ContainsKey(Key) == false)
        {
            //FieldDictionary.Add("1", _myInnerClass);
            FieldDictionary[Key] = new MyInnerClass("1");
        }

        if (FieldDictionary.ContainsKey("1")) {
            var _s = FieldDictionary["1"];
        }

        var _myVar = new MyInnerClass("1").Name;

        FieldDictionary[_myVar] = new MyInnerClass("1");

        return 1;
    }

    public void LambdaTest(Dictionary<string, MyInnerClass> parameterDictionary, MyInnerClass parameter) {
        
        if (!parameterDictionary.ContainsKey(parameter.Name))
        {
            parameterDictionary.Add(parameter.Name, parameter);
        }

        foreach (var _b in new List<string>().Where(x => x == parameter.Name)
                     .Where(x => !parameterDictionary.ContainsKey(x)))
        {
            parameterDictionary.TryAdd(_b, parameter);
        }

        if (parameterDictionary.ContainsKey(parameter.Name)) {
            var s = parameterDictionary[parameter.Name];
        }
    }


    private static string Key { get; } = "1";
}
public class VariousAddKey1
{

    public int Test()
    {
        Dictionary<int, string> FieldDictionary = new();
        if (!FieldDictionary.ContainsKey(1)) {
            FieldDictionary.Add(1, "");
        }

        return 1;
    }
}

public class MyInnerClass
{
    public MyInnerClass(string name)
    {
        Name = name;
    }

    public MyInnerClass()
    {
        Name = "Jane Doe";
        Count = default;
    }

    public string Name { get; set; }

    public int Count { get; set; }
}