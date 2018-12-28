namespace ExampleRegistry.Tests
{
    using System.Collections.Generic;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Primitives;

    public class ConfigurationStub : IConfiguration
    {
        public IConfigurationSection GetSection(string key) => null;

        public IEnumerable<IConfigurationSection> GetChildren() => new List<IConfigurationSection>();

        public IChangeToken GetReloadToken() => throw new System.NotImplementedException();

        public string this[string key]
        {
            get => null;
            set => throw new System.NotImplementedException();
        }
    }
}
