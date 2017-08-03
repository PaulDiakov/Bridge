using Bridge;

namespace System.Threading
{
    public abstract class WaitHandle : IDisposable
    {
        public static bool WaitAll(WaitHandle[] waitHandles)
        {
            throw new NotImplementedException();
        }

        public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
        {
            throw new NotImplementedException();
        }

        public static bool WaitAll(WaitHandle[] waitHandles,
                       TimeSpan timeout,
                       bool exitContext)
        {
            throw new NotImplementedException();
        }
        
        public static int WaitAny(WaitHandle[] waitHandles)
        {
            throw new NotImplementedException();
        }

        public static int WaitAny(WaitHandle[] waitHandles,
                      int millisecondsTimeout,
                      bool exitContext)
        {
            throw new NotImplementedException();
        }

        public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout)
        {
            throw new NotImplementedException();
        }

        public static int WaitAny(WaitHandle[] waitHandles,
                      TimeSpan timeout, bool exitContext)
        {
            throw new NotImplementedException();
        }

        protected WaitHandle()
        {
        }

        public virtual void Close()
        {
            throw new NotImplementedException();
        }
        
        public const int WaitTimeout = 258;
        
        public virtual IntPtr Handle()
        {
            throw new NotImplementedException();
        }
        
        public static bool SignalAndWait(WaitHandle toSignal,
                          WaitHandle toWaitOn)
        {
            throw new NotImplementedException();
        }

        public static bool SignalAndWait(WaitHandle toSignal,
                          WaitHandle toWaitOn,
                          int millisecondsTimeout,
                          bool exitContext)
        {
            throw new NotImplementedException();
        }

        public static bool SignalAndWait(WaitHandle toSignal,
                          WaitHandle toWaitOn,
                          TimeSpan timeout,
                          bool exitContext)
        {
            throw new NotImplementedException();
        }

        static extern bool SignalAndWait_Internal(IntPtr toSignal, IntPtr toWaitOn, int ms, bool exitContext);

        public virtual bool WaitOne()
        {
            throw new NotImplementedException();
        }

        public virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
        {
            throw new NotImplementedException();
        }

        public virtual bool WaitOne(int millisecondsTimeout)
        {
            throw new NotImplementedException();
        }

        public virtual bool WaitOne(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        public virtual bool WaitOne(TimeSpan timeout, bool exitContext)
        {
            throw new NotImplementedException();
        }

        internal void CheckDisposed()
        {
            throw new NotImplementedException();
        }

        public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout)
        {
            throw new NotImplementedException();
        }

        public static bool WaitAll(WaitHandle[] waitHandles, TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}