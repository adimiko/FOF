namespace FOF.TestSamples.Classes
{
    public class ClassWithProtectedInternalConstructor
    {
        public string String { get; protected set; }

        protected internal ClassWithProtectedInternalConstructor(string @string)
        {
            String = @string;
        }
    }
}
