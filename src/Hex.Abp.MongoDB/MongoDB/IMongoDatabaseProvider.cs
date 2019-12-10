using MongoDB.Driver;

namespace Hex.Abp.MongoDB
{
    public interface IMongoDatabaseProvider
    {
        IMongoDatabase Database { get; }
    }
}
