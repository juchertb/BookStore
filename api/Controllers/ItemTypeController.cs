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
    [Route("api/itemtype")]
    [ApiController]
    public class ItemTypeController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IItemTypeRepository _itemTypeRepo;
        public ItemTypeController(ApplicationDBContext context, IItemTypeRepository itemTypeRepo)
        {
            _itemTypeRepo = itemTypeRepo;
            _context = context;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var itemTypes = await _itemTypeRepo.GetAllAsync();

            var itemDto = itemTypes.Select(s => s.ToItemTypeDto()).ToList();

            return Ok(itemDto);
        }     
    }
}