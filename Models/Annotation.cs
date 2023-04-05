using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Friable_mongo.Models
{
    public class Annotation
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public string? Motivation { get; set; }
        public Value? Label { get; set; }

        public List<Metadata>? Metadata { get; set; }

        public Value? Summary { get; set; }

        public Metadata? RequiredStatement { get; set; }

        public string? Rights { get; set; }

        public Agent? Provider { get; set; }

        public string? TimeMode { get; set; }

        public List<Items>? Items { get; set; }

        public Body Body { get; set; }

        public string? Target { get; set; }


    }
}
