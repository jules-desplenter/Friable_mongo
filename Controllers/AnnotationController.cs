using Friable_mongo.InfoModels.DTO;
using Friable_mongo.Models;
using Friable_mongo.Models.DTO;
using Friable_mongo.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;

namespace Friable_mongo.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AnnotationController : ControllerBase
    {
        private readonly AnnotationService _annotationService;

        public AnnotationController(AnnotationService annotationService)
        {
            _annotationService = annotationService;
        }

        [HttpGet("{id}/canvas/p{page}")]
        public async Task<ActionResult<AnnotationsTarget>> GetAnnotations(string id, int page)
        {
            var book = await _annotationService.GetAnnotations(id, page - 1);

            if (book is null)
            {
                return Ok(new List<Annotations>());
            }

            return book.FirstOrDefault();
        }


        [HttpGet("/api/manifest/{id}/page/p2/{page}")]
        public async Task<ActionResult<AnnotationsTarget>> GetAnnotationsExtra(string id, int page)
        {
            var book = await _annotationService.GetAnnotations(id, page - 1);

            if (book is null)
            {
                return Ok(new List<Annotations>());
            }

            return book.FirstOrDefault();
        }

        [HttpGet("/api/manifest/{id}/canvas/p{page}")]
        public async Task<ActionResult<AnnotationsTarget>> GetAnnotationsExtraExtra(string id, int page)
        {
            var book = await _annotationService.GetAnnotations(id, page - 1);

            if (book is null)
            {
                return Ok(new List<Annotations>());
            }

            return book.FirstOrDefault();
        }

        [HttpPost]
        public async Task<ActionResult> AddAnnotation([FromBody] AddAnnotationDTO anno)
        {
            Console.WriteLine(anno);
            var jsonObject = JsonConvert.DeserializeObject<dynamic>(anno.data);
            await _annotationService.AddAnnotation(jsonObject, anno.Canvas);
            return Ok("joepie");
        }

        [HttpDelete("{id}/canvas/p{page}/{annoid}")]
        public async Task<ActionResult> DeleteAnnotations(string id, int page, string annoid)
        {
            await _annotationService.DeleteAnnotation(id, page, annoid);
            return Ok("deleted");
        }

        [HttpGet("{id}/canvas/p{page}/{annoid}")]
        public async Task<ActionResult<AnnotationTarget>> GetAnnotation(string id, int page, string annoid)
        {
            AnnotationTarget ano = await _annotationService.GetAnnotation(id, page, annoid);
            return Ok(ano);
        }

        [HttpPost("{id}/canvas/p{page}/{annoid}")]
        public async Task<ActionResult<AnnotationTarget>> EditAnnoation([FromBody] AddAnnotationDTO anno, string id, int page, string annoid)
        {
            var jsonObject = JsonConvert.DeserializeObject<dynamic>(anno.data);
            AnnotationTarget ano = await _annotationService.UpdateAnnotation(jsonObject, id, page, annoid);
            return Ok(ano);
        }
    }

}
