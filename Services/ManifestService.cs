using Friable_mongo.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Friable_mongo.Services
{
    public class ManifestService
    {
        private readonly IMongoCollection<Manifest> _manifestsCollection;

        public ManifestService(
            IOptions<FriableDatabaseSettings> bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                bookStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                bookStoreDatabaseSettings.Value.DatabaseName);

            _manifestsCollection = mongoDatabase.GetCollection<Manifest>(
                bookStoreDatabaseSettings.Value.BooksCollectionName);
        }

        public async Task<List<Manifest>> GetAsync() =>
            await _manifestsCollection.Find(_ => true).ToListAsync();

        public async Task<Manifest?> GetAsync(string id) =>
            await _manifestsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Manifest newBook)
        {
            try
            {
                await _manifestsCollection.InsertOneAsync(newBook);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task UpdateAsync(string id, Manifest updatedBook) =>
            await _manifestsCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        public async Task RemoveAsync(string id) =>
            await _manifestsCollection.DeleteOneAsync(x => x.Id == id);
    }
}
