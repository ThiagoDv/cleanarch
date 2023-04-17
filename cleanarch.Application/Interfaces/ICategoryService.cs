using cleanarch.Application.DTOs;

namespace cleanarch.Application.Interfaces
{
    public interface ICategoryService
    {
        #region SELECTS
        public Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();

        public Task<CategoryDTO> GetCategoryByIdAsync(int id);
        #endregion

        #region CRUD
        public Task Create(CategoryDTO category);

        public Task Update(CategoryDTO category);

        public Task Delete(int id);
        #endregion
    }
}
