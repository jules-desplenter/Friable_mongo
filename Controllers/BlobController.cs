using Friable_mongo.BlobModels;
using Friable_mongo.Services;
using Microsoft.AspNetCore.Mvc;

namespace Friable_mongo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlobController : ControllerBase
    {
        private readonly IAzureStorage _azureStorage;

        public BlobController(IAzureStorage azureStorage)
        {
            this._azureStorage = azureStorage;
        }


        [HttpGet]
        public async Task<List<BlobDTO>> Get() =>
                   await _azureStorage.ListAsync();

        [HttpGet("{*name}")]
        public async Task<BlobDTO> GetByName(string name) =>
            await _azureStorage.DownloadAsync(name);

        [HttpPost]
        public async Task<BlobResponseDTO> UploadBlob([FromForm(Name = "file")] IFormFile file) =>
            await _azureStorage.UploadAsync(file);

        [HttpDelete("{*name}")]
        public async Task<BlobResponseDTO> DeleteBlob(string name) =>
            await _azureStorage.DeleteAsync(name);
    }
}
