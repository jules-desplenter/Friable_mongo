using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Friable_mongo.InfoModels.DTO
{
    public class SupportDTO
    {
        public Guid Id { get; set; }

        public string? Based { get; set; }

        public List<string>? Material { get; set; }

        public string? Attachment { get; set; }

        public string? MaterialSerialized
        {
            get => JsonConvert.SerializeObject(Material);
            set => Material = JsonConvert.DeserializeObject<List<string>>(MaterialSerialized);
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

        public List<string>? Surface { get; set; }

        public string? SurfaceSerialized
        {
            get => JsonConvert.SerializeObject(Surface);
            set => Surface = JsonConvert.DeserializeObject<List<string>>(SurfaceSerialized);
        }

        [NotMapped]
        public List<string>? Damage { get; set; }

        public string? DamageSerialized
        {
            get => JsonConvert.SerializeObject(Damage);
            set => Damage = JsonConvert.DeserializeObject<List<string>>(DamageSerialized);
        }

        [MaxLength]
        public string? RemarksCondition { get; set; }

        public virtual PictorialDTO? Pictorial { get; set; }
    }
}
