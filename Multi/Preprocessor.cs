using System;
using System.Collections;
using System.Collections.Generic;

namespace Multi
{
    public class Preprocessor2
    {
        public void Test(Dictionary<int, string> myDictionary, int parameter)
        {
            if (myDictionary.ContainsKey(parameter))
            {
#if NET7_0

                var valueForParameter1 = myDictionary[parameter];
#endif

#if NET6_0
                var valueForParameter1 = myDictionary[parameter];
#endif
            }
        }
    }
    
    public class Preprocessor
    {
        public void Test(MyDictionary myDictionary, int parameter)
        {
            if (myDictionary.ContainsKey(parameter))
            {
#if NET7_0

                var valueForParameter1 = myDictionary[parameter];
#endif

#if NET6_0
                var valueForParameter1 = myDictionary[parameter];
#endif
            }
        }
    }


    public abstract class MyDictionary : IDictionary<int, string>
    {
        public IEnumerator<KeyValuePair<int, string>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(KeyValuePair<int, string> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<int, string> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<int, string>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<int, string> item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }

        public void Add(int key, string value)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(int key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(int key, out string value)
        {
            throw new NotImplementedException();
        }

        public string this[int key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public ICollection<int> Keys { get; }
        public ICollection<string> Values { get; }
    }
}