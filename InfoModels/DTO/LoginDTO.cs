using Microsoft.AspNetCore.Mvc;

namespace Friable_mongo.InfoModels.DTO
{
    public class LoginDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
