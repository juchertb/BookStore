using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Dtos.ItemCategory
{
    public class ItemCategoryDto
    {
        public api.Models.Item Item { get; set; }  
        public Models.Category Category { get; set; }
    }
}