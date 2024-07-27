using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Models;

namespace api.Mappers
{
    public static class ItemCategoryMappers
    {
         public static ItemCategoryDto ToItemCategoryDto(this ItemCategory itemCategoryModel)
        {
            return new ItemCategoryDto
            {
                Item = itemCategoryModel.Item,
                Category = itemCategoryModel.Category
            };
        }       
    }
}