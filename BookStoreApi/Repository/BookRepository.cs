﻿using AutoMapper;
using BookStoreApi.Data;
using BookStoreApi.Model;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApi.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _bookStoreContext;
        private readonly IMapper _mapper;
        public BookRepository(BookStoreContext bookStoreContext, IMapper mapper)
        {
            _bookStoreContext = bookStoreContext;
            _mapper = mapper;
        }

        public async Task<List<BookDto>> GetAllBooks()
        {
            //var books = await _bookStoreContext.Book
            //    .Select(x => new BookDto()
            //    {
            //        Id = x.Id,
            //        Title = x.Title,
            //        Description = x.Description
            //    }).ToListAsync();

            //return books;

            //With AutoMapper
            var books = await _bookStoreContext.Book.ToListAsync();
            return _mapper.Map<List<BookDto>>(books);
        }
        public async Task<BookDto> GetBookById(int Id)
        {
            //var book = await _bookStoreContext.Book.Where(x => x.Id.Equals(Id)).Select(x => new BookDto() { Id = x.Id, Title = x.Title, Description = x.Description }).SingleOrDefaultAsync();
            //return book;

            var book = await _bookStoreContext.Book.FindAsync(Id);

            return _mapper.Map<BookDto>(book);
        }
        public async Task<int> AddBook(BookDto bookDto)
        {
            var book = new Book() { Title = bookDto.Title, Description = bookDto.Description };
            _bookStoreContext.Add(book);
            await _bookStoreContext.SaveChangesAsync();
            return book.Id;
        }
        public async Task<bool> UpdateBook(int Id, BookDto bookDto)
        {
            //First DB hit
            //var book = await _bookStoreContext.Book.FindAsync(Id);
            //if (book != null)
            //{
            //    book.Title = bookDto.Title;
            //    book.Description = bookDto.Description;

            //Second DB hit
            //    await _bookStoreContext.SaveChangesAsync();
            //    return true;
            //}
            //return false;

            Book book = new()
            {
                Id = Id,
                Title = bookDto.Title,
                Description = bookDto.Description
            };
            //Only one DB hit
            _bookStoreContext.Update(book);
            await _bookStoreContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateBookJsonPatch(int Id, JsonPatchDocument bookDto)
        {
            var book = await _bookStoreContext.Book.FindAsync(Id);
            if (book != null)
            {
                bookDto.ApplyTo(book);
                await _bookStoreContext.SaveChangesAsync();
            }
            return true;
        }
        public async Task<bool> DeleteBookAsync(int Id)
        {
            //below will hit db
            //var book = await _bookStoreContext.Book.FindAsync(Id);

            Book book = new Book() { Id = Id };
            _bookStoreContext.Remove(book);
            await _bookStoreContext.SaveChangesAsync();
            return true;
        }
    }
}
