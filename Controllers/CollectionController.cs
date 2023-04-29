using Friable_mongo.Models;
using Friable_mongo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Friable_mongo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CollectionController : ControllerBase
    {
        private readonly CollectionService _CollectionService;

        public CollectionController(CollectionService CollectionService) =>
            _CollectionService = CollectionService;

        [HttpGet]
        public async Task<List<Collection>> Get() =>
                   await _CollectionService.GetAsync();

        [HttpGet("{*id}")]
        public async Task<ActionResult<Collection>> Get(string id)
        {
            var book = await _CollectionService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost()]
        public async Task<IActionResult> Post(Collection newCollection)
        {
            await _CollectionService.CreateAsync(newCollection);

            //return CreatedAtAction(nameof(Get), new { id = newCollection.Id }, newCollection);
            return Ok(newCollection);
        }

        [HttpPut("{*id}")]
        public async Task<IActionResult> Update(string id, Collection updatedBook)
        {
            var book = await _CollectionService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            updatedBook.Id = book.Id;

            await _CollectionService.UpdateAsync(id, updatedBook);

            return NoContent();
        }

        [HttpDelete("{*id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var book = await _CollectionService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            await _CollectionService.RemoveAsync(id);

            return NoContent();
        }
    }
}
