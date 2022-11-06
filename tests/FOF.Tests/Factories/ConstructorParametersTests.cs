using FOF.TestSamples.Classes;
using Xunit;

namespace FOF.Tests.Factories
{
    public class ConstructorParametersTests
    {
        private readonly static string String = "Text";

        private readonly static int Int = 1;

        private readonly static bool Bool = true;

        private readonly static float Float = 12.34f;

        private readonly static double Double = 12.34;

        private readonly static decimal Decimal = 12.34m;

        private readonly static ExampleClass ExampleClass = Factory<ExampleClass>.Create(String, Int);

        private readonly static char Char = 'A';

        private readonly static byte Byte = 255;

        [Fact]
        public void CreateObject_WhenFactoryUsingParameterlessConstructor_IsSuccessful()
            => Factory<ClassWithParameterlessConstructor>.Create();

        [Fact]
        public void CreateObject_WhenFactoryUsingConstructorWith1Parameter_IsSuccessful()
        {
            var @object = Factory<ClassWith1ParameterInConstructor>.Create(String);

            Assert.Equal(String, @object.String);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsingConstructorWith2Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith2ParametersInConstructor>.Create(String, Int);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsingConstructorWith3Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith3ParametersInConstructor>.Create(String, Int, Bool);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsingConstructorWith4Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith4ParametersInConstructor>.Create(String, Int, Bool, Float);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsingConstructorWith5Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith5ParametersInConstructor>.Create(String, Int, Bool, Float, Double);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsingConstructorWith6Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith6ParametersInConstructor>.Create(String, Int, Bool, Float, Double, Decimal);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
            Assert.Equal(Decimal, @object.Decimal);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsingConstructorWith7Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith7ParametersInConstructor>.Create(String, Int, Bool, Float, Double, Decimal, ExampleClass);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
            Assert.Equal(Decimal, @object.Decimal);
            Assert.Equal(ExampleClass, @object.ExampleClass);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsingConstructorWith8Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith8ParametersInConstructor>.Create(String, Int, Bool, Float, Double, Decimal, ExampleClass, Char);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
            Assert.Equal(Decimal, @object.Decimal);
            Assert.Equal(ExampleClass, @object.ExampleClass);
            Assert.Equal(Char, @object.Char);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsingConstructorWith9Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith9ParametersInConstructor>.Create(String, Int, Bool, Float, Double, Decimal, ExampleClass, Char, Byte);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
            Assert.Equal(Decimal, @object.Decimal);
            Assert.Equal(ExampleClass, @object.ExampleClass);
            Assert.Equal(Char, @object.Char);
            Assert.Equal(Byte, @object.Byte);
        }
    }
}
