using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Friable_mongo.InfoModels
{
    public class Mounting
    {
        [Key]
        public Guid Id { get; set; }

        public string? Nature { get; set; }
        public string? Assemblage { get; set; }
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
        public string? MyProperty { get; set; }


        //for links
        public Guid RegistrationID { get; set; }
        public virtual Registration? Registration { get; set; }
    }
}
