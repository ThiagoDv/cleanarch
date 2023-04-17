using AutoMapper;
using cleanarch.Application.DTOs;
using cleanarch.Application.Interfaces;
using cleanarch.Domain.Entities;
using cleanarch.Domain.Interfaces;

namespace cleanarch.Application.Services
{
    public class ProductService : IProductService
    {
        private IMapper _mapper;
        private IProductRepository _productRepository;
        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public async Task Create(ProductDTO product)
        {
            var productEntity = _mapper.Map<Product>(product);
            await _productRepository.Create(productEntity);
        }

        public async Task Delete(ProductDTO product)
        {
            var productEntity = _mapper.Map<Product>(product);
            await _productRepository.Delete(productEntity);
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync()
        {
            var productEntity = await _productRepository.GetAllProducts();
            return _mapper.Map<IEnumerable<ProductDTO>>(productEntity);
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var productEntity = await _productRepository.GetProductById(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task Update(ProductDTO product)
        {
            var productEntity = _mapper.Map<Product>(product);
            await _productRepository.Update(productEntity);
        }
    }
}
