namespace ExampleRegistry.Example
{
    using Be.Vlaanderen.Basisregisters.AggregateSource;

    public interface IExamples : IAsyncRepository<Example, ExampleId> { }
}
