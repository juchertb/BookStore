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
    [Route("api/bookauthor")]
    public class BookAuthorController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IBookAuthorRepository _bookAuthorRepo;
        public BookAuthorController(ApplicationDBContext context, IBookAuthorRepository bookAuthorRepo)
        {
            _bookAuthorRepo = bookAuthorRepo;
            _context = context;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAll([FromQuery] BookAuthorQueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var bookAuthors = await _bookAuthorRepo.GetAllAsync(query);

            var bookAuthorDto = bookAuthors.Select(s => s.ToBookAuthorDto()).ToList();

            return Ok(bookAuthorDto);
        }           
    }
}