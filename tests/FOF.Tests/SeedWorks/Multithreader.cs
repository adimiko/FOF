namespace FOF.Tests.SeedWorks
{
    internal static class Multithreader
    {
        internal static void Run(in int numberOfFunctionCalls, ThreadStart function)
        {
            Thread[] threads = new Thread[numberOfFunctionCalls];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(function);
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
