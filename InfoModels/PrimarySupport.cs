using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Friable_mongo.InfoModels
{
    public class PrimarySupport
    {
        [Key]
        public Guid Id { get; set; }

        public string? Based { get; set; }

        [NotMapped] 
        public List<string>? Material { get; set; }

        public string? MaterialSerialized
        {
            get => JsonConvert.SerializeObject(Material);
            set => Material = JsonConvert.DeserializeObject<List<string>>(value);
        }

        public string? PaperType1 { get; set; }
        public string? PaperType2 { get; set; }
        public string? PaperType3 { get; set; }

        public string? Assemblage { get; set; }
        public string? RectoVerso { get; set; }
        public string? Watermark { get; set; }
        public string? WatermarkDescription { get; set; }
        public string? WatermarkLocation { get; set; }
        public string? Pinholed { get; set; }
        public string? PinholesDescription { get; set; }
        public string? PinholesLocation { get; set; }
        public int? Amount { get; set; }
        public string? Location { get; set; }

        [MaxLength]
        public string? RemarksDescription { get; set; }
        public string? GeneralCondition { get; set; }
        public string? Surface { get; set; }

        [NotMapped]
        public List<string>? Damage { get; set; }

        public string? DamageSerialized
        {
            get => JsonConvert.SerializeObject(Damage);
            set => Damage = JsonConvert.DeserializeObject<List<string>>(value);
        }

        [MaxLength]
        public string? RemarksCondition { get; set; }

        public virtual PrimaryPictorial? Pictorial { get; set; }

        // extra links
        public string RegistrationID { get; set; }
        public virtual Registration? Registration { get; set; }
    }
}
