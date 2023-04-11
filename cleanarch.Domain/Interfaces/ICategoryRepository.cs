using cleanarch.Domain.Entities;

namespace cleanarch.Domain.Interfaces
{
    /// <summary>
    /// CONTRATO PARA MANIPULAR O OBJETO CATEGORIA NO BANCO.
    /// </summary>
    public interface ICategoryRepository
    {
        #region SELECTS
        public Task<IEnumerable<Category>> GetAllCategories();

        public Task<Category> GetCategoryById(int id);
        #endregion

        #region CRUD
        public void Create(Category category);
        public void Update(Category category);
        public void Delete(Category category);
        #endregion
    }
}
