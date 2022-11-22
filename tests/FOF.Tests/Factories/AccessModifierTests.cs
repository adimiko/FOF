using FOF.TestSamples.Classes;
using Xunit;

namespace FOF.Tests.Factories
{
    public class AccessModifierTests
    {
        [Fact]
        public void CreateObject_WhenFactoryUsesPublicConstructor_IsSuccessful()
        {
            // Arrange
            const string @string = "Text";

            // Act
            var @object = Factory<ClassWithPublicConstructor>.Create(@string);

            // Assert
            Assert.Equal(@string, @object.String);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesInternalConstructor_IsSuccessful()
        {
            // Arrange
            const string @string = "Text";

            // Act
            var @object = Factory<ClassWithInternalConstructor>.Create(@string);

            // Assert
            Assert.Equal(@string, @object.String);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesProtectedConstructor_IsSuccessful()
        {
            // Arrange
            const string @string = "Text";

            // Act
            var @object = Factory<ClassWithProtectedConstructor>.Create(@string);

            // Assert
            Assert.Equal(@string, @object.String);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesProtectedInternalConstructor_IsSuccessful()
        {
            // Arrange
            const string @string = "Text";

            // Act
            var @object = Factory<ClassWithProtectedInternalConstructor>.Create(@string);

            // Assert
            Assert.Equal(@string, @object.String);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesPrivateConstructor_IsSuccessful()
        {
            // Arrange
            const string @string = "Text";

            // Act
            var @object = Factory<ClassWithPrivateConstructor>.Create(@string);

            // Assert
            Assert.Equal(@string, @object.String);
        }
    }
}
