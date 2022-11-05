using BenchmarkDotNet.Attributes;

namespace Faf.Benchmarks
{
    [MemoryDiagnoser]
    public class CreateTests
    {
        public class ExampleClass
        {
            public decimal X;

            public string Y;

            public ExampleClass(decimal x, string y)
            {
                X = x;
                Y = y;
            }
        }

        [Benchmark]
        public void Create_DirectlyViaConstructor()
            => new ExampleClass(10.11m, "string");

        [Benchmark]
        public void CreateInstance_WithActivator()
            => Activator.CreateInstance(typeof(ExampleClass), 10.11m, "string");

        [Benchmark]
        public void Create_WithFactory()
            => Factory<ExampleClass>.Create(10.11m, "string");
    }
}
