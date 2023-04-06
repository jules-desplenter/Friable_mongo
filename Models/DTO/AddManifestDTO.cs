using System.Data;

namespace Friable_mongo.Models.DTO
{
    public class AddManifestDTO
    {
        public string Label { get; set; }
        public string? Date { get; set; }
        public string? Classification { get; set; }
        public string ObjectNumber { get; set; }
        public string? Artist { get; set; }
        public string? Medium { get; set; }
        public string? Technique { get; set; }
        public string? Provenance { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Imagelink { get; set; }
    }
}
