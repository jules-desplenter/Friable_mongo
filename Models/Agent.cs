using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class Agent
    {
        
        [Url]
        public string Id { get; set; }

        // must be value "Agent"
        public string Type { get; set; }

        public Value Label { get; set; }

        public List<Homepage>? Homepage { get; set; }

        public List<Logo>? Logo { get; set; }

        public List<SeeAlso>? SeeAlso { get; set; }
    }
}
