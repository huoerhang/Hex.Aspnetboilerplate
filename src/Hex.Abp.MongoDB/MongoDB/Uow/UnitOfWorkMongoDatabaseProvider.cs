using Abp.Dependency;
using MongoDB.Driver;

namespace Hex.Abp.MongoDB.Uow
{
    public class UnitOfWorkMongoDatabaseProvider : IMongoDatabaseProvider, ITransientDependency
    {
        public IMongoDatabase Database
        {
            get
            {
                //return ((MongoDbUnitOfWork)_currentUnitOfWork.Current).Database;
                return IocManager.Instance.Resolve<MongoDbUnitOfWork>().Database;
            }
        }
    }
}
