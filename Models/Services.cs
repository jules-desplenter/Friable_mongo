using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class Services
    {
      
        // kan ook @id en @type zijn
        [Url]
        public string Id { get; set; }
        public string Type { get; set; }
        public string? Profile { get; set; }

        public List<Service>? Service { get; set; }
    }
}
