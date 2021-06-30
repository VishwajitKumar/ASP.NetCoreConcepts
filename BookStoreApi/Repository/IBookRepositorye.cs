using BookStoreApi.Model;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStoreApi.Repository
{
    public interface IBookRepository
    {
        Task<int> AddBook(BookDto bookDto);
        Task<List<BookDto>> GetAllBooks();
        Task<BookDto> GetBookById(int Id);
        Task<bool> UpdateBook(int Id, BookDto bookDto);
        Task<bool> UpdateBookJsonPatch(int Id, JsonPatchDocument bookDto);
        Task<bool> DeleteBookAsync(int Id);
    }
}
