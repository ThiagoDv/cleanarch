using cleanarch.Domain.Entities;

namespace cleanarch.Domain.Interfaces
{
    /// <summary>
    /// CONTRATO PARA MANIPULAR O OBJETO PRODUTO NO BANCO.
    /// </summary>
    public interface IProductRepository
    {
            #region SELECTS
            public Task<IEnumerable<Product>> GetAllProducts();

            public Task<Product> GetProductById(int id);
            #endregion

            #region CRUD
            public void Create(Product Product);
            public void Update(Product Product);
            public void Delete(Product Product);
            #endregion   
    }
}
