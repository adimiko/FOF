![logo-FOF](https://user-images.githubusercontent.com/53557466/200375472-9965e687-b8f6-4cb7-94b6-7b84a17352d6.png)
### Fast Object Factory :factory: 
Create objects using a public or a non-public constructor.

### Benefits:

- Simple to use
- High performance reflection
- No external dependencies
- Over `10x` faster than `Activator` from System namespace
- Option to use a private constructor with parameters

### Installation
```sh
dotnet add package FOF
```
Package is hosted on [NuGet](https://www.nuget.org/packages/FOF).

### Example
Example class which has constructor with parameters.

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
