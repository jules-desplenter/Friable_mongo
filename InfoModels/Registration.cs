using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.InfoModels
{
    public class Registration
    {
        [Key]
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Function { get; set; }
        public string? Reason { get; set; }
        public int? Version { get; set; }

        public string? Date { get; set; }

        [MaxLength]
        public string? Remarks { get; set; }
        public virtual Identification? Identification { get; set; }
        public virtual PrimarySupport? PrimarySupport { get; set; }
        public virtual SecondarySupport? SecondarySupport { get; set; }
        public virtual Storage? Storage { get; set; }
        public virtual Mounting? Mounting { get; set; }
    }
}
