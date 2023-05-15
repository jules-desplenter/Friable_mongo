using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Friable_mongo.InfoModels
{
    public class Identification
    {
        [Key]
        public Guid Id { get; set; }
        public int? InventoryNumber { get; set; }
        public virtual Artist? Artist { get; set; }
        public string? TitleDutch { get; set; }
        public string? TitleFrench { get; set; }
        public string? CollectionMarkAccessible { get; set; }
        public int MyProperty { get; set; }
        public virtual Date? Date { get; set; }
        public virtual Signature? Signature { get; set; }
        public virtual ICollection<Inscription>? Inscriptions { get; set; }
        public virtual ICollection<CollectionMark>? CollectionMarks { get; set; }
        public string? Materials { get; set; }
        public string? Techniques { get; set; }
        public string? Support { get; set; }

        [NotMapped]
        public List<string>? Framed { get; set; }

        public string? FramedSerialized
        {
            get => JsonConvert.SerializeObject(Framed);
            set => Framed = JsonConvert.DeserializeObject<List<string>>(value);
        }
        public int? Top { get; set; }
        public int? Right { get; set; }
        public int? Bottom { get; set; }
        public int? Left { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public string? Shape { get; set; }

        //for links
        public string RegistrationID { get; set; }
        public virtual Registration? Registration { get; set; }

    }
}
