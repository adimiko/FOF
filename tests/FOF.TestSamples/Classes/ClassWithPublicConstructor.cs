using System;
using System.Collections.Generic;
using System.Text;

namespace FOF.TestSamples.Classes
{
    public class ClassWithPublicConstructor
    {
        public string String { get; protected set; }

        public ClassWithPublicConstructor(string @string)
        {
            String = @string;
        }
    }
}
