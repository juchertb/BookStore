using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Models;

namespace api.Mappers
{
    public static class ItemMappers
    {
        public static ItemDto ToItemDto(this Item itemModel)
        {
            return new ItemDto
            {
                Id = itemModel.Id,
                Name = itemModel.Name,
                //TypeId = itemModel.TypeId,
                Type = itemModel.Type,
                ImageFileSpec = itemModel.ImageFileSpec,
                Description = itemModel.Description,
                UnitCost = itemModel.UnitCost,
                UnitPrice = itemModel.UnitPrice
            };
        }
    }
}
