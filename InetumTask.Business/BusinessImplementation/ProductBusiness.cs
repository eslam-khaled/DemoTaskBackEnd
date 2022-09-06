using AutoMapper;
using DemoTask.Business.BusinessInterface;
using DemoTask.DAL.BaseRepository;
using DemoTask.DAL.Models;
using DemoTask.DAL.UnitOfWork;
using DemoTask.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTask.Business.BusinessImplementation
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IBaseRepository<Product> _baseRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _UnitOfWork;

        public ProductBusiness(IBaseRepository<Product> baseRepository, IMapper mapper, IUnitOfWork UnitOfWork)
        {
            _mapper = mapper;
            _baseRepository = baseRepository;
            _UnitOfWork = UnitOfWork;
        }

        /// <inheritdoc/>
        public async Task<bool> AddProductsList(IEnumerable<ProductDto> ProductsListDto)
        {
            var mappedList = _mapper.Map<List<Product>>(ProductsListDto);

            await _UnitOfWork.Product.AddList(mappedList);
            return true;
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteProductById(int Id)
        {
            if (Id == 0)
            {
                return false;
            }
            var player = _UnitOfWork.Product.GetWhere(x => x.Id == Id && x.IsDeleted == false).FirstOrDefault();
            player.IsDeleted = true;
            await _UnitOfWork.Product.Update(player);
            return true;
        }

        /// <inheritdoc/>
        public bool DeleteProductsListByCategoryId(int CategoryId)
        {
            try
            {
                if (CategoryId == 0)
                {
                    return false;
                }

                var playersList = _UnitOfWork.Product.GetWhere(x => x.CategoryId == CategoryId && x.IsDeleted == false).ToList();

                foreach (var player in playersList)
                {
                    player.IsDeleted = true;
                    _UnitOfWork.Product.Update(player);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <inheritdoc/>
        public IEnumerable<ProductDto> GetProductsListByCategoryId(int CategoryId)
        {
            var PlayersList = _UnitOfWork.Product.GetWhere(x => x.CategoryId == CategoryId && x.IsDeleted == false);

            var mapped = _mapper.Map<List<ProductDto>>(PlayersList);

            return mapped;
        }
    }
}
