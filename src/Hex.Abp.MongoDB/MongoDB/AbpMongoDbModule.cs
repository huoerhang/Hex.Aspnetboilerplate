using System.Reflection;
using Abp;
using Abp.Modules;
using Hex.Abp.MongoDB.Configuration;

namespace Hex.Abp.MongoDB
{
    [DependsOn(typeof(AbpKernelModule))]
    public class AbpMongoDbModule : AbpModule
    {
        public override void PreInitialize()
        {
            IocManager.Register<IAbpMongoDbModuleConfiguration, AbpMongoDbModuleConfiguration>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
