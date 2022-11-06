using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOF.TestSamples.Classes
{
    public class ClassWith7ParametersInConstructor
    {
        public string String { get; private set; }

        public int Int { get; private set; }

        public bool Bool { get; private set; }

        public float Float { get; private set; }

        public double Double { get; private set; }

        public decimal Decimal { get; private set; }

        public ExampleClass ExampleClass { get; private set; }

        private ClassWith7ParametersInConstructor(string @string, int @int, bool @bool, float @float, double @double, decimal @decimal, ExampleClass exampleClass)
        {
            String = @string;
            Int = @int;
            Bool = @bool;
            Float = @float;
            Double = @double;
            Decimal = @decimal;
            ExampleClass = exampleClass;
        }
    }
}
