namespace FOF.TestSamples.Classes
{
    public class ClassWithProtectedConstructor
    {
        public string String { get; protected set; }

        protected ClassWithProtectedConstructor(string @string)
        {
            String = @string;
        }
    }
}
