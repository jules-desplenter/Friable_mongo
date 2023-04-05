using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class SeeAlso
    {
        
        // kan ook @id en @type zijn
        [Url]
        public string Id { get; set; }
        public string Type { get; set; }
        public string? Profile { get; set; }
        public Value? Label { get; set; }
        public string? Format { get; set; }
    }
}
