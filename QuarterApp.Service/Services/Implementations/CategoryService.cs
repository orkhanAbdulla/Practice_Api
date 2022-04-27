using QuarterApp.Core;
using QuarterApp.Core.Entities;
using QuarterApp.Service.DTOs;
using QuarterApp.Service.DTOs.CategoryDTO;
using QuarterApp.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterApp.Service.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(CategoryPostDTO categoryDTO)
        {
            Category category = new Category { Name = categoryDTO.Name };
            await _unitOfWork.CategoryRepository.InsertAsync(category);
            await _unitOfWork.CommitAsync();
        }

        public async void Delete(int id)
        {
            Category category = await _unitOfWork.CategoryRepository.GetAsync(x=>x.Id==id);
            _unitOfWork.CategoryRepository.Remove(category);
        }

        public async Task EditAsync(int id, CategoryPostDTO categoryDTO)
        {
            Category category = await _unitOfWork.CategoryRepository.GetAsync(x => x.Id == id);
            await _unitOfWork.CategoryRepository.InsertAsync(category);
            await _unitOfWork.CommitAsync();
        }

        public async Task<PagenatedListDTO<CategoryListItemDTO>> GetAllFilteredAsync(int page, string search)
        {
            IEnumerable<Category> categories = await _unitOfWork.CategoryRepository.GetAllPagenatedAsync(x => x.Name == search, page, 10);
            throw new NotImplementedException();
        }

        public Task<CategoryDetailDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
