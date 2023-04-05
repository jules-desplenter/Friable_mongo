using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class Supplementary
    {
        [Url]
        public string Id { get; set; }

        public string type { get; set; }
    }
}
