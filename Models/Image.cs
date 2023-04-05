using static System.Net.Mime.MediaTypeNames;

namespace Friable_mongo.Models
{
    public class Image
    {
      
        public string? Id { get; set; }

        public string Type { get; set; }

        public string? Format { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public Value Label { get; set; }

        public List<Service> Service { get; set; }
    }
}
