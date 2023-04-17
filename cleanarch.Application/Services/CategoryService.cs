using AutoMapper;
using cleanarch.Application.DTOs;
using cleanarch.Application.Interfaces;
using cleanarch.Domain.Entities;
using cleanarch.Domain.Interfaces;

namespace cleanarch.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private IMapper _mapper;
        private ICategoryRepository _categoryRepository;
        public CategoryService(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task Create(CategoryDTO category)
        {
            var categoryEntity = _mapper.Map<Category>(category);
            await _categoryRepository.Create(categoryEntity);
        }

        public async Task Delete(int id)
        {
            var categoryEntity = _categoryRepository.GetCategoryById(id).Result;
            await _categoryRepository.Delete(categoryEntity);
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync()
        {
            var categoriesEntity = await _categoryRepository.GetAllCategories();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }

        public async Task<CategoryDTO> GetCategoryByIdAsync(int id)
        {
            var category = await _categoryRepository.GetCategoryById(id);
            return _mapper.Map<CategoryDTO>(category);

        }

        public async Task Update(CategoryDTO category)
        {
            var categoryEntity = _mapper.Map<Category>(category);
            await _categoryRepository.Update(categoryEntity);
        }
    }
}
