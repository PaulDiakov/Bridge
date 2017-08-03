using Bridge;

namespace System.Text
{
    public abstract class Encoding : ICloneable
    {
        protected Encoding()
        {
        }

        public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

        public virtual int GetBytes(String s, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            throw new NotImplementedException();
        }
        
        public virtual byte[] GetBytes(String s)
        {
            throw new NotImplementedException();
        }

        public virtual byte[] GetBytes(char[] chars, int index, int count)
        {
            throw new NotImplementedException();
        }

        public virtual byte[] GetBytes(char[] chars)
        {
            throw new NotImplementedException();
        }

        public virtual String GetString(byte[] bytes, int index, int count)
        {
            throw new NotImplementedException();
        }

        public virtual String GetString(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public virtual Decoder GetDecoder()
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
        
        public static Encoding UTF8
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static Encoding UTF8UnmarkedUnsafe
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}