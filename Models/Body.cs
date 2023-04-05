namespace Friable_mongo.Models
{
    public class Body
    {
       
        public string? Id { get; set; }

        public string Type { get; set; }

        public string? Format { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public string? Value { get; set; }
        public string? Language { get; set; }

        public List<Image>? Items { get; set; }

        public Selector? Selector { get; set; }

        public Source? Source { get; set; }

        public List<Service>? Service { get; set; }
    }
}
