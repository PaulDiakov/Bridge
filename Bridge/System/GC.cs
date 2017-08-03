using Bridge;

namespace System
{
    public static class GC
    {

        public extern static int MaxGeneration
        {
            get;
        }

        extern static void InternalCollect(int generation);

        public static void Collect()
        {
            throw new NotImplementedException();
        }

        public static void Collect(int generation)
        {
            throw new NotImplementedException();
        }

        public static void Collect(int generation, GCCollectionMode mode)
        {
            throw new NotImplementedException();
        }

        public static void Collect(int generation, GCCollectionMode mode, bool blocking)
        {
            throw new NotImplementedException();
        }

        public extern static int GetGeneration(object obj);

        public static int GetGeneration(WeakReference wo)
        {
            throw new NotImplementedException();
        }

        public extern static long GetTotalMemory(bool forceFullCollection);

        public extern static void KeepAlive(object obj);

        public extern static void ReRegisterForFinalize(object obj);

        public extern static void SuppressFinalize(object obj);

        public extern static void WaitForPendingFinalizers();

        public extern static int CollectionCount(int generation);
        
        public static void AddMemoryPressure(long bytesAllocated)
        {
            throw new NotImplementedException();
        }

        public static void RemoveMemoryPressure(long bytesAllocated)
        {
            throw new NotImplementedException();
        }

        public static GCNotificationStatus WaitForFullGCApproach()
        {
            throw new NotImplementedException();
        }

        public static GCNotificationStatus WaitForFullGCApproach(int millisecondsTimeout)
        {
            throw new NotImplementedException();
        }

        public static GCNotificationStatus WaitForFullGCComplete()
        {
            throw new NotImplementedException();
        }

        public static GCNotificationStatus WaitForFullGCComplete(int millisecondsTimeout)
        {
            throw new NotImplementedException();
        }

        public static void RegisterForFullGCNotification(int maxGenerationThreshold, int largeObjectHeapThreshold)
        {
            throw new NotImplementedException();
        }

        public static void CancelFullGCNotification()
        {
            throw new NotImplementedException();
        }
    }
}