using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOF.Tests.SeedWorks
{
    public class ExampleClass
    {
        public string String { get; }

        public int Int { get; }

        private ExampleClass(string @string, int @int)
        {
            String = @string;
            Int = @int;
        }

        private ExampleClass(int @int, string @string)
        {
            String = @string;
            Int = @int;
        }
    }
}
