using Friable_mongo.Models;
using Friable_mongo.Models.DTO;
using Friable_mongo.Services;
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

            return book;
        }

        [HttpPost()]
        public async Task<IActionResult> Post(Manifest newManifest)
        {
            await _manifestService.CreateAsync(newManifest);

            //return CreatedAtAction(nameof(Get), new { id = newManifest.Id }, newManifest);
            return Ok(newManifest);
        }

        [HttpPost("/create")]
        public async Task<IActionResult> Post(AddManifestDTO newManifest)
        {
            await _manifestService.AddManifestDTO(newManifest);

            //return CreatedAtAction(nameof(Get), new { id = newManifest.Id }, newManifest);
            return Ok(newManifest);
        }

        [HttpPut("{*id}")]
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
    }
}
