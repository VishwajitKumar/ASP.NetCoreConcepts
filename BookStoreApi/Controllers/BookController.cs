using AutoMapper;
using BookStoreApi.Model;
using BookStoreApi.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookController(IBookRepository bookRepository,IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        [HttpGet("")]
        public async Task<IActionResult> GetBooks()
        {
            var result = await _bookRepository.GetAllBooks();
            return Ok(result);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetBookById([FromRoute] int Id)
        {
            var result = await _bookRepository.GetBookById(Id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpPost("")]
        public async Task<IActionResult> AddBook([FromBody] BookDto bookDto)
        {
            int Id = await _bookRepository.AddBook(bookDto);
            return CreatedAtAction(nameof(GetBookById), new { id = Id, controller = "Book" }, Id);
        }
        [HttpPut("{Id}")]
        public async Task<bool> UpdateBook([FromRoute]int Id,[FromBody] BookDto bookDto)
        {
            return await _bookRepository.UpdateBook(Id, bookDto);
        }

        [HttpPatch("{Id}")]
        public async Task<bool> UpdateBookJsonPatch([FromRoute] int Id, [FromBody] JsonPatchDocument bookDto)
        {
            return await _bookRepository.UpdateBookJsonPatch(Id, bookDto);
        }
        [HttpDelete("{Id}")]
        public async Task<bool> DeleteBookAsync(int Id)
        {
            return await _bookRepository.DeleteBookAsync(Id);
        }
    }
}
