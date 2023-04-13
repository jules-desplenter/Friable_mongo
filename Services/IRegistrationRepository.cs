using Friable_mongo.InfoModels;
using Friable_mongo.InfoModels.DTO;

namespace Friable_mongo.Services
{
    public interface IRegistrationRepository
    {
        Task<string> AddRegistration(RegistrationDTO reg);
        Task<RegistrationDTO> GetRegistrationById(string id);
        Task<List<RegistrationDTO>> GetRegistrations();
        Task<string> RemoveRegistration(string id);
        Task<string> UpdateRegistration(string id, RegistrationDTO reg);
    }
}