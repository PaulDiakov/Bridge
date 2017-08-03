using Bridge;
using System.Text;

namespace System.IO
{
    public class BinaryReader : IDisposable
    {
        public BinaryReader(Stream input)
            : this(input, Encoding.UTF8UnmarkedUnsafe)
        {
        }
        
        public BinaryReader(Stream input, Encoding encoding)
        {
        }

        public virtual Stream BaseStream
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual void Close()
        {
            throw new NotImplementedException();
        }
        
        public void Dispose ()
        {
            throw new NotImplementedException();
        }
        
        public virtual int PeekChar()
        {
            throw new NotImplementedException();
        }

        public virtual int Read()
        {
            throw new NotImplementedException();
        }

        public virtual int Read(byte[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public virtual int Read(char[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public virtual bool ReadBoolean()
        {
            throw new NotImplementedException();
        }

        public virtual byte ReadByte()
        {
            throw new NotImplementedException();
        }

        public virtual byte[] ReadBytes(int count)
        {
            throw new NotImplementedException();
        }

        public virtual char ReadChar()
        {
            throw new NotImplementedException();
        }

        public virtual char[] ReadChars(int count)
        {
            throw new NotImplementedException();
        }

        unsafe public virtual decimal ReadDecimal()
        {
            throw new NotImplementedException();
        }

        public virtual double ReadDouble()
        {
            throw new NotImplementedException();
        }

        public virtual short ReadInt16()
        {
            throw new NotImplementedException();
        }

        public virtual int ReadInt32()
        {
            throw new NotImplementedException();
        }

        public virtual long ReadInt64()
        {
            throw new NotImplementedException();
        }

        public virtual sbyte ReadSByte()
        {
            throw new NotImplementedException();
        }

        public virtual string ReadString()
        {
            throw new NotImplementedException();
        }

        public virtual float ReadSingle()
        {
            throw new NotImplementedException();
        }

        public virtual ushort ReadUInt16()
        {
            throw new NotImplementedException();
        }

        public virtual uint ReadUInt32()
        {
            throw new NotImplementedException();
        }

        public virtual ulong ReadUInt64()
        {
            throw new NotImplementedException();
        }
    }
}