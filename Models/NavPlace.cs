namespace Friable_mongo.Models
{
    public class NavPlace
    {
        public string Id { get; set; }
        public string Type { get; set; }

        public List<Features>? Features { get; set; }

    }
}
