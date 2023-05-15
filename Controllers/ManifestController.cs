using Friable_mongo.Models;
using Friable_mongo.Models.DTO;
using Friable_mongo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Friable_mongo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManifestController : ControllerBase
    {
        private readonly ManifestService _manifestService;

        public ManifestController(ManifestService manifestService) =>
            _manifestService = manifestService;

        [HttpGet]
        public async Task<List<Manifest>> Get() =>
                   await _manifestService.GetAsync();

        [HttpGet("{id}/manifest.json")]
        public async Task<ActionResult<Manifest>> Get(string id)
        {
            var book = await _manifestService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }
            //book.Items[0].Annotations = new List<AnnotationsTarget>();

            return book;
        }

        [HttpPost()]
        [Authorize]
        public async Task<IActionResult> Post(Manifest newManifest)
        {
            await _manifestService.CreateAsync(newManifest);

            //return CreatedAtAction(nameof(Get), new { id = newManifest.Id }, newManifest);
            return Ok(newManifest);
        }

        [HttpPost("create")]
        [Authorize]
        public async Task<IActionResult> Post(AddManifestDTO newManifest)
        {
            await _manifestService.AddManifestDTO(newManifest);

            //return CreatedAtAction(nameof(Get), new { id = newManifest.Id }, newManifest);
            return Ok(newManifest);
        }

        [HttpPost("createMultiple")]
        [Authorize]
        public async Task<IActionResult> Post(AddMultipleManifestDTO newManifest)
        {
            await _manifestService.AddMultipleManifestDTO(newManifest);

            //return CreatedAtAction(nameof(Get), new { id = newManifest.Id }, newManifest);
            return Ok(newManifest);
        }

        [HttpPost("AddPicture/{*id}")]
        [Authorize]
        public async Task<IActionResult> Addpicture(AddPictureToMAnifestDTO newManifest, string id)
        {
            await _manifestService.AddPictureToManifestDTO(newManifest, id);

            return Ok(newManifest);
        }

        [HttpPut("{*id}")]
        [Authorize]
        public async Task<IActionResult> Update(string id, Manifest updatedBook)
        {
            var book = await _manifestService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            updatedBook.Id = book.Id;

            await _manifestService.UpdateAsync(id, updatedBook);

            return NoContent();
        }

        [HttpDelete("{*id}")]
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            var book = await _manifestService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            await _manifestService.RemoveAsync(id);

            return NoContent();
        }

        [HttpDelete("{id}/{index}")]
        [Authorize]
        public async Task<IActionResult> Delete(string id, int index)
        {
            await _manifestService.DeletePictureAsync(id,index);

            return NoContent();
        }
    }
}
