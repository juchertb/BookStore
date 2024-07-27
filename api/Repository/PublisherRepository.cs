using System.Threading.Tasks;
using api.Data;
using api.Dtos.Publisher;
using api.Helpers;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly ApplicationDBContext _context;
        public PublisherRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<Publisher>> GetAllAsync()
        {
            return await _context.Publishers.ToListAsync();
        }
    }
}