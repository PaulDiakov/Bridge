using Bridge;

namespace System.Threading
{
    public sealed class Semaphore : WaitHandle
    {
        private Semaphore(IntPtr handle)
        {
        }

        public Semaphore(int initialCount, int maximumCount)
            : this(initialCount, maximumCount, null)
        {
        }

        public Semaphore(int initialCount, int maximumCount, string name)
        {
        }
        
        public int Release()
        {
            throw new NotImplementedException();
        }

        public int Release(int releaseCount)
        {
            throw new NotImplementedException();
        }
        
        public static Semaphore OpenExisting(string name)
        {
            throw new NotImplementedException();
        }
    }
}