using System.Threading.Tasks;
using MongoDB.Driver;
using Abp.Dependency;
using Abp.Domain.Uow;
using Hex.Abp.MongoDB.Configuration;

namespace Hex.Abp.MongoDB.Uow
{
    public class MongoDbUnitOfWork : UnitOfWorkBase, ITransientDependency
    {
        /// <summary>
        /// Gets a reference to MongoDB Database.
        /// </summary>
        public IMongoDatabase Database { get; private set; }

        private readonly IAbpMongoDbModuleConfiguration _configuration;

        /// <summary>
        /// Constructor.
        /// </summary>
        public MongoDbUnitOfWork(
            IAbpMongoDbModuleConfiguration configuration,
            IConnectionStringResolver connectionStringResolver,
            IUnitOfWorkFilterExecuter filterExecuter,
            IUnitOfWorkDefaultOptions defaultOptions)
            : base(
                  connectionStringResolver,
                  defaultOptions,
                  filterExecuter)
        {
            _configuration = configuration;
            Database = new MongoClient(_configuration.ConnectionString)
                .GetDatabase(_configuration.DatabaseName);
        }

#pragma warning disable
        protected override void BeginUow()
        {
            //TODO: MongoClientExtensions.GetServer(MongoClient)' is obsolete: 'Use the new API instead.
            //Database = new MongoClient(_configuration.ConnectionString)
            //    .GetServer()
            //    .GetDatabase(_configuration.DatabaseName);
        }
#pragma warning restore

        public override void SaveChanges()
        {

        }

#pragma warning disable 1998
        public override async Task SaveChangesAsync()
        {

        }
#pragma warning restore 1998

        protected override void CompleteUow()
        {

        }

#pragma warning disable 1998
        protected override async Task CompleteUowAsync()
        {

        }
#pragma warning restore 1998
        protected override void DisposeUow()
        {

        }
    }
}
