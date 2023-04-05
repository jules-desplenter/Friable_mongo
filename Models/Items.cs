using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class Items
    {
       
        [Url]
        public string Id { get; set; }
        public string type { get; set; }
    }
}
