namespace Friable_mongo.Models.DTO
{
    public class AddMultipleManifestDTO
    {
        public List<string> Label { get; set; }
        public string? Date { get; set; }
        public string? Classification { get; set; }
        public string ObjectNumber { get; set; }
        public string? Artist { get; set; }
        public string? Medium { get; set; }
        public string? Technique { get; set; }
        public string? Provenance { get; set; }
        public List<int> Height { get; set; }
        public List<int> Width { get; set; }
        public List<string> Imagelink { get; set; }
    }
}
