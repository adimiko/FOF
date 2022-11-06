using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOF.TestSamples.Classes
{
    public class ClassWith3ParametersInConstructor
    {
        public string String { get; private set; }

        public int Int { get; private set; }

        public bool Bool { get; private set; }

        private ClassWith3ParametersInConstructor(string @string, int @int, bool @bool)
        {
            String = @string;
            Int = @int;
            Bool = @bool;
        }
    }
}
