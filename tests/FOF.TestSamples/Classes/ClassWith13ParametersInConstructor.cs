using System;
using System.Collections.Generic;

namespace FOF.TestSamples.Classes
{
    public class ClassWith13ParametersInConstructor
    {
        public string String { get; private set; }

        public int Int { get; private set; }

        public bool Bool { get; private set; }

        public float Float { get; private set; }

        public double Double { get; private set; }

        public decimal Decimal { get; private set; }

        public ExampleClass ExampleClass { get; private set; }

        public char Char { get; private set; }

        public int[] Array { get; private set; }

        public IEnumerable<int> Enumerable { get; private set; }

        public DayOfWeek DayOfWeek { get; private set; }

        public DateTime DateTime { get; private set; }

        public object Object { get; private set; }

        private ClassWith13ParametersInConstructor(string @string, int @int, bool @bool, float @float, double @double, decimal @decimal, ExampleClass exampleClass, char @char, IEnumerable<int> enumerable, int[] array, DayOfWeek dayOfWeek, DateTime dateTime, object @object)
        {
            String = @string;
            Int = @int;
            Bool = @bool;
            Float = @float;
            Double = @double;
            Decimal = @decimal;
            ExampleClass = exampleClass;
            Char = @char;
            Enumerable = enumerable;
            Array = array;
            DayOfWeek = dayOfWeek;
            DateTime = dateTime;
            Object = @object;
        }
    }
}
