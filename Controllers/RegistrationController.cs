using Friable_mongo.InfoModels;
using Friable_mongo.InfoModels.DTO;
using Friable_mongo.Services;
using Microsoft.AspNetCore.Mvc;

namespace Friable_mongo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistrationController : Controller
    {
        public IRegistrationRepository _registrationRepository { get; }


        public RegistrationController(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        [HttpGet]
        public async Task<List<RegistrationDTO>> Get() =>
                  await _registrationRepository.GetRegistrations();

        [HttpGet("{id}")]
        public async Task<ActionResult<Registration>> Get(string id)
        {
            var book = await _registrationRepository.GetRegistrationById(id);

            if (book is null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost()]
        public async Task<IActionResult> Post(RegistrationDTO newRegistration)
        {
            await _registrationRepository.AddRegistration(newRegistration);

            //return CreatedAtAction(nameof(Get), new { id = newRegistration.Id }, newRegistration);
            return Ok(newRegistration);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Registration updatedBook)
        {
            var book = await _registrationRepository.GetRegistrationById(id);

            if (book is null)
            {
                return NotFound();
            }
            updatedBook.Id = book.Id;

            await _registrationRepository.UpdateRegistration(id, updatedBook);

            return NoContent();
        }

        [HttpDelete("{*id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var book = await _registrationRepository.GetRegistrationById(id);

            if (book is null)
            {
                return NotFound();
            }

            await _registrationRepository.RemoveRegistration(id);

            return NoContent();
        }
    }
}
