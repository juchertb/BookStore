using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Dtos
{
    public class BookAuthorDto
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }     
        public api.Models.Book Book { get; set; }  
        public Author Author { get; set; }
    }
}