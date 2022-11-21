using AutoMapper;
using Domain;

namespace Application.Documents.Common
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Document, Document>();
        }
    }
}