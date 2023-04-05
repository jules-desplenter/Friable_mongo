namespace Friable_mongo.InfoModels
{
    public class Date
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Text { get; set; }
        public string? Location { get; set; }
        public string? Media { get; set; }
        public string? Value { get; set; }

        // extra link
        public Guid IdentificationId { get; set; }
        public virtual Identification Identification { get; set; }

    }
}
