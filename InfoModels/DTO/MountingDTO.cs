using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Friable_mongo.InfoModels.DTO
{
    public class MountingDTO
    {
        public Guid Id { get; set; }

        public string? Nature { get; set; }
        public string? Assemblage { get; set; }
        public string? GeneralCondition { get; set; }
        public string? Surface { get; set; }

        public List<string>? Damage { get; set; }

        public string? DamageSerialized
        {
            get => JsonConvert.SerializeObject(Damage);
            set => Damage = JsonConvert.DeserializeObject<List<string>>(DamageSerialized);
        }

        public string? MyProperty { get; set; }
    }
}
