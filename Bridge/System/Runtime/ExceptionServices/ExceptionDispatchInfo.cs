using Bridge;

namespace System.Runtime.ExceptionServices
{
    public sealed class ExceptionDispatchInfo
    {
        public Exception SourceException
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static ExceptionDispatchInfo Capture(Exception source)
        {
            throw new NotImplementedException();
        }

        public void Throw()
        {
            throw new NotImplementedException();
        }
    }
}