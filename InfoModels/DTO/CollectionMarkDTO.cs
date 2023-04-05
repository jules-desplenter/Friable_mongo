namespace Friable_mongo.InfoModels.DTO
{
    public class CollectionMarkDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Text { get; set; }
        public string? Location { get; set; }
        public string? Media { get; set; }
        public string? Value { get; set; }
    }
}
