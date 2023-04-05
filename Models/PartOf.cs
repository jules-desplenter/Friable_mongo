using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class PartOf
    {

        [Url]
        public string Id { get; set; }
        public string Type { get; set; }
        public Value? Label { get; set; }
    }
}
