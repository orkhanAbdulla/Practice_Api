using AutoMapper;
using QuarterApp.Core.Entities;
using QuarterApp.Service.DTOs.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterApp.Service.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDetailDTO>();
            CreateMap<Category, CategoryListItemDTO>();
            CreateMap<CategoryPostDTO, Category>();
        }
    }
}
