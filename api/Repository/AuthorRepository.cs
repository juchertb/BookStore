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
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDBContext _context;
        public AuthorRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Author>> GetAllAsync(AuthorQueryObject query)
        {
            var authors = _context.Authors.AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.Name))
            {
                authors = authors.Where(s => s.Name.Contains(query.Name));
            }

            if (!string.IsNullOrWhiteSpace(query.SortBy))
            {
                if (query.SortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    authors = query.IsDecsending ? authors.OrderByDescending(s => s.Name) : authors.OrderBy(s => s.Name);
                }
            }

            var skipNumber = (query.PageNumber - 1) * query.PageSize;

            return await authors.Skip(skipNumber).Take(query.PageSize).ToListAsync();
        }
    }
}