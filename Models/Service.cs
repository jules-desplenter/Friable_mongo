using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace Friable_mongo.Models
{
    public class Service
    {
        // kan ook @id en @type zijn
        [Url]
        public string Id { get; set; }
        public string Type { get; set; }
        public string? Profile { get; set; }
    }
}
