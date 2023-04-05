using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class Collection
    {
    

        [Url]
        public string Id { get; set; }
        public Value Label { get; set; }

        public List<Manifest> Items { get; set; }
        public List<Metadata>? Metadata { get; set; }

        public Value? Summary { get; set; }

        public Metadata? RequiredStatement { get; set; }

        public string? Rights { get; set; }

        public Agent? Provider { get; set; }

        public Thumbnail? Thumbnail { get; set; }

        //must be xsd datetime literal
        public string? NavDate { get; set; }

        public PlaceholderCanvas? PlaceholderCanvas { get; set; }

        public string Type { get; set; }

        public string? ViewingDirection { get; set; }

        public List<string>? Behavior { get; set; }

        public List<Homepage>? Rendering { get; set; }

        public List<Service>? Service { get; set; }

        public Services? Services { get; set; }

        public List<SeeAlso>? SeeAlso { get; set; }

        public List<PartOf>? PartOf { get; set; }

        public List<Annotations>? Annotations { get; set; }



    }
}
