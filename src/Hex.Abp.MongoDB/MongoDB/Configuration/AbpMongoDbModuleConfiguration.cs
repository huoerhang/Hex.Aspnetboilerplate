﻿namespace Hex.Abp.MongoDB.Configuration
{
    public class AbpMongoDbModuleConfiguration : IAbpMongoDbModuleConfiguration
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
