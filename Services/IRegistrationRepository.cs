using Friable_mongo.InfoModels;
using Friable_mongo.InfoModels.DTO;

namespace Friable_mongo.Services
{
    public interface IRegistrationRepository
    {
        Task<string> AddRegistration(RegistrationDTO reg);
        Task<Registration> GetRegistrationById(Guid id);
        Task<List<RegistrationDTO>> GetRegistrations();
        Task<string> RemoveRegistration(Guid id);
        Task<string> UpdateRegistration(Guid id, Registration reg);
    }
}