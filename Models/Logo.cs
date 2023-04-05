using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class Logo
    {
  

        [Url]
        public string Id { get; set; }

        // must be image
        public string Type { get; set; }

        public string? Format { get; set; }

        public int? Height { get; set; }
        public int? Width { get; set; }

    }
}
