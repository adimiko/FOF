using FOF.TestSamples.Classes;
using Xunit;

namespace FOF.Tests.Factories
{
    public class AccessModifierTests
    {
        [Fact]
        public void CreateObject_WhenFactoryUsingPublicConstructor_IsSuccessful()
        {
            const string @string = "Text";

            var @object = Factory<ClassWithPublicConstructor>.Create(@string);

            Assert.Equal(@string, @object.String);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsingInternalConstructor_IsSuccessful()
        {
            const string @string = "Text";

            var @object = Factory<ClassWithInternalConstructor>.Create(@string);

            Assert.Equal(@string, @object.String);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsingProtectedConstructor_IsSuccessful()
        {
            const string @string = "Text";

            var @object = Factory<ClassWithProtectedConstructor>.Create(@string);

            Assert.Equal(@string, @object.String);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsingProtectedInternalConstructor_IsSuccessful()
        {
            const string @string = "Text";

            var @object = Factory<ClassWithProtectedInternalConstructor>.Create(@string);

            Assert.Equal(@string, @object.String);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsingPrivateConstructor_IsSuccessful()
        {
            const string @string = "Text";

            var @object = Factory<ClassWithPrivateConstructor>.Create(@string);

            Assert.Equal(@string, @object.String);
        }
    }
}
