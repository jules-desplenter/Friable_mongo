namespace Friable_mongo.Models
{
    public class ContentResource
    {

        public Value? Label { get; set; }

        public List<Metadata>? Metadata { get; set; }

        public Value? Summary { get; set; }

        public Metadata? RequiredStatement { get; set; }

        public string Rights { get; set; }

        public Agent? Provider { get; set; }

        public Thumbnail? Thumbnail { get; set; }

        public string? Format { get; set; }

        public string? Profile { get; set; }

        public int? height { get; set; }

        public int? Width { get; set; }

        public int? Duration { get; set; }

        public List<Annotations>? Annotations { get; set; }


    }
}
