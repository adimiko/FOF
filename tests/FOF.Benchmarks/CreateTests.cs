using BenchmarkDotNet.Attributes;

namespace FOF.Benchmarks
{
    [MemoryDiagnoser]
    public class CreateTests
    {
        public class ExampleClass
        {
            public string String { get; }

            public int Int { get; }

            public ExampleClass(string @string, int @int)
            {
                String = @string;
                Int = @int;
            }
        }

        [Benchmark]
        public void CreateUsingPublicConstructor()
            => new ExampleClass("Text", 1);

        [Benchmark]
        public void CreateUsingPublicConstructorWithActivator()
            => Activator.CreateInstance(typeof(ExampleClass), "Text", 1);

        [Benchmark]
        public void CreateUsingPublicConstructorWithFastFactory()
            => Factory<ExampleClass>.Create("Text", 1);

        public class ExampleClassWithPrivateConstructor
        {
            public string String { get; }

            public int Int { get; }

            private ExampleClassWithPrivateConstructor(string @string, int @int)
            {
                String = @string;
                Int = @int;
            }
        }

        [Benchmark]
        public void CreateUsingPrivateConstructorWithFastFactory()
            => Factory<ExampleClassWithPrivateConstructor>.Create("Text", 1);
    }
}
