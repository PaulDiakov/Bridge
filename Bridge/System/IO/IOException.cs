using Bridge;

namespace System.IO
{
    public class IOException : SystemException
    {
        public IOException()
            : base("I/O Error")
        {
        }

        public IOException(string message)
            : base(message)
        {
        }

        public IOException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        
        public IOException(string message, int hresult)
            : base(message)
        {
        }
    }
}