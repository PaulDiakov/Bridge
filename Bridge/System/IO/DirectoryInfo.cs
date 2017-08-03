using Bridge;

namespace System.IO
{

    public sealed class DirectoryInfo : FileSystemInfo
    {
        public DirectoryInfo(string path) : this(path, false)
        {
        }

        internal DirectoryInfo(string path, bool simpleOriginalPath)
        {
        }
        
        public override bool Exists
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DirectoryInfo Parent
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DirectoryInfo Root
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        
        public void Create()
        {
            throw new NotImplementedException();
        }

        public DirectoryInfo CreateSubdirectory(string path)
        {
            throw new NotImplementedException();
        }
        
        public FileInfo[] GetFiles()
        {
            throw new NotImplementedException();
        }

        public FileInfo[] GetFiles(string searchPattern)
        {
            throw new NotImplementedException();
        }

        public DirectoryInfo[] GetDirectories()
        {
            throw new NotImplementedException();
        }

        public DirectoryInfo[] GetDirectories(string searchPattern)
        {
            throw new NotImplementedException();
        }

        public FileSystemInfo[] GetFileSystemInfos()
        {
            throw new NotImplementedException();
        }
        
        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public void Delete(bool recursive)
        {
            throw new NotImplementedException();
        }

        public void MoveTo(string destDirName)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}