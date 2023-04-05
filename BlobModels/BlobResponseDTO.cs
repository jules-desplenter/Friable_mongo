﻿namespace Fraible_presentation_api.Models.DTO
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
