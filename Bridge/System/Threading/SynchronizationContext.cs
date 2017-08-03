using Bridge;

namespace System.Threading
{
    public class SynchronizationContext
    {
        public SynchronizationContext()
        {
        }

        internal SynchronizationContext(SynchronizationContext context)
        {
        }

        public static SynchronizationContext Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual SynchronizationContext CreateCopy()
        {
            throw new NotImplementedException();
        }

        public bool IsWaitNotificationRequired()
        {
            throw new NotImplementedException();
        }

        public virtual void OperationCompleted()
        {
            throw new NotImplementedException();
        }

        public virtual void OperationStarted()
        {
            throw new NotImplementedException();
        }

        public virtual void Post(SendOrPostCallback d, object state)
        {
            throw new NotImplementedException();
        }

        public virtual void Send(SendOrPostCallback d, object state)
        {
            throw new NotImplementedException();
        }

        public static void SetSynchronizationContext(SynchronizationContext syncContext)
        {
            throw new NotImplementedException();
        }

        protected void SetWaitNotificationRequired()
        {
            throw new NotImplementedException();
        }

        public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
        {
            throw new NotImplementedException();
        }

        protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
        {
            throw new NotImplementedException();
        }
    }
}