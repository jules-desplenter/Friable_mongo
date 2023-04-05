using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Friable_mongo.InfoModels
{
    public class Identification
    {
        [Key]
        public Guid Id { get; set; }
        public int? InvetoryNumber { get; set; }
        public virtual Artist? Artist { get; set; }
        public string? TitleDutch { get; set; }
        public string? TitleFrench { get; set; }
        public virtual Date? Date { get; set; }
        public virtual Signature? Signature { get; set; }
        public virtual ICollection<Inscription>? Inscriptions { get; set; }
        public virtual ICollection<CollectionMark>? CollectionMarks { get; set; }
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

        //for links
        public Guid RegistrationID { get; set; }
        public virtual Registration? Registration { get; set; }

    }
}
