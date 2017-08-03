using Bridge;
using System.Runtime.Serialization;

namespace System.IO
{
    public abstract class FileSystemInfo : ISerializable
    {
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
        
        public abstract bool Exists { get; }

        public abstract string Name { get; }

        public virtual string FullName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Extension
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        
        public DateTime CreationTime
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

        public DateTime CreationTimeUtc
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

        public DateTime LastAccessTime
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

        public DateTime LastAccessTimeUtc
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

        public DateTime LastWriteTime
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

        public DateTime LastWriteTimeUtc
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
        
        public abstract void Delete();

        public void Refresh()
        {
            throw new NotImplementedException();
        }
        
        protected FileSystemInfo()
        {
            throw new NotImplementedException();
        }

        protected FileSystemInfo(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}