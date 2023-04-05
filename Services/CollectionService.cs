using Friable_mongo.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Friable_mongo.Services
{
    public class CollectionService
    {
        private readonly IMongoCollection<Collection> _CollectionsCollection;

        public CollectionService(
            IOptions<FriableDatabaseSettings> bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                bookStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                bookStoreDatabaseSettings.Value.DatabaseName);

            _CollectionsCollection = mongoDatabase.GetCollection<Collection>(
                bookStoreDatabaseSettings.Value.CollectionCollectionName);
        }

        public async Task<List<Collection>> GetAsync() =>
            await _CollectionsCollection.Find(_ => true).ToListAsync();

        public async Task<Collection?> GetAsync(string id) =>
            await _CollectionsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Collection newBook)
        {
            try
            {
                await _CollectionsCollection.InsertOneAsync(newBook);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task UpdateAsync(string id, Collection updatedBook) =>
            await _CollectionsCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        public async Task RemoveAsync(string id) =>
            await _CollectionsCollection.DeleteOneAsync(x => x.Id == id);
    }
}
