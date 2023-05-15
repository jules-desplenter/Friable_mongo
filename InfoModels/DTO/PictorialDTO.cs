using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Friable_mongo.InfoModels.DTO
{
    public class PictorialDTO
    {
        public Guid Id { get; set; }

        public string? PictorialAccessible { get; set; }


        public List<string>? FriableMedia { get; set; }

        public string? FriableMediaSerialized
        {
            get => JsonConvert.SerializeObject(FriableMedia);
            set => FriableMedia = JsonConvert.DeserializeObject<List<string>>(FriableMediaSerialized);
        }
        public string? Fixative { get; set; }

        public string? FixativeIndicators { get; set; }

        public List<string>? OtherMedia { get; set; }

        public string? OtherMediaSerialized
        {
            get => JsonConvert.SerializeObject(OtherMedia);
            set => OtherMedia = JsonConvert.DeserializeObject<List<string>>(OtherMediaSerialized);
        }

        public List<string>? Techniques { get; set; }

        public string? TechniquesSerialized
        {
            get => JsonConvert.SerializeObject(Techniques);
            set => Techniques = JsonConvert.DeserializeObject<List<string>>(TechniquesSerialized);
        }

        public string? RemarksDescription { get; set; }

        public string? GeneralCondition { get; set; }
        public List<string>? Surface { get; set; }

        public string? SurfaceSerialized
        {
            get => JsonConvert.SerializeObject(Surface);
            set => Surface = JsonConvert.DeserializeObject<List<string>>(SurfaceSerialized);
        }

        public List<string>? Damage { get; set; }

        public string? DamageSerialized
        {
            get => JsonConvert.SerializeObject(Damage);
            set => Damage = JsonConvert.DeserializeObject<List<string>>(DamageSerialized);
        }

        public string? RemarksCondition { get; set; }
    }
}
