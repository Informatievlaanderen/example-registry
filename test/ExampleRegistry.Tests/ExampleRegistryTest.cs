namespace ExampleRegistry.Tests
{
    using Be.Vlaanderen.Basisregisters.EventHandling;
    using Be.Vlaanderen.Basisregisters.EventHandling.Autofac;
    using Autofac;
    using Infrastructure.Modules;
    using Newtonsoft.Json;
    using Xunit.Abstractions;

    public class ExampleRegistryTest : AutofacBasedTest
    {
        private readonly JsonSerializerSettings _eventSerializerSettings = EventsJsonSerializerSettingsProvider.CreateSerializerSettings();

        public ExampleRegistryTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper) { }

        protected override void ConfigureCommandHandling(ContainerBuilder builder)
            => builder.RegisterModule(new CommandHandlingModule(new ConfigurationStub()));

        protected override void ConfigureEventHandling(ContainerBuilder builder)
            => builder.RegisterModule(new EventHandlingModule(typeof(DomainAssemblyMarker).Assembly, _eventSerializerSettings));
    }
}
