using AutoMapper;
using BookStoreApi.Data;
using BookStoreApi.Model;

namespace BookStoreApi.Mapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Book, BookDto>().ReverseMap();
        }
    }
}
