using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class Thumbnail
    {
      
        [Url]
        public string Id { get; set; }

        public string Type { get; set; }

        public string? Format { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }
    }
}
