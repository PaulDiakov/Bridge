using Bridge;

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
    public sealed class StructLayoutAttribute : Attribute
    {
        public int Pack;
        public int Size;
        
        public StructLayoutAttribute(short layoutKind)
        {
            return;
        }

        public StructLayoutAttribute(LayoutKind layoutKind)
        {
            return;
        }

        public LayoutKind Value
        {
            get { return default(LayoutKind); }
        }

    }
}