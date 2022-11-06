using FOF.Tests.SeedWorks;
using FOF.TestSamples.Classes;
using System.Collections.Concurrent;
using Xunit;

namespace FOF.Tests.Factories
{
    public class ThreadSafetyTests
    {
        [Fact]
        public void FactoryCreateOnlyOneTypeObject()
        {
            // Arrange
            const int expectedNumberOfObjects = 20000;
            var _objects = new ConcurrentBag<object>();

            // Act
            Multithreader.Run(expectedNumberOfObjects, () =>
            {
                var @object = Factory<ExampleClass>.Create("string", 1);
                _objects.Add(@object);
            });

            // Assert
            Assert.Equal(expectedNumberOfObjects, _objects.Count);
        }

        [Fact]
        public void FactoryCreateDifferentTypesOfObjects()
        {
            // Arrange
            const int expectedNumberOfObjects = 20000;
            var _objects = new ConcurrentBag<object>();

            // Act
            Multithreader.Run(expectedNumberOfObjects, () =>
            {
                var randomValue = ThreadSafeRandom.Next() % 8;

                const string @string = "Text";
                const int @int = 1;
                const bool @bool = true;
                const float @float = 10.0f;
                const double @double = 10.00;
                const decimal @decimal = 10.00m;
                ExampleClass exampleClass = Factory<ExampleClass>.Create("string", 1);

                object @object;
                switch (randomValue)
                {
                    case 0:
                        @object = Factory<ClassWithParameterlessConstructor>.Create();
                        break;
                    case 1:
                        @object = Factory<ClassWith1ParameterInConstructor>.Create(@string);
                        break;
                    case 2:
                        @object = Factory<ClassWith2ParametersInConstructor>.Create(@string, @int);
                        break;
                    case 3:
                        @object = Factory<ClassWith3ParametersInConstructor>.Create(@string, @int, @bool);
                        break;
                    case 4:
                        @object = Factory<ClassWith4ParametersInConstructor>.Create(@string, @int, @bool, @float);
                        break;
                    case 5:
                        @object = Factory<ClassWith5ParametersInConstructor>.Create(@string, @int, @bool, @float, @double);
                        break;
                    case 6:
                        @object = Factory<ClassWith6ParametersInConstructor>.Create(@string, @int, @bool, @float, @double, @decimal);
                        break;
                    case 7:
                        @object = Factory<ClassWith7ParametersInConstructor>.Create(@string, @int, @bool, @float, @double, @decimal, exampleClass);
                        break;
                    default:
                        throw new NotImplementedException();
                }

                _objects.Add(@object);
            });

            // Assert
            Assert.Equal(expectedNumberOfObjects, _objects.Count);
        }
    }
}
