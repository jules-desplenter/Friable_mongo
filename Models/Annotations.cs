using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class Annotations
    {
     
        [Url]
        public string Id { get; set; }
        public string Type { get; set; }
        public List<Annotation> Items { get; set; }
    }
}
