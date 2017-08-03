using Bridge;

namespace System.Collections.Generic
{
    //[External]
    [Reflectable]
    public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary,
        IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IBridgeClass
    {
        public extern Dictionary();

        [Template("new (System.Collections.Generic.Dictionary$2({TKey}, {TValue}))()")]
        public extern Dictionary(int capacity);

        [Template("new (System.Collections.Generic.Dictionary$2({TKey}, {TValue}))(null, {comparer})")]
        public extern Dictionary(int capacity, IEqualityComparer<TKey> comparer);

        public extern Dictionary(object obj);

        public extern Dictionary(object obj, IEqualityComparer<TKey> comparer);

        [Template("new (System.Collections.Generic.Dictionary$2({TKey}, {TValue}))(null, {comparer})")]
        public extern Dictionary(IEqualityComparer<TKey> comparer);

        public extern Dictionary(IDictionary<TKey, TValue> dictionary);

        public extern Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer);

        [Convention(Notation.LowerCamelCase)] //[Field]
        public extern IEqualityComparer<TKey> Comparer
        {
            get;
        }

        [Convention(Notation.LowerCamelCase)] //[Field]
        public extern int Count
        {
            get;
        }

        public new KeyCollection Keys
        {
            get { return new KeyCollection(this); }
        }

        ICollection<TKey> IDictionary<TKey, TValue>.Keys
        {
            [Template("getKeys()")]
            get;
        }
        
        IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys
        {
            [Template("getKeys()")]
            get;
        }

        public extern ICollection<TValue> Values
        {
            [Template("getValues()")]
            get;
        }

        IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values
        {
            [Template("getValues()")]
            get;
        }

        [AccessorsIndexer]
        public extern TValue this[TKey key]
        {
            [Name("get")]
            get;
            [Name("set")]
            set;
        }

        public extern void Set(TKey key, TValue value);

        public extern void Add(TKey key, TValue value);

        public extern TValue Get(TKey key);

        private extern TValue Items(TKey key);

        public extern void Clear();

        public extern bool ContainsKey(TKey key);

        public extern bool ContainsValue(TValue value);

        public extern IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator();

        extern IEnumerator IEnumerable.GetEnumerator();

        public extern bool Remove(TKey key);

        public extern bool TryGetValue(TKey key, out TValue value);

        public extern bool IsReadOnly
        {
            [Template("getIsReadOnly()")]
            get;
        }

        extern void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item);

        extern void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex);

        extern bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item);

        extern bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item);

        extern void ICollection.CopyTo(Array array, int arrayIndex);

        [AccessorsIndexer]
        extern object IDictionary.this[object key]
        {
            [Name("get")]
            get;
            [Name("set")]
            set;
        }

        extern ICollection IDictionary.Values
        {
            get;
        }

        extern bool IDictionary.ContainsKey(object key);

        extern void IDictionary.Add(object key, object value);

        extern bool IDictionary.Remove(object key);

        extern ICollection IDictionary.Keys
        {
            get;
        }
        
        public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, ICollection, IEnumerable
        {
            public KeyCollection(Dictionary<TKey, TValue> dictionary)
            {
            }
            
            public void CopyTo(TKey[] array, int index)
            {
            }

            public Enumerator GetEnumerator()
            {
                return default(Enumerator);
            }

            void ICollection<TKey>.Add(TKey item)
            {
            }

            void ICollection<TKey>.Clear()
            {
            }

            bool ICollection<TKey>.Contains(TKey item)
            {
                return default(bool);
            }

            bool ICollection<TKey>.Remove(TKey item)
            {
                return default(bool);
            }

            IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
            {
                return default(IEnumerator<TKey>);
            }

            void ICollection.CopyTo(Array array, int index)
            {
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return default(IEnumerator);
            }

            public int Count
            {
                get { return default(int); }
            }

            bool ICollection<TKey>.IsReadOnly
            {
                get { return true; }
            }
            
            [Serializable]
            public struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
            {
                internal Enumerator(Dictionary<TKey, TValue> host)
                {
                }

                public void Dispose()
                {
                }

                public bool MoveNext()
                {
                    return default(bool);
                }

                public TKey Current
                {
                    get { return default(TKey); }
                }

                object IEnumerator.Current
                {
                    get { return default(object); }
                }

                void IEnumerator.Reset()
                {
                }
            }
        }
    }
}