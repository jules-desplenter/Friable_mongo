using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class Start
    {
       
        [Url]
        public string Id { get; set; }

        public string Type { get; set; }

        public string? Source { get; set; }
        public Selector? Selector { get; set; }
    }
}
