namespace ExampleRegistry.Example.Commands
{
    public class DoSimpleExample
    {
        public ExampleName Name { get; }

        public DoSimpleExample(ExampleName name) => Name = name;
    }
}
