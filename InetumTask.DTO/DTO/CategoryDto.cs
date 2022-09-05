using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTask.DTO
{
    public class CategoryDto:BaseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductDto> productListDto { get; set; }
    }
}
