using System;
using System.Runtime.InteropServices;

namespace Advanced_Concepts
{
    

public class GenericList<T>
{
    public void Add(T value)
    {
        var x = value.ToString();
        Console.WriteLine(x);
    }

    public T this[int index] => throw new NotImplementedException();
}

public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            var newKey = key.ToString();
            var newValue = value;
            Console.WriteLine(string.Concat(newKey, newValue));
        }
    }
}