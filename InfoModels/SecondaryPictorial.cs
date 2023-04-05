using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Friable_mongo.InfoModels
{
    public class SecondaryPictorial
    {

        [Key]
        public Guid Id { get; set; }

        [NotMapped]
        public List<string>? FriableMedia { get; set; }

        public string? FriableMediaSerialized
        {
            get => JsonConvert.SerializeObject(FriableMedia);
            set => FriableMedia = JsonConvert.DeserializeObject<List<string>>(FriableMediaSerialized);
        }
        public string? Fixative { get; set; }

        [NotMapped]
        public List<string>? OtherMedia { get; set; }

        public string? OtherMediaSerialized
        {
            get => JsonConvert.SerializeObject(OtherMedia);
            set => OtherMedia = JsonConvert.DeserializeObject<List<string>>(OtherMediaSerialized);
        }

        [NotMapped]
        public List<string>? Techniques { get; set; }

        public string? TechniquesSerialized
        {
            get => JsonConvert.SerializeObject(Techniques);
            set => Techniques = JsonConvert.DeserializeObject<List<string>>(TechniquesSerialized);
        }

        [MaxLength]
        public string? RemarksDescription { get; set; }

        public string? GeneralCondition { get; set; }
        public string? Surface { get; set; }

        [NotMapped]
        public List<string>? Damage { get; set; }

        public string? DamageSerialized
        {
            get => JsonConvert.SerializeObject(Damage);
            set => Damage = JsonConvert.DeserializeObject<List<string>>(DamageSerialized);
        }

        [MaxLength]
        public string? RemarksCondition { get; set; }

        //extra links
        public Guid SupportId { get; set; }
        public virtual SecondarySupport? Support { get; set; }
    }
}
