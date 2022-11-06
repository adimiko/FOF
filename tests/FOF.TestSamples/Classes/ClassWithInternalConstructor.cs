using System;
using System.Collections.Generic;
using System.Text;

namespace FOF.TestSamples.Classes
{
    public class ClassWithInternalConstructor
    {
        public string String { get; protected set; }

        internal ClassWithInternalConstructor(string @string)
        {
            String = @string;
        }
    }
}
