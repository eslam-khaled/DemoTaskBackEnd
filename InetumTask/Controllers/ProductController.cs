using DemoTask.Business.BusinessInterface;
using DemoTask.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductBusiness _ProdcutBusiness;
        public ProductController(IProductBusiness ProdcutBusiness)
        {
            _ProdcutBusiness = ProdcutBusiness;
        }


        [HttpGet]
        public IEnumerable<ProductDto> GetProdcutsListByTeamId(int TeamId)
        {
            return _ProdcutBusiness.GetProductsListByCategoryId(TeamId);
        }


        [HttpDelete]
        public bool DeleteProdcutsById(int Id)
        {
            return _ProdcutBusiness.DeleteProductById(Id);
        }

    }
}
