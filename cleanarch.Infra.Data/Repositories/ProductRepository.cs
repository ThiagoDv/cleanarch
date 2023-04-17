using cleanarch.Domain.Entities;
using cleanarch.Domain.Interfaces;
using cleanarch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace cleanarch.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _productContext;
        public ProductRepository(ApplicationDbContext context)
        {
            _productContext = context;
        }

        #region SELECTS
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productContext.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _productContext.Products.FindAsync(id);
        }

        #endregion

        #region CRUD

        public async Task<Product> Create(Product product)
        {
            _productContext.Add(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> Update(Product product)
        {
            _productContext.Update(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public async Task Delete(Product product)
        {
            _productContext.Remove(product);
            await _productContext.SaveChangesAsync();
        }
        #endregion
    }
}
