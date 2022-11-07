namespace FOF.Tests.SeedWorks
{
    internal static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random? _local;
        private static readonly Random Global = new();

        private static Random Instance
        {
            get
            {
                if (_local is null)
                {
                    int seed;
                    lock (Global)
                    {
                        seed = Global.Next();
                    }

                    _local = new Random(seed);
                }

                return _local;
            }
        }

        internal static int Next() => Instance.Next();
    }
}
