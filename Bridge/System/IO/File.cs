using Bridge;
using System.Collections.Generic;
using System.Text;

namespace System.IO
{
    public static class File
    {
        public static void AppendAllText(string path, string contents)
        {
            throw new NotImplementedException();
        }

        public static void AppendAllText(string path, string contents, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public static StreamWriter AppendText(string path)
        {
            throw new NotImplementedException();
        }

        public static void Copy(string sourceFileName, string destFileName)
        {
            throw new NotImplementedException();
        }

        public static void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            throw new NotImplementedException();
        }

        internal static String InternalCopy(String sourceFileName, String destFileName, bool overwrite, bool checkHost)
        {
            throw new NotImplementedException();
        }

        public static FileStream Create(string path)
        {
            throw new NotImplementedException();
        }

        public static FileStream Create(string path, int bufferSize)
        {
            throw new NotImplementedException();
        }
        
        public static StreamWriter CreateText(string path)
        {
            throw new NotImplementedException();
        }

        public static void Delete(string path)
        {
            throw new NotImplementedException();
        }

        public static bool Exists(string path)
        {
            throw new NotImplementedException();
        }
        
        public static DateTime GetCreationTime(string path)
        {
            throw new NotImplementedException();
        }

        public static DateTime GetCreationTimeUtc(string path)
        {
            throw new NotImplementedException();
        }

        public static DateTime GetLastAccessTime(string path)
        {
            throw new NotImplementedException();
        }

        public static DateTime GetLastAccessTimeUtc(string path)
        {
            throw new NotImplementedException();
        }

        public static DateTime GetLastWriteTime(string path)
        {
            throw new NotImplementedException();
        }

        public static DateTime GetLastWriteTimeUtc(string path)
        {
            throw new NotImplementedException();
        }

        public static void Move(string sourceFileName, string destFileName)
        {
            throw new NotImplementedException();
        }

        public static FileStream Open(string path, FileMode mode)
        {
            throw new NotImplementedException();
        }
        
        public static FileStream OpenRead(string path)
        {
            throw new NotImplementedException();
        }

        public static StreamReader OpenText(string path)
        {
            throw new NotImplementedException();
        }

        public static FileStream OpenWrite(string path)
        {
            throw new NotImplementedException();
        }

        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
        {
            throw new NotImplementedException();
        }

        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            throw new NotImplementedException();
        }
        
        public static void SetCreationTime(string path, DateTime creationTime)
        {
            throw new NotImplementedException();
        }

        public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            throw new NotImplementedException();
        }

        public static void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            throw new NotImplementedException();
        }

        public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            throw new NotImplementedException();
        }

        public static void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            throw new NotImplementedException();
        }

        public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            throw new NotImplementedException();
        }

        public static byte[] ReadAllBytes(string path)
        {
            throw new NotImplementedException();
        }

        public static string[] ReadAllLines(string path)
        {
            throw new NotImplementedException();
        }

        public static string[] ReadAllLines(string path, Encoding encoding)
        {
            throw new NotImplementedException();
        }
        
        public static string ReadAllText(string path)
        {
            throw new NotImplementedException();
        }

        public static string ReadAllText(string path, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public static void WriteAllBytes(string path, byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public static void WriteAllLines(string path, string[] contents)
        {
            throw new NotImplementedException();
        }

        public static void WriteAllLines(string path, string[] contents, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        static void WriteAllLines(StreamWriter writer, string[] contents)
        {
            throw new NotImplementedException();
        }

        public static void WriteAllText(string path, string contents)
        {
            throw new NotImplementedException();
        }

        public static void WriteAllText(string path, string contents, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        static DateTime DefaultLocalFileTime
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        
        public static void Encrypt(string path)
        {
            throw new NotImplementedException();
        }

        public static void Decrypt(string path)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<string> ReadLines(string path)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<string> ReadLines(string path, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public static void AppendAllLines(string path, IEnumerable<string> contents)
        {
            throw new NotImplementedException();
        }

        public static void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public static void WriteAllLines(string path, IEnumerable<string> contents)
        {
            throw new NotImplementedException();
        }

        public static void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            throw new NotImplementedException();
        }
    }
}