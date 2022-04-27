using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterApp.Service.DTOs.CategoryDTO
{
    public class CategoryPostDTO
    {
        public string Name { get; set; }
    }
    public class CategoryPostDTOValidator : AbstractValidator<CategoryPostDTO>
    {
        public CategoryPostDTOValidator()
        {
            RuleFor(x => x.Name).MinimumLength(2).MaximumLength(25);
        }
    }
}
