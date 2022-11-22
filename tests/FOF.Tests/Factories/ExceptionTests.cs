using FOF.Exceptions;
using FOF.TestSamples.Classes;
using Xunit;

namespace FOF.Tests.Factories
{
    public class ExceptionTests
    {
        [Fact]
        public void CreateObject_WhenFactoryTriesToUseNonExistentParameterlessConstructor_ThrowsNotFoundConstructorException()
        {
            // Arrange
            const string expectedMessage = "FOF.TestSamples.Classes.ExampleClass does not contain a parameterless constructor";

            // Act
            var excetpion = Assert.Throws<NotFoundConstructorException>(() => Factory<ExampleClass>.Create());

            // Assert
            Assert.Equal(expectedMessage, excetpion.Message);
        }

        [Fact]
        public void CreateObject_WhenFactoryTriesToUseNonExistentConstructorWithOneParameter_ThrowsNotFoundConstructorException()
        {
            // Arrange
            const string expectedMessage = "FOF.TestSamples.Classes.ExampleClass does not contain a constructor with a parameter of type System.Int32";

            // Act
            var excetpion = Assert.Throws<NotFoundConstructorException>(() => Factory<ExampleClass>.Create(10));

            // Assert
            Assert.Equal(expectedMessage, excetpion.Message);
        }

        [Fact]
        public void CreateObject_WhenFactoryTriesToUseNonExistentConstructorWithMoreThanOneParameters_ThrowsNotFoundConstructorException()
        {
            // Arrange
            const string expectedMessage = "FOF.TestSamples.Classes.ExampleClass does not contain a constructor with the following parameter types: System.Int32, System.String, System.Char";

            // Act
            var excetpion = Assert.Throws<NotFoundConstructorException>(() => Factory<ExampleClass>.Create(10, "Text", 'a'));

            // Assert
            Assert.Equal(expectedMessage, excetpion.Message);
        }
    }
}
