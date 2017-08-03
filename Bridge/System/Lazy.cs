using Bridge;
using System.Threading;

namespace System
{
    public class Lazy<T>
    {
        public Lazy()
            : this(LazyThreadSafetyMode.ExecutionAndPublication)
        {
        }

        public Lazy(Func<T> valueFactory)
            : this(valueFactory, LazyThreadSafetyMode.ExecutionAndPublication)
        {
        }

        public Lazy(bool isThreadSafe)
            : this(() => Activator.CreateInstance<T>(), isThreadSafe ? LazyThreadSafetyMode.ExecutionAndPublication : LazyThreadSafetyMode.None)
        {
        }

        public Lazy(Func<T> valueFactory, bool isThreadSafe)
            : this(valueFactory, isThreadSafe ? LazyThreadSafetyMode.ExecutionAndPublication : LazyThreadSafetyMode.None)
        {
        }

        public Lazy(LazyThreadSafetyMode mode)
            : this(() => Activator.CreateInstance<T>(), mode)
        {
        }
        
        public Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode)
        {
        }

        public T Value
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        T InitValue()
        {
            throw new NotImplementedException();
        }

        public bool IsValueCreated
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}