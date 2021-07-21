using AutoMapper;
using ECommerce.DAL.Tables;
using ECommerce.DTOs;
using ECommerce.Repositories;
using ECommerce.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class ProductService : IProductService
    {
        private readonly ECommUoW _uow;
        private readonly IMapper _mapper;

        public ProductService(ECommUoW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<int> AddProduct(ProductDTO product)
        {
            var repo = _uow.ProductRepository;
            var productToAdd = _mapper.Map<ProductDTO, Product>(product);
            repo.Add(productToAdd);
            await _uow.SaveAsync();
            return productToAdd.Id;
        }

        public async Task<ProductDTO> GetProduct(int id)
        {
            var product = await _uow.ProductRepository.GetByIDAsync(id);
            return _mapper.Map<Product, ProductDTO>(product);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var products = await _uow.ProductRepository.GetAllAsync();
            return products.Select(x => _mapper.Map<Product, ProductDTO>(x));
        }
    }
}
