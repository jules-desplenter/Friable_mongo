namespace Friable_mongo.Models
{
    public class Source
    {
       
        public string? Id { get; set; }

        public string Type { get; set; }

        public string? Format { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public string? Value { get; set; }
        public string? Language { get; set; }

        public List<Service>? Service { get; set; }

        public List<Image>? Items { get; set; }
    }
}
