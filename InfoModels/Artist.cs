using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.InfoModels
{
    public class Artist
    {
        [Key]
        public Guid Id { get; set; }

        public string? SurName { get; set; }
        public string? FirstName { get; set; }

        // extra link
        public Guid IdentificationId { get; set; }
        public  virtual Identification Identification { get; set; }

    }
}
