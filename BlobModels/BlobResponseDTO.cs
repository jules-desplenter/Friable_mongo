namespace Friable_mongo.BlobModels
{
    public class BlobResponseDTO
    {
        public string? Status { get; set; }
        public bool Error { get; set; }
        public BlobDTO Blob { get; set; }

        public BlobResponseDTO()
        {
            Blob = new BlobDTO();
        }
    }
}
