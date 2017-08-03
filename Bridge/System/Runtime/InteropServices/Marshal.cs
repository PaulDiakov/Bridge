using Bridge;

namespace System.Runtime.InteropServices
{
    [External]
    public static class Marshal
    {
        public static IntPtr AllocHGlobal(IntPtr cb)
        {
            throw new NotImplementedException();
        }

        public static IntPtr AllocHGlobal(int cb)
        {
            return new IntPtr(cb);
        }

        public static void FreeHGlobal(IntPtr hglobal)
        {
            //delete IntPtr, free buffer
            throw new NotImplementedException();
        }

        public static string PtrToStringAnsi(IntPtr ptr)
        {
            throw new NotImplementedException();
        }

        public static string PtrToStringAnsi(IntPtr ptr, int len)
        {
            throw new NotImplementedException();
        }

        public static void PtrToStructure(IntPtr ptr, object structure)
        {
            throw new NotImplementedException();
        }

        public static object PtrToStructure(IntPtr ptr, Type structureType)
        {
            throw new NotImplementedException();
        }

        public static int SizeOf(object structure)
        {
            throw new NotImplementedException();
        }

        public static int SizeOf(Type t)
        {
            throw new NotImplementedException();
        }

        public static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(char[] source, int startIndex, IntPtr destination, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(short[] source, int startIndex, IntPtr destination, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(int[] source, int startIndex, IntPtr destination, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(long[] source, int startIndex, IntPtr destination, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(float[] source, int startIndex, IntPtr destination, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(double[] source, int startIndex, IntPtr destination, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(IntPtr source, char[] destination, int startIndex, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(IntPtr source, short[] destination, int startIndex, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(IntPtr source, int[] destination, int startIndex, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(IntPtr source, long[] destination, int startIndex, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(IntPtr source, float[] destination, int startIndex, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(IntPtr source, double[] destination, int startIndex, int length)
        {
            throw new NotImplementedException();
        }

        public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length)
        {
            throw new NotImplementedException();
        }
    }
}