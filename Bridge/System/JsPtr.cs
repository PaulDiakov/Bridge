using Bridge;

namespace System
{
    [External]
    public class JsPtr
    {
        public static void AddressOf() { }
        public static void Cast() { }
        public static void Dereference() { }
        public static void ToFixed() { }

        public JsPtr(int value) { }
        
        public JsPtr(long value) { }

        unsafe public JsPtr(void* value) { }
    }
}