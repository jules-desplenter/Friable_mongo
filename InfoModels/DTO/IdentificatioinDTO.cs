using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Friable_mongo.InfoModels.DTO
{
    public class IdentificationDTO
    {
        public Guid Id { get; set; }
        public int? InventoryNumber { get; set; }

        public virtual ArtistDTO? Artist { get; set; }
        public string? TitleDutch { get; set; }
        public string? TitleFrench { get; set; }

        public string? CollectionMarkAccessible { get; set; }

        public virtual DateDTO? Date { get; set; }
        public virtual SignatureDTO? Signature { get; set; }
        public virtual ICollection<InscriptionDTO>? Inscriptions { get; set; }
        public virtual ICollection<CollectionMarkDTO>? CollectionMarks { get; set; }

        public string? Materials { get; set; }


        public string? Techniques { get; set; }
      
        public string? Support { get; set; }

        public List<string>? Framed { get; set; }

        public string? FramedSerialized
        {
            get => JsonConvert.SerializeObject(Framed);
            set => Framed = JsonConvert.DeserializeObject<List<string>>(FramedSerialized);
        }
        public int? Top { get; set; }
        public int? Right { get; set; }
        public int? Bottom { get; set; }
        public int? Left { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public string? Shape { get; set; }

    }
}
