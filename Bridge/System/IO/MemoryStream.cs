using Bridge;

namespace System.IO
{
    public class MemoryStream : Stream
    {       
        public MemoryStream() : this(0)
        {
        }

        public MemoryStream(int capacity)
        {
        }

        public MemoryStream(byte[] buffer)
        {
        }

        public MemoryStream(byte[] buffer, bool writable)
        {
        }

        public MemoryStream(byte[] buffer, int index, int count)
        {
        }

        public MemoryStream(byte[] buffer, int index, int count, bool writable)
        {
        }

        public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
        {
        }
        
        public override bool CanRead
        {
            get { throw new NotImplementedException(); }
        }

        public override bool CanSeek
        {
            get { throw new NotImplementedException(); }
        }

        public override bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }

        public virtual int Capacity
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

        public override long Length
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override long Position
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

        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }

        public override void Flush()
        {
            throw new NotImplementedException();
        }

        public virtual byte[] GetBuffer()
        {
            throw new NotImplementedException();
        }

        public byte[] GetByteArray()
        {
            throw new NotImplementedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override int ReadByte()
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin loc)
        {
            throw new NotImplementedException();
        }
        
        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public virtual byte[] ToArray()
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override void WriteByte(byte value)
        {
            throw new NotImplementedException();
        }

        public virtual void WriteTo(Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}