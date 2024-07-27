using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos;
using api.Helpers;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class BookAuthorRepository : IBookAuthorRepository
    {
        private readonly ApplicationDBContext _context;
        public BookAuthorRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<BookAuthor>> GetAllAsync(BookAuthorQueryObject query)
        {
            var bookAuthors = _context.BookAuthors.Include(c => c.Author).Include(a => a.Book).ThenInclude(b => b.Publisher).Include(y => y.Book.Item).AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.Name))
            {
                bookAuthors = bookAuthors.Where(s => s.Book.Item.Name.Contains(query.Name));
            };

            if (!string.IsNullOrWhiteSpace(query.AuthorName))
            {
                bookAuthors = bookAuthors.Where(s => s.Author.Name.Contains(query.AuthorName));
            };


            if (!string.IsNullOrWhiteSpace(query.ISBN))
            {
                bookAuthors = bookAuthors.Where(s => s.Book.ISBN.Contains(query.ISBN));
            };

             if (!string.IsNullOrWhiteSpace(query.PublisherName))
            {
                bookAuthors = bookAuthors.Where(s => s.Book.Publisher.Name.Contains(query.PublisherName));
            };           

            if (!string.IsNullOrWhiteSpace(query.SortBy))
            {
                if (query.SortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    bookAuthors = query.IsDecsending ? bookAuthors.OrderByDescending(s => s.Book.Item.Name) : bookAuthors.OrderBy(s => s.Book.Item.Name);
                }
            }

            var skipNumber = (query.PageNumber - 1) * query.PageSize;

            return await bookAuthors.Skip(skipNumber).Take(query.PageSize).ToListAsync();
        }
    }
}