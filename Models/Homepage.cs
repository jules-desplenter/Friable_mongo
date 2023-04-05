using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class Homepage
    {
        [Url]
        public string Id { get; set; }

        public string Type { get; set; }

        public Value Label { get; set; }

        public string? Format { get; set; }

    }
}
