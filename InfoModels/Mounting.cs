using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Friable_mongo.InfoModels
{
    public class Mounting
    {
        [Key]
        public Guid Id { get; set; }

        [NotMapped]
        public List<string>? Nature { get; set; }
        public string? NatureSerialized
        {
            get => JsonConvert.SerializeObject(Nature);
            set => Nature = JsonConvert.DeserializeObject<List<string>>(value);
        }

        [NotMapped]
        public List<string>? Assemblage { get; set; }

        public string? AssemblageSerialized
        {
            get => JsonConvert.SerializeObject(Assemblage);
            set => Assemblage = JsonConvert.DeserializeObject<List<string>>(value);
        }

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
        public string? DescriptionRemarks { get; set; }

        [MaxLength]
        public string? ConditionRemarks { get; set; }


        //for links
        public string RegistrationID { get; set; }
        public virtual Registration? Registration { get; set; }
    }
}
