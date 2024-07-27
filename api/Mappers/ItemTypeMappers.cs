using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Models;

namespace api.Mappers
{
    public static class ItemTypeMappers
    {
        public static ItemTypeDto ToItemTypeDto(this ItemType itemTypeModel)
        {
            return new ItemTypeDto
            {
                Id = itemTypeModel.Id,
                Name = itemTypeModel.Name,
                Description = itemTypeModel.Description,
            };
        }
    }
}
