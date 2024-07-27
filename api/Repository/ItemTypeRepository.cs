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
    public class ItemTypeRepository : IItemTypeRepository
    {
        private readonly ApplicationDBContext _context;
        public ItemTypeRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<ItemType>> GetAllAsync()
        {
            var itemTypes = _context.ItemTypes.AsQueryable();

            return await itemTypes.ToListAsync();
        }
    }
}