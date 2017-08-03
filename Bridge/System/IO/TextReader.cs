using Bridge;

namespace System.IO
{
    public abstract class TextReader : IDisposable {
        sealed class NullTextReader : TextReader
        {
            public override string ReadLine()
            {
                throw new NotImplementedException();
            }

            public override string ReadToEnd()
            {
                throw new NotImplementedException();
            }
        }

        public static readonly TextReader Null = new NullTextReader();

        protected TextReader()
        {
        }

        public virtual void Close()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        
        public virtual int Peek()
        {
            throw new NotImplementedException();
        }

        public virtual int Read()
        {
            throw new NotImplementedException();
        }

        public virtual int Read(char[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public virtual int ReadBlock(char[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public virtual string ReadLine()
        {
            throw new NotImplementedException();
        }

        public virtual string ReadToEnd()
        {
            throw new NotImplementedException();
        }

        public static TextReader Synchronized(TextReader reader)
        {
            throw new NotImplementedException();
        }
    }
}