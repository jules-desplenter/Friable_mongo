using AutoMapper;
using Friable_mongo.InfoModels.DTO;
using Friable_mongo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Friable_mongo.Services
{
    public class AnnotationService
    {
        private readonly IMongoCollection<Manifest> _manifestsCollection;
        public AnnotationService(IOptions<FriableDatabaseSettings> bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(bookStoreDatabaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(bookStoreDatabaseSettings.Value.DatabaseName);
            _manifestsCollection = mongoDatabase.GetCollection<Manifest>(bookStoreDatabaseSettings.Value.BooksCollectionName);
        }
        public async Task<List<AnnotationsTarget>?> GetAnnotations(string id, int page)
        {
            var manifest = await _manifestsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            if (manifest != null)
            {
                manifest.Id = "https://localhost:7148/api/manifest/" + manifest.Id + "/manifest.json";
                return manifest.Items[page].Annotations;

            }
            return null;
        }

        public async Task AddAnnotation(dynamic annotation, string id)
        {
            var manifest = await _manifestsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            AnnotationTarget ano = new AnnotationTarget()
            {
                Id = annotation.id,
                Motivation = "tagging",
                Target =  new Target()
                {
                    Type = "SpecificResource",
                    Source = annotation.target.source,
                    Selector = new Selector()
                    {
                        Type = annotation.target.selector[1].type,
                        Value = annotation.target.selector[1].value
                    }
                },
                Type = annotation.type,
                Body = new Body()
                {
                    Id = annotation.id,
                    Type = annotation.body.type,
                    Value = annotation.body.value,
                    Format = "text/html",            
                }
            };
            manifest.Items[0].Annotations[0].Items.Add(ano);
            await _manifestsCollection.ReplaceOneAsync(x => x.Id == id, manifest);
        }

        public async Task DeleteAnnotation(string id, int page, string annoid)
        {
            var manifest = await _manifestsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            if (manifest != null)
            {
                var cool = manifest.Items[page - 1].Annotations[0].Items.FirstOrDefault(x => x.Id == annoid);
                manifest.Items[page - 1].Annotations[0].Items.Remove(cool);
                await _manifestsCollection.ReplaceOneAsync(x => x.Id == id, manifest);
            }
        }

        public async Task<AnnotationTarget> GetAnnotation(string id, int page, string annoid)
        {
            var manifest = await _manifestsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            if (manifest != null)
            {
                var cool = manifest.Items[page - 1].Annotations[0].Items.FirstOrDefault(x => x.Id == annoid);
                return cool;
            }
            return null;
        }
        public async Task<AnnotationTarget> UpdateAnnotation(dynamic annotation, string id, int page, string annoid)
        {
            var manifest = await _manifestsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            if (manifest != null)
            {
                var cool = manifest.Items[page - 1].Annotations[0].Items.FirstOrDefault(x => x.Id == annoid);
                manifest.Items[page - 1].Annotations[0].Items.Remove(cool);
                cool.Body.Type = annotation.body.type;
                cool.Body.Value = annotation.body.value;
                manifest.Items[page - 1].Annotations[0].Items.Add(cool);
                await _manifestsCollection.ReplaceOneAsync(x => x.Id == id, manifest);
            }
            return null;
        }
    }
}
