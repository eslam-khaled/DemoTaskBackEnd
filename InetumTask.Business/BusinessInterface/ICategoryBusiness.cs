using DemoTask.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTask.Business.BusinessInterface
{
    public interface ICategoryBusiness
    {
        /// <summary>
        /// Get all teams
        /// </summary>
        /// <returns><see cref=""/></returns>
        ICollection<CategoryDto> GetCategoriesList();

        /// <summary>
        /// Get one team by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns><see cref="Id"/></returns>
        CategoryDto GetCategoryById(int Id);

        /// <summary>
        /// Add new team
        /// </summary>
        /// <param name="teamDto"><see cref="teamDto"/></param>
        /// <returns></returns>
        CategoryDto AddTeam(CategoryDto teamDto);

        /// <summary>
        /// Update team info
        /// </summary>
        /// <param name="teamDto"><see cref="teamDto"/></param>
        /// <returns></returns>
        CategoryDto UpdateCategory(CategoryDto teamDto);

        /// <summary>
        /// Delete team by id
        /// </summary>
        /// <param name="Id"><see cref="Id"/></param>
        /// <returns></returns>
        bool DeleteTeamById(int Id);

    }
}
