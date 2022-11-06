using FOF.Exceptions;
using FOF.TestSamples.Classes;
using Xunit;

namespace FOF.Tests.Factories
{
    public class ExceptionTests
    {
        [Fact]
        public void CreateObject_WhenFactoryTriesToUseNonExistentConstructor_ThrowsNotFoundConstructorException()
        {
            const string expectedMessage = "FOF.TestSamples.Classes.ExampleClass does not contain a constructor with the following parameter types: System.Int32";

            var excetpion = Assert.Throws<NotFoundConstructorException>(() => Factory<ExampleClass>.Create(10));

            Assert.Equal(expectedMessage, excetpion.Message);
        }
    }
}
