using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Publisher;
using api.Models;

namespace api.Mappers
{
    public static class PublisherMappers
    {
        public static PublisherDto ToPublisherDto(this Publisher publisherModel)
        {
            return new PublisherDto
            {
                Id = publisherModel.Id,
                Name = publisherModel.Name
            };
        }
    }
}