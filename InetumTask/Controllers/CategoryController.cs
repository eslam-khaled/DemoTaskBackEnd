using DemoTask.Business.BusinessInterface;
using DemoTask.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryBusiness _teamBusiness;
        public CategoryController(ICategoryBusiness teamBusiness)
        {
            _teamBusiness = teamBusiness;
        }

        [HttpPost]
        public CategoryDto AddTeam(CategoryDto teamDto)
        {
            return _teamBusiness.AddTeam(teamDto);
        }

        [HttpDelete]
        public bool DeleteTeamById(int Id)
        {
            return _teamBusiness.DeleteTeamById(Id);
        }

        [HttpPut]
        public CategoryDto UpdateTeam(CategoryDto teamDto)
        {
            return _teamBusiness.UpdateCategory(teamDto);
        }

        [HttpGet]
        public IEnumerable<CategoryDto> GetTeamsList()
        {
            return _teamBusiness.GetCategoriesList();
        }

        [HttpGet]
        [Route("GetTeamById")]
        public CategoryDto GetTeamById(int Id)
        {
            return _teamBusiness.GetCategoryById(Id);
        }


    }
}
