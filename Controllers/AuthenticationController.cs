using Friable_mongo.InfoModels.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Friable_mongo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginDTO dto)
        {
            if (dto.UserName != "kmskb" || dto.Password != "friable")
                return Unauthorized();

            const string secretKey = "hierkomtnuietsgeheimwatwelcoolis";
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

            var jwt = new JwtSecurityToken(
                signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
            );

            var token = new JwtSecurityTokenHandler().WriteToken(jwt);

            // Return the JWT to the client
            return Ok(new { token });
        }
    }
}
