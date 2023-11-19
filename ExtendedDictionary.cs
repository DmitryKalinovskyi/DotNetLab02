using System.Linq;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace DotNetLab2
{
    public class ExtendedDictionaryElement<U, V> where U: notnull where V: notnull
    {
        public U Value1 { get; private set; }
        public V Value2 { get; private set; }

        public ExtendedDictionaryElement(U value1, V value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public override string ToString()
        {
            return $"{Value1} {Value2}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            ExtendedDictionaryElement<U, V> el = (ExtendedDictionaryElement<U, V>)obj;
            if (el == null) return false;


            return el.Value1.Equals(Value1) && el.Value2.Equals(Value2);
        }

        public override int GetHashCode()
        {
            return ((Value1 != null ? Value1.GetHashCode() : 1) * 23) ^ (Value2 != null ? Value2.GetHashCode() * 31 : 1);
        }

    }

    public class ExtendedDictionary<T, U, V> : IEnumerable where T : notnull where U : notnull where V : notnull
    {
        private readonly Dictionary<T, ExtendedDictionaryElement<U, V>> _dictionary;

        public ExtendedDictionary()
        {
            _dictionary = new();
        }

        public void Add(T key, U value1, V value2)
        {
            _dictionary.Add(key, new(value1, value2));
        }

        public void Remove(T key)
        {
            _dictionary.Remove(key);
        }

        public bool ContainsKey(T key)
        {
            return _dictionary.ContainsKey(key);
        }

        public bool ContainsValue(ExtendedDictionaryElement<U, V> value)
        {
            foreach(var val in _dictionary.Values)
            {
                if(val.Equals(value)) return true;
            }

            return false;
        }

        public int Count()
        {
            return _dictionary.Count;
        }

        public ExtendedDictionaryElement<U, V> this[T key]
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }

        public IEnumerator GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

    }
}
