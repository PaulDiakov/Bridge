using Bridge;

namespace System.Threading.Tasks
{
    public class UnobservedTaskExceptionEventArgs : EventArgs
    {
        public UnobservedTaskExceptionEventArgs(AggregateException exception)
        {
        }

        public AggregateException Exception
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Observed
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SetObserved()
        {
            throw new NotImplementedException();
        }
    }
}