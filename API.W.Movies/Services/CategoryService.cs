using API.W.Movies.DAL.Models;
using API.W.Movies.DAL.Models.Dtos;
using API.W.Movies.Repository.IRepository;
using API.W.Movies.Services.IServices;
using AutoMapper;

namespace API.W.Movies.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<bool> CategoryExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CategoryExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryDto> CreateCategoryAsync(CategoryCreateUpdateDto categoryCreateDto)
        {
            
            var categoryExists = await _categoryRepository.CategoryExistsByNameAsync(categoryCreateDto.Name);

            if (categoryExists)
            {
                throw new InvalidOperationException($"Ya existe una categoría con el nombre de '{categoryCreateDto.Name}'");
            }

            
            var category = _mapper.Map<Category>(categoryCreateDto);

            
            var categoryCreated = await _categoryRepository.CreateCategoryAsync(category);

            if (!categoryCreated)
            {
                throw new Exception("Ocurrió un error al crear la categoría.");
            }

            
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            
            var categoryExists = await _categoryRepository.GetCategoryAsync(id);

            if (categoryExists == null)
            {
                throw new InvalidOperationException($"No se encontró la categoría con ID: '{id}'");
            }

            
            var categoryDeleted = await _categoryRepository.DeleteCategoryAsync(id);

            if (!categoryDeleted)
            {
                throw new Exception("Ocurrió un error al eliminar la categoría.");
            }

            return categoryDeleted;
        }

        public async Task<ICollection<CategoryDto>> GetCategoriesAsync()
        {
            
            var categories = await _categoryRepository.GetCategoriesAsync();

            
            return _mapper.Map<ICollection<CategoryDto>>(categories);
        }


        public async Task<CategoryDto> GetCategoryAsync(int id)
        {
            
            var category = await _categoryRepository.GetCategoryAsync(id);

            if (category == null)
            {
                throw new InvalidOperationException($"No se encontró la categoría con ID: '{id}'");
            }

            
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> UpdateCategoryAsync(CategoryCreateUpdateDto dto, int id)
        {
            
            var categoryExists = await _categoryRepository.GetCategoryAsync(id);

            if (categoryExists == null)
            {
                throw new InvalidOperationException($"No se encontró la categoría con ID: '{id}'");
            }

            var nameExists = await _categoryRepository.CategoryExistsByNameAsync(dto.Name);

            if (nameExists)
            {
                throw new InvalidOperationException($"Ya existe una categoría con el nombre de '{dto.Name}'");
            }

            
            _mapper.Map(dto, categoryExists);

            
            var categoryUpdated = await _categoryRepository.UpdateCategoryAsync(categoryExists);

            if (!categoryUpdated)
            {
                throw new Exception("Ocurrió un error al actualizar la categoría.");
            }

            
            return _mapper.Map<CategoryDto>(categoryExists);
        }
    }
}
