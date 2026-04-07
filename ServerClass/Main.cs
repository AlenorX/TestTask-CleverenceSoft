namespace ServerClass
{
    public static class Server
    {
        private static int count;
        private static ReaderWriterLockSlim slim = new ReaderWriterLockSlim();


        public static string GetCount()
        {
            slim.EnterReadLock();
            try
            {
                return count;
            }
            finally
            {
                slim.ExitReadLock();
            }

        }

        public static void AddToCount(int value)
        {
            slim.EnterWriteLock();
            try
            {
                count += value;
            }
            finally
            {
                slim.ExitReadLock();
            }
        }

        public void Dispose()
        {
            _lock.Dispose();
        }

    }
    
}