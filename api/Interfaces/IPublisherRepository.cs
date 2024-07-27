using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Publisher;
using api.Helpers;
using api.Models;

namespace api.Interfaces
{
    public interface IPublisherRepository
    {
        Task<List<Publisher>> GetAllAsync();        
    }
}