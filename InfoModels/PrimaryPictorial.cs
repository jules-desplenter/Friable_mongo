using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Friable_mongo.InfoModels
{
    public class PrimaryPictorial
    {
        [Key]
        public Guid Id { get; set; }

        public string? PictorialAccessible { get; set; }


        [NotMapped]
        public List<string>? FriableMedia { get; set; }

        public string? FriableMediaSerialized
        {
            get => JsonConvert.SerializeObject(FriableMedia);
            set => FriableMedia = JsonConvert.DeserializeObject<List<string>>(value);
        }
        public string? Fixative { get; set; }

        public string? FixativeIndicators { get; set; }


        [NotMapped]
        public List<string>? OtherMedia { get; set; }

        public string? OtherMediaSerialized
        {
            get => JsonConvert.SerializeObject(OtherMedia);
            set => OtherMedia = JsonConvert.DeserializeObject<List<string>>(value);
        }

        [NotMapped]
        public List<string>? Techniques { get; set; }

        public string? TechniquesSerialized
        {
            get => JsonConvert.SerializeObject(Techniques);
            set => Techniques = JsonConvert.DeserializeObject<List<string>>(value);
        }

        [MaxLength]
        public string? RemarksDescription { get; set; }

        public string? GeneralCondition { get; set; }

        [NotMapped]
        public List<string>? Surface { get; set; }

        public string? SurfaceSerialized
        {
            get => JsonConvert.SerializeObject(Surface);
            set => Surface = JsonConvert.DeserializeObject<List<string>>(value);
        }

        [NotMapped]
        public List<string>? Damage { get; set; }

        public string? DamageSerialized
        {
            get => JsonConvert.SerializeObject(Damage);
            set => Damage = JsonConvert.DeserializeObject<List<string>>(value);
        }

        [MaxLength]
        public string? RemarksCondition { get; set; }

        //extra links
        public Guid SupportId { get; set; }
        public virtual PrimarySupport? Support { get; set; }
    }
}
