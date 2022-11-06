namespace FOF.TestSamples.Classes
{
    public class ClassWith2ParametersInConstructor
    {
        public string String { get; private set; }

        public int Int { get; private set; }

        private ClassWith2ParametersInConstructor(string @string, int @int)
        {
            String = @string;
            Int = @int;
        }
    }
}
