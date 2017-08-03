using Bridge;
using System.Threading;
using System.Runtime.InteropServices;

namespace System.IO
{
    public abstract class Stream : IDisposable
    {
        public static readonly Stream Null = new NullStream();

        protected Stream()
        {
        }

        public abstract bool CanRead
        {
            get;
        }

        public abstract bool CanSeek
        {
            get;
        }

        public abstract bool CanWrite
        {
            get;
        }

        public virtual bool CanTimeout
        {
            get
            {
                return default(bool);
            }
        }

        public abstract long Length
        {
            get;
        }

        public abstract long Position
        {
            get;
            set;
        }


        public void Dispose()
        {
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public virtual void Close()
        {
        }
        
        public virtual int ReadTimeout
        {
            get;
            set;
        }

        public virtual int WriteTimeout
        {
            get;
            set;
        }

        public static Stream Synchronized(Stream stream)
        {
            return new SynchronizedStream(stream);
        }
        
        public abstract void Flush();

        public abstract int Read(byte[] buffer, int offset, int count);

        public virtual int ReadByte()
        {
            return default(int);
        }

        public abstract long Seek(long offset, SeekOrigin origin);

        public abstract void SetLength(long value);

        public abstract void Write(byte[] buffer, int offset, int count);

        public virtual void WriteByte(byte value)
        {
        }

        public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return default(IAsyncResult);
        }

        public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return default(IAsyncResult);
        }

        public virtual int EndRead(IAsyncResult asyncResult)
        {
            return default(int);
        }

        public virtual void EndWrite(IAsyncResult asyncResult)
        {
        }

        public void CopyTo(Stream destination)
        {
        }

        public void CopyTo(Stream destination, int bufferSize)
        {
        }
    }

    class NullStream : Stream
    {
        public override bool CanRead
        {
            get
            {
                return default(bool);
            }
        }

        public override bool CanSeek
        {
            get
            {
                return default(bool);
            }
        }

        public override bool CanWrite
        {
            get
            {
                return default(bool);
            }
        }

        public override long Length
        {
            get
            {
                return default(long);
            }
        }

        public override long Position
        {
            get
            {
                return default(long);
            }
            set
            {
            }
        }

        public override void Flush()
        {
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return default(int);
        }

        public override int ReadByte()
        {
            return default(int);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return default(long);
        }

        public override void SetLength(long value)
        {
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
        }

        public override void WriteByte(byte value)
        {
        }
    }

    class SynchronizedStream : Stream
    {
        internal SynchronizedStream(Stream source)
        {
        }

        public override bool CanRead
        {
            get
            {
                return default(bool);
            }
        }

        public override bool CanSeek
        {
            get
            {
                return default(bool);
            }
        }

        public override bool CanWrite
        {
            get
            {
                return default(bool);
            }
        }

        public override long Length
        {
            get
            {
                return default(long);
            }
        }

        public override long Position
        {
            get
            {
                return default(long);
            }
            set
            {
            }
        }

        public override void Flush()
        {
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return default(int);
        }

        public override int ReadByte()
        {
            return default(int);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return default(long);
        }

        public override void SetLength(long value)
        {
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
        }

        public override void WriteByte(byte value)
        {
        }
    }
}