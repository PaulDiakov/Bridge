using Bridge;
using System.ComponentModel;

namespace System
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [External]
    [NonScriptable]
    public class ValueType
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [External]
    public struct IntPtr
    {
        public static readonly IntPtr Zero;

        public IntPtr(int value) { }
        public IntPtr(long value) { }
        unsafe public IntPtr(void* value) { }
        
        public static int Size
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        
        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public int ToInt32()
        {
            throw new NotImplementedException();
        }

        public long ToInt64()
        {
            throw new NotImplementedException();
        }

        unsafe public void* ToPointer()
        {
            throw new NotImplementedException();
        }

        override public string ToString()
        {
            throw new NotImplementedException();
        }

        public string ToString(string format)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(IntPtr value1, IntPtr value2)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(IntPtr value1, IntPtr value2)
        {
            throw new NotImplementedException();
        }

        public static explicit operator IntPtr(int value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator IntPtr(long value)
        {
            throw new NotImplementedException();
        }

        unsafe public static explicit operator IntPtr(void* value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator int(IntPtr value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator long(IntPtr value)
        {
            throw new NotImplementedException();
        }

        unsafe public static explicit operator void* (IntPtr value)
        {
            throw new NotImplementedException();
        }

        public static IntPtr Add(IntPtr pointer, int offset)
        {
            throw new NotImplementedException();
        }

        public static IntPtr Subtract(IntPtr pointer, int offset)
        {
            throw new NotImplementedException();
        }

        public static IntPtr operator +(IntPtr pointer, int offset)
        {
            throw new NotImplementedException();
        }

        public static IntPtr operator -(IntPtr pointer, int offset)
        {
            throw new NotImplementedException();
        }

        internal unsafe bool IsNull()
        {
            throw new NotImplementedException();
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [External]
    [NonScriptable]
    public struct UIntPtr
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [External]
    [NonScriptable]
    public class ParamArrayAttribute
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [External]
    [NonScriptable]
    public struct RuntimeTypeHandle
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [External]
    [NonScriptable]
    public struct RuntimeFieldHandle
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [NonScriptable]
    public struct RuntimeMethodHandle
    {
    }
}