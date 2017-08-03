using Bridge;

namespace System.Runtime.InteropServices
{
    public struct GCHandle
    {
        public bool IsAllocated
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object Target
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

        // Methods
        public IntPtr AddrOfPinnedObject()
        {
            throw new NotImplementedException();
        }

        public static GCHandle Alloc(object value)
        {
            throw new NotImplementedException();
        }

        public static GCHandle Alloc(object value, GCHandleType type)
        {
            throw new NotImplementedException();
        }

        public void Free()
        {
            throw new NotImplementedException();
        }

        public static explicit operator IntPtr(GCHandle value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator GCHandle(IntPtr value)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator ==(GCHandle a, GCHandle b)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(GCHandle a, GCHandle b)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object o)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static GCHandle FromIntPtr(IntPtr value)
        {
            throw new NotImplementedException();
        }

        public static IntPtr ToIntPtr(GCHandle value)
        {
            throw new NotImplementedException();
        }
    }
}