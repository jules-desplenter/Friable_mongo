using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Friable_mongo.InfoModels.DTO
{
    public class IdentificationDTO
    {
        public Guid Id { get; set; }
        public int? InvetoryNumber { get; set; }

        public virtual ArtistDTO? Artist { get; set; }
        public string? TitleDutch { get; set; }
        public string? TitleFrench { get; set; }
        public virtual DateDTO? Date { get; set; }
        public virtual SignatureDTO? Signature { get; set; }
        public virtual ICollection<InscriptionDTO>? Inscriptions { get; set; }
        public virtual ICollection<CollectionMarkDTO>? CollectionMarks { get; set; }

        [NotMapped]
        public List<string>? Materials { get; set; }

        public string? MaterialsSerialized
        {
            get => JsonConvert.SerializeObject(Materials);
            set => Materials = JsonConvert.DeserializeObject<List<string>>(MaterialsSerialized);
        }

        [NotMapped]
        public List<string>? Techniques { get; set; }
        public string? TechniquesSerialized
        {
            get => JsonConvert.SerializeObject(Techniques);
            set => Techniques = JsonConvert.DeserializeObject<List<string>>(TechniquesSerialized);
        }
        public string? Support { get; set; }
        public string? Framed { get; set; }
        public int? Top { get; set; }
        public int? Right { get; set; }
        public int? Bottom { get; set; }
        public int? Left { get; set; }
    }
}
