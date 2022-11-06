namespace FOF.Tests.SeedWorks
{
    public class ClassWith4ParametersInConstructor
    {
        public string String { get; private set; }

        public int Int { get; private set; }

        public bool Bool { get; private set; }

        public float Float { get; private set; }

        private ClassWith4ParametersInConstructor(string @string, int @int, bool @bool, float @float)
        {
            String = @string;
            Int = @int;
            Bool = @bool;
            Float = @float;
        }
    }
}
