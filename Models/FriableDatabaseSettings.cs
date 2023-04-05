using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Friable_mongo.Models
{
    public class FriableDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string BooksCollectionName { get; set; } = null!;

        public string CollectionCollectionName { get; set; } = null!;
    }
}
