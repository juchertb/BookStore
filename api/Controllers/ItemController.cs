using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos;
using api.Helpers;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IItemRepository _itemRepo;
        public ItemController(ApplicationDBContext context, IItemRepository itemRepo)
        {
            _itemRepo = itemRepo;
            _context = context;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAll([FromQuery] ItemQueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var items = await _itemRepo.GetAllAsync(query);

            var itemDto = items.Select(s => s.ToItemDto()).ToList();

            return Ok(itemDto);
        }     
    }
}