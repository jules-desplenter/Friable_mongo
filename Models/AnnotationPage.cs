using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Friable_mongo.Models
{
    public class AnnotationPage
    {
       
        [Url]
        public string Id { get; set; }

        public string Type { get; set; } = "AnnotationPage";

        public string? Behavior { get; set; }

        public List<Annotation> Items { get; set; }


    }
}
