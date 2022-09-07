using AutoMapper;
using bookstoreappApi.Data;
using bookstoreappApi.models.author;

namespace bookstoreappApi.configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<authorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdatedDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();

        }
    }
}
