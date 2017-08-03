using Bridge;

namespace System.IO
{
    public sealed class InvalidDataException : SystemException
    {
        public InvalidDataException()
            : base("Invalid data format.")
        {
        }

        public InvalidDataException(string message)
            : base(message)
        {
        }

        public InvalidDataException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}