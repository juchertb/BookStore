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
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDBContext _context;
        public ItemRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<Item>> GetAllAsync(ItemQueryObject query)
        {
            var items = _context.Items.Include(c => c.Type).AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.BookName))
            {
                items = items.Where(s => s.Name.Contains(query.BookName));
            };

            if (!string.IsNullOrWhiteSpace(query.TypeName))
            {
                items = items.Where(s => s.Type.Name.Contains(query.TypeName));
            };           

            if (!string.IsNullOrWhiteSpace(query.SortBy))
            {
                if (query.SortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    items = query.IsDecsending ? items.OrderByDescending(s => s.Name) : items.OrderBy(s => s.Name);
                }
            }

            var skipNumber = (query.PageNumber - 1) * query.PageSize;

            return await items.Skip(skipNumber).Take(query.PageSize).ToListAsync();        
        }
    }
}