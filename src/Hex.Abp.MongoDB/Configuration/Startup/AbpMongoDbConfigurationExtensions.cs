using Abp.Configuration.Startup;
using Hex.Abp.MongoDB.Configuration;

namespace Hex.Abp.Configuration.Startup
{
    public static class AbpMongoDbConfigurationExtensions
    {
        public static IAbpMongoDbModuleConfiguration AbpMongoDb(this IModuleConfigurations configurations)
        {
            return configurations.AbpConfiguration.Get<IAbpMongoDbModuleConfiguration>();
        }
    }
}
