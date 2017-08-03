using Bridge;

namespace System.Runtime.Serialization
{
    public class SerializationException : SystemException
    {
        // Constructors
        public SerializationException()
            : base("An error occurred during (de)serialization")
        {
        }

        public SerializationException(string message)
            : base(message)
        {
        }

        public SerializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}