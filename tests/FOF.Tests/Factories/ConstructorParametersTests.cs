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

        private readonly static IEnumerable<int> Enumerable = new List<int> { 1, 2, 3 };

        private readonly static int[] Array = new int[] { 1, 2, 3 };

        private readonly static DayOfWeek DayOfWeek = DayOfWeek.Monday;

        private readonly static DateTime DateTime = DateTime.Now;

        private readonly static object Object = new object();

        private readonly static byte Byte = 1;

        private readonly static uint UInt = 1;

        private readonly static long Long = 1;

        [Fact]
        public void CreateObject_WhenFactoryUsesParameterlessConstructor_IsSuccessful()
            => Factory<ClassWithParameterlessConstructor>.Create();

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith1Parameter_IsSuccessful()
        {
            var @object = Factory<ClassWith1ParameterInConstructor>.Create(String);

            Assert.Equal(String, @object.String);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith2Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith2ParametersInConstructor>.Create(String, Int);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith3Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith3ParametersInConstructor>.Create(String, Int, Bool);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith4Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith4ParametersInConstructor>.Create(String, Int, Bool, Float);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith5Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith5ParametersInConstructor>.Create(String, Int, Bool, Float, Double);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith6Parameters_IsSuccessful()
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
        public void CreateObject_WhenFactoryUsesConstructorWith7Parameters_IsSuccessful()
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
        public void CreateObject_WhenFactoryUsesConstructorWith8Parameters_IsSuccessful()
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
        public void CreateObject_WhenFactoryUsesConstructorWith9Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith9ParametersInConstructor>.Create(String, Int, Bool, Float, Double, Decimal, ExampleClass, Char, Enumerable);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
            Assert.Equal(Decimal, @object.Decimal);
            Assert.Equal(ExampleClass, @object.ExampleClass);
            Assert.Equal(Char, @object.Char);
            Assert.Equal(Enumerable, @object.Enumerable);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith10Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith10ParametersInConstructor>.Create(String, Int, Bool, Float, Double, Decimal, ExampleClass, Char, Enumerable, Array);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
            Assert.Equal(Decimal, @object.Decimal);
            Assert.Equal(ExampleClass, @object.ExampleClass);
            Assert.Equal(Char, @object.Char);
            Assert.Equal(Enumerable, @object.Enumerable);
            Assert.Equal(Array, @object.Array);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith11Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith11ParametersInConstructor>.Create(String, Int, Bool, Float, Double, Decimal, ExampleClass, Char, Enumerable, Array, DayOfWeek);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
            Assert.Equal(Decimal, @object.Decimal);
            Assert.Equal(ExampleClass, @object.ExampleClass);
            Assert.Equal(Char, @object.Char);
            Assert.Equal(Enumerable, @object.Enumerable);
            Assert.Equal(Array, @object.Array);
            Assert.Equal(DayOfWeek, @object.DayOfWeek);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith12Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith12ParametersInConstructor>.Create(String, Int, Bool, Float, Double, Decimal, ExampleClass, Char, Enumerable, Array, DayOfWeek, DateTime);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
            Assert.Equal(Decimal, @object.Decimal);
            Assert.Equal(ExampleClass, @object.ExampleClass);
            Assert.Equal(Char, @object.Char);
            Assert.Equal(Enumerable, @object.Enumerable);
            Assert.Equal(Array, @object.Array);
            Assert.Equal(DayOfWeek, @object.DayOfWeek);
            Assert.Equal(DateTime, @object.DateTime);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith13Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith13ParametersInConstructor>.Create(String, Int, Bool, Float, Double, Decimal, ExampleClass, Char, Enumerable, Array, DayOfWeek, DateTime, Object);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
            Assert.Equal(Decimal, @object.Decimal);
            Assert.Equal(ExampleClass, @object.ExampleClass);
            Assert.Equal(Char, @object.Char);
            Assert.Equal(Enumerable, @object.Enumerable);
            Assert.Equal(Array, @object.Array);
            Assert.Equal(DayOfWeek, @object.DayOfWeek);
            Assert.Equal(DateTime, @object.DateTime);
            Assert.Equal(Object, @object.Object);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith14Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith14ParametersInConstructor>.Create(String, Int, Bool, Float, Double, Decimal, ExampleClass, Char, Enumerable, Array, DayOfWeek, DateTime, Object, Byte);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
            Assert.Equal(Decimal, @object.Decimal);
            Assert.Equal(ExampleClass, @object.ExampleClass);
            Assert.Equal(Char, @object.Char);
            Assert.Equal(Enumerable, @object.Enumerable);
            Assert.Equal(Array, @object.Array);
            Assert.Equal(DayOfWeek, @object.DayOfWeek);
            Assert.Equal(DateTime, @object.DateTime);
            Assert.Equal(Object, @object.Object);
            Assert.Equal(Byte, @object.Byte);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith15Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith15ParametersInConstructor>.Create(String, Int, Bool, Float, Double, Decimal, ExampleClass, Char, Enumerable, Array, DayOfWeek, DateTime, Object, Byte, UInt);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
            Assert.Equal(Decimal, @object.Decimal);
            Assert.Equal(ExampleClass, @object.ExampleClass);
            Assert.Equal(Char, @object.Char);
            Assert.Equal(Enumerable, @object.Enumerable);
            Assert.Equal(Array, @object.Array);
            Assert.Equal(DayOfWeek, @object.DayOfWeek);
            Assert.Equal(DateTime, @object.DateTime);
            Assert.Equal(Object, @object.Object);
            Assert.Equal(Byte, @object.Byte);
            Assert.Equal(UInt, @object.UInt);
        }

        [Fact]
        public void CreateObject_WhenFactoryUsesConstructorWith16Parameters_IsSuccessful()
        {
            var @object = Factory<ClassWith16ParametersInConstructor>.Create(String, Int, Bool, Float, Double, Decimal, ExampleClass, Char, Enumerable, Array, DayOfWeek, DateTime, Object, Byte, UInt, Long);

            Assert.Equal(String, @object.String);
            Assert.Equal(Int, @object.Int);
            Assert.Equal(Bool, @object.Bool);
            Assert.Equal(Float, @object.Float);
            Assert.Equal(Double, @object.Double);
            Assert.Equal(Decimal, @object.Decimal);
            Assert.Equal(ExampleClass, @object.ExampleClass);
            Assert.Equal(Char, @object.Char);
            Assert.Equal(Enumerable, @object.Enumerable);
            Assert.Equal(Array, @object.Array);
            Assert.Equal(DayOfWeek, @object.DayOfWeek);
            Assert.Equal(DateTime, @object.DateTime);
            Assert.Equal(Object, @object.Object);
            Assert.Equal(Byte, @object.Byte);
            Assert.Equal(UInt, @object.UInt);
            Assert.Equal(Long, @object.Long);
        }
    }
}
