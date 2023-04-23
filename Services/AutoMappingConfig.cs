using AutoMapper;
using Friable_mongo.InfoModels;
using Friable_mongo.InfoModels.DTO;

namespace Friable_mongo.Services
{
    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<Identification,IdentificationDTO>().ReverseMap();
            CreateMap<Registration, RegistrationDTO>().ReverseMap();
            CreateMap<Date, DateDTO>().ReverseMap();
            CreateMap<CollectionMark, CollectionMarkDTO>().ReverseMap();
            CreateMap<Registration,RegistrationDTO>().ReverseMap();
            CreateMap<Signature,SignatureDTO>().ReverseMap();
            CreateMap<Inscription,InscriptionDTO>().ReverseMap();
            CreateMap<PrimarySupport, SupportDTO>().ReverseMap();
            CreateMap<SecondarySupport, SupportDTO>().ReverseMap();
            CreateMap<Storage, StorageDTO>().ReverseMap();
            CreateMap<Mounting, MountingDTO>().ReverseMap();
            CreateMap<Artist, ArtistDTO>().ReverseMap();
            CreateMap<PrimaryPictorial,PictorialDTO>().ReverseMap();
            CreateMap<SecondaryPictorial, PictorialDTO>().ReverseMap();
            CreateMap<Framing, FramingDTO>().ReverseMap();

        }
    }
}
