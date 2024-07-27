using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Models;

namespace api.Mappers
{
    public static class BookAuthorMappers
    {
         public static BookAuthorDto ToBookAuthorDto(this BookAuthor bookAuthorModel)
        {
            return new BookAuthorDto
            {
                BookId = bookAuthorModel.BookId,
                AuthorId = bookAuthorModel.AuthorId,
                Book = bookAuthorModel.Book,
                Author = bookAuthorModel.Author
            };
        }       
    }
}