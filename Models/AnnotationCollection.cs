using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Friable_mongo.Models
{
    public class AnnotationCollection
    {
        public Value? Label { get; set; }

        public List<Metadata>? Metadata { get; set; }

        public Value? Summary { get; set; }

        public Metadata? RequiredStatement { get; set; }

        public string Rights { get; set; }

    }
}
