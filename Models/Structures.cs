namespace Friable_mongo.Models
{
    public class Structures
    { 
        public string Id { get; set; }
        public string Type { get; set; }

        public Value? Label { get; set; }

        public List<Range> Items { get; set; }
    }
}
