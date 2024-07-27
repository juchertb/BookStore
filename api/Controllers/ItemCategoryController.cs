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
    [ApiController]
    [Route("api/itemcategory")]
    public class ItemCategoryController : ControllerBase
    {
        readonly ApplicationDBContext _context;
        private readonly IItemCategoryRepository _itemCategoryRepo;
        public ItemCategoryController(ApplicationDBContext context, IItemCategoryRepository itemCategoryRepo)
        {
            _itemCategoryRepo = itemCategoryRepo;
            _context = context;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAll([FromQuery] ItemCategoryQueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var itemCategories = await _itemCategoryRepo.GetAllAsync(query);

            var itemCategoryDto = itemCategories.Select(s => s.ToItemCategoryDto()).ToList();

            return Ok(itemCategoryDto);
        }     
    }
}