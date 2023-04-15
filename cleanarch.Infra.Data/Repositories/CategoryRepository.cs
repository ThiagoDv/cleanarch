using cleanarch.Domain.Entities;
using cleanarch.Domain.Interfaces;
using cleanarch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace cleanarch.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext _categoryContext;
        public CategoryRepository(ApplicationDbContext context)
        {
            _categoryContext = context;
        }

        #region SELECTS
        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _categoryContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryContext.Categories.FindAsync(id);
        }


        #endregion

        #region CRUD
        public async Task<Category> Create(Category category)
        {
            _categoryContext.Add(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async void Delete(Category category)
        {
            _categoryContext.Remove(category);
            await _categoryContext.SaveChangesAsync();
        }

        public async Task<Category> Update(Category category)
        {
            _categoryContext.Update(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }
        #endregion
    }
}
