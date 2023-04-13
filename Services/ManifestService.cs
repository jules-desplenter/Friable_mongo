using Friable_mongo.Models;
using Friable_mongo.Models.DTO;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
namespace Friable_mongo.Services
{
    public class ManifestService
    {
        private readonly IMongoCollection<Manifest> _manifestsCollection;
        public ManifestService(IOptions<FriableDatabaseSettings> bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(bookStoreDatabaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(bookStoreDatabaseSettings.Value.DatabaseName);
            _manifestsCollection = mongoDatabase.GetCollection<Manifest>(bookStoreDatabaseSettings.Value.BooksCollectionName);
        }
        public async Task<List<Manifest>> GetAsync() => await _manifestsCollection.Find(_ => true).ToListAsync();
        public async Task<Manifest?> GetAsync(string id)
        {
            var manifest = await _manifestsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            manifest.Id = "https://localhost:7148/api/manifest/" + manifest.Id + "/manifest.json";
            return manifest;
        }
        public async Task CreateAsync(Manifest newBook)
        {
            try
            {
                if (newBook.Id.Contains("manifest.json"))
                {
                    string[] parts = newBook.Id.Split('/');
                    string thingINeed = parts[parts.Length - 2];
                    newBook.Id = thingINeed;
                }
                await _manifestsCollection.InsertOneAsync(newBook);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public async Task UpdateAsync(string id, Manifest updatedBook) => await _manifestsCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);
        public async Task RemoveAsync(string id) => await _manifestsCollection.DeleteOneAsync(x => x.Id == id);
        public async Task AddManifestDTO(AddManifestDTO man)
        {
            var manifest = new Manifest()
            {
                Id = man.ObjectNumber,
                Context = "http://iiif.io/api/presentation/3/context.json",
                Type = "Manifest",
                Label = new Value()
                {
                    En = new List<string>() {
              man.Label
            }
                },
                Metadata = new List<Metadata>() {
            new Metadata() {
                Label = new Value() {
                    En = new List < string > {
                      "date"
                    }
                  },
                  Value = new Value() {
                    En = new List < string > {
                      man.Date
                    }
                  }
              },
              new Metadata() {
                Label = new Value() {
                    En = new List < string > {
                      "people"
                    }
                  },
                  Value = new Value() {
                    En = new List < string > {
                      "artist: " + man.Artist
                    }
                  }
              },
              new Metadata() {
                Label = new Value() {
                    En = new List < string > {
                      "medium"
                    }
                  },
                  Value = new Value() {
                    En = new List < string > {
                      man.Medium
                    }
                  }
              },
              new Metadata() {
                Label = new Value() {
                    En = new List < string > {
                      "technique"
                    }
                  },
                  Value = new Value() {
                    En = new List < string > {
                      man.Technique
                    }
                  }
              },
              new Metadata() {
                Label = new Value() {
                    En = new List < string > {
                      "provenance"
                    }
                  },
                  Value = new Value() {
                    En = new List < string > {
                      man.Provenance
                    }
                  }
              },
          },
                Items = new List<Canvas>() {
            new Canvas() {
              Id = "https://localhost:7148/api/manifest/" + man.ObjectNumber + "/canvas/p1",
                Type = "Canvas",
                Height = man.Height,
                Width = man.Width,
                Annotations = new List <AnnotationsTarget> {
                  new AnnotationsTarget() {
                    Id = "https://localhost:7148/api/manifest/" + man.ObjectNumber + "/page/p2/1",
                      Type = "AnnotationPage",
                      Items = new List < AnnotationTarget > {
                        new AnnotationTarget() {
                          Id = Guid.NewGuid().ToString(),
                            Type = "Annotation",
                            Motivation = "commenting",
                            Body = new Body() {
                              Type = "TextualBody",
                                Format = "text/plain",
                                Value = "First annotation"
                            },
                            Target = new Target() {
                              Type = "SpecificResource",
                                Source = "https://localhost:7148/api/manifest/" + man.ObjectNumber + "/canvas/p1",
                            }

                        }
                      }
                  }
                },
                Items = new List < AnnotationPage > {
                  new AnnotationPage() {
                    Id = "https://localhost:7148/api/manifest/" + man.ObjectNumber + "/page/p1/1",
                      Type = "AnnotationPage",
                      Items = new List < Annotation > () {
                        new Annotation() {
                          Id = "https://localhost:7148/api/manifest/" + man.ObjectNumber + "/annotation/p0001-image",
                            Motivation = "painting",
                            Type = "Annotation",
                            Body = new Body() {
                              Id = man.Imagelink + "/full/max/0/default.jpg",
                                Type = "Image",
                                Format = "image/jpeg",
                                Height = man.Height,
                                Width = man.Width,
                                Service = new List < Service > () {
                                  new Service() {
                                    Id = man.Imagelink,
                                      Profile = "level1",
                                      Type = "ImageService3",
                                  }
                                },
                            },

                            Target = "https://localhost:7148/api/manifest/" + man.ObjectNumber + "/canvas/p1",
                            }
                        }
                      }
                  }
                }
            }
          
            };
            await _manifestsCollection.InsertOneAsync(manifest);
        }
    }
};