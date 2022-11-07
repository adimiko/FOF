using FOF.TestSamples.Classes;
using Xunit;

namespace FOF.Tests.Factories
{
    public class ReverseOrderOfConstructorParametersTests
    {
        [Fact]
        public void CreateObjects_WhenFactoryUsesConstructorsOfTheSameParametersTypesInReverseOrder_IsSuccessful()
        {
            // Arrange
            var @string = "string";
            var @int = 1;

            // Act
            var @object = Factory<ExampleClass>.Create(@string, @int);
            var @object2 = Factory<ExampleClass>.Create(@int, @string);

            // Assert
            Assert.Equal(@string, @object.String);
            Assert.Equal(@int, @object.Int);

            Assert.Equal(@string, @object.String);
            Assert.Equal(@int, @object.Int);

            Assert.NotEqual(@object, @object2);
        }
    }
}
