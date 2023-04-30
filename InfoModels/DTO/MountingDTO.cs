using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Friable_mongo.InfoModels.DTO
{
    public class MountingDTO
    {
        public Guid Id { get; set; }

        public List<string>? Nature { get; set; }
        public string? NatureSerialized
        {
            get => JsonConvert.SerializeObject(Nature);
            set => Nature = JsonConvert.DeserializeObject<List<string>>(NatureSerialized);
        }

        public List<string>? Assemblage { get; set; }

        public string? AssemblageSerialized
        {
            get => JsonConvert.SerializeObject(Assemblage);
            set => Assemblage = JsonConvert.DeserializeObject<List<string>>(AssemblageSerialized);
        }
        public string? GeneralCondition { get; set; }
        public List<string>? Surface { get; set; }

        public string? SurfaceSerialized
        {
            get => JsonConvert.SerializeObject(Surface);
            set => Surface = JsonConvert.DeserializeObject<List<string>>(value);
        }
        public List<string>? Damage { get; set; }

        public string? DamageSerialized
        {
            get => JsonConvert.SerializeObject(Damage);
            set => Damage = JsonConvert.DeserializeObject<List<string>>(DamageSerialized);
        }

        [MaxLength]
        public string? DescriptionRemarks { get; set; }

        [MaxLength]
        public string? ConditionRemarks { get; set; }
    }
}
