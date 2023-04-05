namespace Friable_mongo.Models
{
    public class Features
    {
      
        public string Id { get; set; }
        public string Type { get; set; }

        public Properties? Properties { get; set; }

        public Geometry? Geometry { get; set; }
    }
}
