using Xunit;

namespace Faf.Tests
{
    public class CreateTests
    {
        public class ExampleClass
        {
            public string String { get; }

            public int Int { get; }

            private ExampleClass(string @string, int @int)
            {
                String = @string;
                Int = @int;
            }

            private ExampleClass(int @int, string @string)
            {
                String = @string;
                Int = @int;
            }
        }

        [Fact]
        public void Create()
        {
            var @string = "string";
            var @int = 1;

            var @object = Factory<ExampleClass>.Create(@string, @int);

            Assert.Equal(@string, @object.String);
            Assert.Equal(@int, @object.Int);
        }

        [Fact]
        public void Create2()
        {
            var @int = 1;
            var @string = "string";

            var @object = Factory<ExampleClass>.Create(@int, @string);

            Assert.Equal(@string, @object.String);
            Assert.Equal(@int, @object.Int);
        }
    }
}
