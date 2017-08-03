using Bridge;
using System.Collections.Generic;

namespace System.Collections.Concurrent
{
    public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>,
      ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>,
      IDictionary, ICollection, IEnumerable
    {
        public ConcurrentDictionary() : this(EqualityComparer<TKey>.Default)
        {
        }

        public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection)
            : this(collection, EqualityComparer<TKey>.Default)
        {
        }

        public ConcurrentDictionary(IEqualityComparer<TKey> comparer)
        {
        }

        public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
            : this(comparer)
        {
        }

        public ConcurrentDictionary(int concurrencyLevel, int capacity)
            : this(EqualityComparer<TKey>.Default)
        {
        }

        public ConcurrentDictionary(int concurrencyLevel,
                                     IEnumerable<KeyValuePair<TKey, TValue>> collection,
                                     IEqualityComparer<TKey> comparer)
            : this(collection, comparer)
        {
        }

        // Parameters unused
        public ConcurrentDictionary(int concurrencyLevel, int capacity, IEqualityComparer<TKey> comparer)
            : this(comparer)
        {
        }

        void CheckKey(TKey key)
        {
            throw new NotImplementedException();
        }

        void Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public bool TryAdd(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> pair)
        {
            throw new NotImplementedException();
        }

        public TValue AddOrUpdate(TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
        {
            throw new NotImplementedException();
        }

        public TValue AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
        {
            throw new NotImplementedException();
        }

        TValue AddOrUpdate(TKey key, TValue addValue, TValue updateValue)
        {
            throw new NotImplementedException();
        }

        TValue GetValue(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        public bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue)
        {
            throw new NotImplementedException();
        }

        public TValue this[TKey key]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
        {
            throw new NotImplementedException();
        }

        public TValue GetOrAdd(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public bool TryRemove(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        bool IDictionary<TKey, TValue>.Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> pair)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        object IDictionary.this[object key]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        void IDictionary.Add(object key, object value)
        {
            throw new NotImplementedException();
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> pair)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<TKey, TValue>[] ToArray()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsEmpty
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IDictionary.IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public new ICollection<TKey> Keys
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ICollection IDictionary.Keys
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ICollection IDictionary.Values
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ICollection<T> GetPart<T>(Func<KeyValuePair<TKey, TValue>, T> extractor)
        {
            throw new NotImplementedException();
        }

        void ICollection.CopyTo(Array array, int startIndex)
        {
            throw new NotImplementedException();
        }

        void CopyTo(KeyValuePair<TKey, TValue>[] array, int startIndex)
        {
            throw new NotImplementedException();
        }

        void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int startIndex)
        {
            throw new NotImplementedException();
        }

        void CopyTo(KeyValuePair<TKey, TValue>[] array, int startIndex, int num)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorInternal()
        {
            throw new NotImplementedException();
        }
        
        class ConcurrentDictionaryEnumerator : IDictionaryEnumerator
        {
            public ConcurrentDictionaryEnumerator(IEnumerator<KeyValuePair<TKey, TValue>> internalEnum)
            {
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public object Current
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public DictionaryEntry Entry
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public object Key
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public object Value
            {
                get
                {
                    throw new NotImplementedException();
                }
            }
        }
        
        static KeyValuePair<U, V> Make<U, V>(U key, V value)
        {
            throw new NotImplementedException();
        }

        uint Hash(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(object key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(object key)
        {
            throw new NotImplementedException();
        }
    }
}