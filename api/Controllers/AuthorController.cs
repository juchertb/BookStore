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
    [Route("api/author")]
    public class AuthorController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IAuthorRepository _authorRepo;
        public AuthorController(ApplicationDBContext context, IAuthorRepository authorRepo)
        {
            _authorRepo = authorRepo;
            _context = context;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAll([FromQuery] AuthorQueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var authors = await _authorRepo.GetAllAsync(query);

            var authorDto = authors.Select(s => s.ToAuthorDto()).ToList();

            return Ok(authorDto);
        }     
    }
}