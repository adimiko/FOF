namespace FOF.Tests.SeedWorks
{
    internal static class Multithreader
    {
        internal static void Run(in int numberOfFunctionCalls, Action function)
        {
            Thread[] threads = new Thread[numberOfFunctionCalls];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() =>
                {
                    var randomValue = ThreadSafeRandom.Next() % 1500;
                    Thread.Sleep(randomValue);
                    function();
                });
            }

            foreach (Thread thread in threads)
            {
                thread.Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            };
        }
    }
}
