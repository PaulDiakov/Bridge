using System.Runtime.Serialization;
using Bridge;

namespace System
{
    public class WeakReference : ISerializable
    {
        public WeakReference(object target)
            : this(target, false)
        {
        }

        public WeakReference(object target, bool trackResurrection)
        {
        }

        protected WeakReference(SerializationInfo info, StreamingContext context)
        {
        }

        public virtual bool IsAlive
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual object Target
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

        public virtual bool TrackResurrection
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    public class WeakReference<T>
    {
        public WeakReference(T target)
        {
        }

        public void SetTarget(T target)
        {
            throw new NotImplementedException();
        }

        public bool TryGetTarget(out T target)
        {
            throw new NotImplementedException();
        }
    }
}