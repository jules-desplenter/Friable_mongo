using AutoMapper;
using Friable_mongo.InfoModels;
using Friable_mongo.InfoModels.DTO;
using Friable_mongo.Models;
using Microsoft.EntityFrameworkCore;

namespace Friable_mongo.Services
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public RegistrationRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<RegistrationDTO>> GetRegistrations()
        {
            List<Registration> result = await this._db.Registrations.ToListAsync();
            List<RegistrationDTO> registrations = _mapper.Map<List<RegistrationDTO>>(result);
            return registrations;
        }

        public async Task<Registration> GetRegistrationById(string id)
        {
            var result = await this._db.Registrations.FirstOrDefaultAsync(r => r.Id == id);
            if (result == null)
            {
                return new Registration();
            }
            else
            {
                return result;
            }
        }

        public async Task<string> AddRegistration(RegistrationDTO reg)
        {
            Registration registration = _mapper.Map<Registration>(reg);
            var check = await this._db.Registrations.AddAsync(registration);
            _db.SaveChanges();
            if (check != null)
            {
                return "done";
            }
            else
            {
                return "failed";
            }
        }

        public async Task<string> RemoveRegistration(string id)
        {
            var check = await this._db.Registrations.FirstOrDefaultAsync(r => r.Id == id);
            if (check != null)
            {
                _db.Registrations.Remove(check);
                _db.SaveChanges();
                return "done";
            }
            else
            {
                return "failed";
            }
        }

        public async Task<string> UpdateRegistration(string id, Registration reg)
        {
            var check = await this._db.Registrations.FirstOrDefaultAsync(r => r.Id == id);
            if (check != null)
            {
                _db.Registrations.Remove(check);
                _db.Registrations.Add(reg);
                _db.SaveChanges();
                return "done";
            }
            else
            {
                return "failed";
            }
        }
    }
}
