using Bridge;

namespace System.Runtime.CompilerServices
{
    public sealed class ConditionalWeakTable<TKey, TValue>
        where TKey : class
        where TValue : class
    {
        public delegate TValue CreateValueCallback(TKey key);

        public ConditionalWeakTable()
        {
        }

        public void Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        public TValue GetOrCreateValue(TKey key)
        {
            throw new NotImplementedException();
        }

        public TValue GetValue(TKey key, CreateValueCallback createValueCallback)
        {
            throw new NotImplementedException();
        }
    }
}