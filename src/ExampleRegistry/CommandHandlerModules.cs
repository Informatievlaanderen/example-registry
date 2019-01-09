namespace ExampleRegistry
{
    using System;
    using Example;
    using Be.Vlaanderen.Basisregisters.CommandHandling.SqlStreamStore.Autofac;
    using Be.Vlaanderen.Basisregisters.CommandHandling;
    using Autofac;

    public static class CommandHandlerModules
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            // Syntax for commandhandler which do not use SqlStreamStore to store events
            containerBuilder.RegisterType<SimpleExampleCommandHandlerModule>()
                .Named<CommandHandlerModule>(typeof(SimpleExampleCommandHandlerModule).FullName)
                .As<CommandHandlerModule>();

            // Regular syntax for EventSourcing with SqlStreamStore
            containerBuilder
                .RegisterSqlStreamStoreCommandHandler<ExampleCommandHandlerModule>(
                    c => handler =>
                        new ExampleCommandHandlerModule(
                            c.Resolve<Func<IExamples>>(),
                            handler));
        }
    }
}
