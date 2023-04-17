using cleanarch.Application.DTOs;

namespace cleanarch.Application.Interfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDTO>> GetAllProductsAsync();

        public Task<ProductDTO> GetProductById(int id);

        public Task Create(ProductDTO product);

        public Task Update(ProductDTO product);

        public Task Delete(ProductDTO product);
    }
}
