using FOF.Tests.SeedWorks;
using Xunit;

namespace FOF.Tests
{
    public class CreateTests
    {
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
