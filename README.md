# FOF
### Fast Object Factory :factory: 
Create objects using a public or non-public constructor.

Benefits:
- Simple to use
- High performance reflection
- No external dependencies
- Over `10x` faster than `Activator` from System namespace
- Option to use a private constructor with parameters

### Example
Eample class with private constructor with parameters.

    public class ExampleClass
    {
        public string String { get; }

        public int Int { get; }

        private ExampleClass(string @string, int @int)
        {
            String = @string;
            Int = @int;
        }
    }

An example of using a `Factory`.

    Factory<ExampleClass>.Create("Text", 1);
