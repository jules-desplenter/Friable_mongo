using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class AnnotationsTarget
    {

        [Url]
        public string Id { get; set; }
        public string Type { get; set; }
        public List<AnnotationTarget> Items { get; set; }
    }
}
