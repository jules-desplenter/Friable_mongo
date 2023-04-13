using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Friable_mongo.InfoModels.DTO
{
    public class StorageDTO
    {
        public Guid Id { get; set; }

        public string? Location { get; set; }

        public int? LocationNumber { get; set; }

        public string? StorageType { get; set; }

      

        public List<string>? Material { get; set; }

        public string? MaterialSerialized
        {
            get => JsonConvert.SerializeObject(Material);
            set => Material = JsonConvert.DeserializeObject<List<string>>(MaterialSerialized);
        }

        public string? Remarks { get; set; }
    }
}
