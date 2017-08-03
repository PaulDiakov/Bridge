using Bridge;
using System.Runtime.Serialization;
using System.Text;
using System.Runtime.InteropServices;

namespace System.IO
{

    public class FileNotFoundException : IOException
    {
        public FileNotFoundException()
            : base("Unable to find the specified file.")
        {
        }

        public FileNotFoundException(string message)
            : base(message)
        {
        }

        public FileNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public FileNotFoundException(string message, string fileName)
            : base(message)
        {
        }

        public FileNotFoundException(string message, string fileName, Exception innerException)
            : base(message, innerException)
        {
        }
        
        public string FileName
        {
            get { throw new NotImplementedException(); }
        }

        public string FusionLog
        {
            get { throw new NotImplementedException(); }
        }

        public override string Message
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}