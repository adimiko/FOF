namespace FOF.TestSamples.Classes
{
    public class ClassWithPrivateConstructor
    {
        public string String { get; protected set; }

        private ClassWithPrivateConstructor(string @string)
        {
            String = @string;
        }
    }
}
