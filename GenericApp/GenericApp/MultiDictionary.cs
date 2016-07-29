using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;

namespace GenericApp
{
    public class MultiDictionary<K,V> :IEnumerable<KeyValuePair<K,ICollection<V>>>,IMultiDictionary<K,V>
    {

        private Dictionary<K, LinkedList<V>> _multiDictionary;
        public ICollection<K> Keys => _multiDictionary.Keys;
        
        //Sahtein!
        public ICollection<V> Values => _multiDictionary.Values.SelectMany(i => i).ToList();
        
        //Sahtein!
        public int Count => _multiDictionary.Values.SelectMany(i => i).ToList().Count;

        public MultiDictionary()
        {
            _multiDictionary=new Dictionary<K, LinkedList<V>>();
        }

        public void Add(K key, V value)
        {
            LinkedList<V> newLinkedList;
            if (_multiDictionary.TryGetValue(key,out newLinkedList))
            {
                newLinkedList.AddLast(value);
            }
            else
            {
                newLinkedList = new LinkedList<V>();
                newLinkedList.AddLast(value);
                _multiDictionary.Add(key, newLinkedList);
            }
        }

        public bool Remove(K key)
        {
            return _multiDictionary.Remove(key);
        }

        public bool Remove(K key, V value)
        {
            LinkedList<V> values;
            return _multiDictionary.TryGetValue(key, out values) && values.Remove(value);
        }

        public void Clear()
        {
           _multiDictionary.Clear();
        }

        public bool ContainsKey(K key)
        {
            return _multiDictionary.ContainsKey(key);
        }

        public bool Contains(K key, V value)
        {
            LinkedList<V> values;
            var flag=_multiDictionary.TryGetValue(key, out values);
            return flag && values.Contains(value);
        }

        public IEnumerator<KeyValuePair<K, ICollection<V>>> GetEnumerator()
        { 
            return _multiDictionary.Select(x => new KeyValuePair<K, ICollection<V>>(x.Key, x.Value)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}