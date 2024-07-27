using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Publisher;
using api.Helpers;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/publisher")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IPublisherRepository _publisherRepo;
        public PublisherController(ApplicationDBContext context, IPublisherRepository publisherRepo)
        {
            _publisherRepo = publisherRepo;
            _context = context;
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var publishers = await _publisherRepo.GetAllAsync();

            var publisherDto = publishers.Select(s => s.ToPublisherDto()).ToList();

            return Ok(publisherDto);
        }      
    }
}