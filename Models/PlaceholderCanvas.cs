using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.Models
{
    public class PlaceholderCanvas
    {
 
        [Url]
        public string Id { get; set; }

        public string Type { get; set; }

        // straks alles van canvas hier in droppen
    }
}
