using System.ComponentModel.DataAnnotations;

namespace Friable_mongo.InfoModels.DTO
{
    public class RegistrationDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Function { get; set; }
        public string? Reason { get; set; }
        public int? Version { get; set; }
        public string? Remarks { get; set; }
        public virtual IdentificationDTO? Identification { get; set; }
        public virtual SupportDTO? PrimarySupport { get; set; }
        public virtual SupportDTO? SecondarySupport { get; set; }
        public virtual StorageDTO? Storage { get; set; }
        public virtual MountingDTO? Mounting { get; set; }
    }
}
