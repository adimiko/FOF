using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOF.TestSamples.Classes
{
    public class ClassWith1ParameterInConstructor
    {
        public string String { get; private set; }

        private ClassWith1ParameterInConstructor(string @string)
        {
            String = @string;
        }
    }
}
