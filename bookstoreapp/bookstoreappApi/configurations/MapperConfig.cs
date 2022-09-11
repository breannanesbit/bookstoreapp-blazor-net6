using AutoMapper;
using bookstoreappApi.Data;
using bookstoreappApi.models.author;
using bookstoreappApi.models.Book;

namespace bookstoreappApi.configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<authorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdatedDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
            CreateMap<Book, BooksReadOnly>().ForMember(q => q.AuthorName, d => d.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}"));
            

        }
    }
}
