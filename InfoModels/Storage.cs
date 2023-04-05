using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Friable_mongo.InfoModels
{
    public class Storage
    {
        [Key]
        public Guid Id { get; set; }

        public string? Location { get; set; }
        public int? LocationNumber { get; set; }
        public string? StorageType { get; set; }

        [NotMapped]
        public List<string>? Material { get; set; }

        public string? MaterialSerialized
        {
            get => JsonConvert.SerializeObject(Material);
            set => Material = JsonConvert.DeserializeObject<List<string>>(MaterialSerialized);
        }

        public string? Remarks { get; set; }


        //for links
        public Guid RegistrationID { get; set; }
        public virtual Registration? Registration { get; set; }
    }
}
