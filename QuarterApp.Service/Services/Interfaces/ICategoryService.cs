using QuarterApp.Service.DTOs;
using QuarterApp.Service.DTOs.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterApp.Service.Services.Interfaces
{
    public interface ICategoryService
    {
        Task CreateAsync(CategoryPostDTO categoryDTO);
        Task<CategoryDetailDTO> GetByIdAsync(int id);
        Task<PagenatedListDTO<CategoryListItemDTO>> GetAllFilteredAsync(int page,string search);
        Task EditAsync(int id,CategoryPostDTO categoryDTO);
        void Delete(int id);
        Task<bool> IsExistByIdAsync(int id);
    }
}
