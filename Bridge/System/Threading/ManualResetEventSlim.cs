using Bridge;

namespace System.Threading
{
    public class ManualResetEventSlim : IDisposable
    {
        public ManualResetEventSlim()
            : this(false, 10)
        {
        }

        public ManualResetEventSlim(bool initialState)
            : this(initialState, 10)
        {
        }

        public ManualResetEventSlim(bool initialState, int spinCount)
        {
        }

        public bool IsSet
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int SpinCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Set()
        {
            throw new NotImplementedException();
        }
        
        public void Wait()
        {
            throw new NotImplementedException();
        }

        public bool Wait(int millisecondsTimeout)
        {
            throw new NotImplementedException();
        }

        public bool Wait(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        public void Wait(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public bool Wait(TimeSpan timeout, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public WaitHandle WaitHandle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }
        
        static int CheckTimeout(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }
    }
}